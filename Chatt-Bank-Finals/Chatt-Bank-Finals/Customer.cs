using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatt_Bank_Finals
{
    internal class Customer : Person
    {
        // --------------- Properties ---------------
        int id;

        // --------------- Constructors ---------------
        public Customer() : base()
        {
            id = 0;
        }
        public Customer(int id, string firstName, string lastName, string address, string email) 
            : base(firstName, lastName, address, email)
        {
            this.id = id;
        }

        // --------------- Get and Set ---------------
        public int GetId() { return id; }
        public void SetId(int id) { this.id = id; }

        // --------------- Behaviors ---------------
        public void Display(TextBox textBox)
        {
            // The display function is primarily used for testing
            textBox.Text = $"Id: {id}\r\nFirst Name: {this.GetFirstName()}\r\nLast Name: {this.GetLastName()}" +
                $"\r\nAddress: {this.GetAddress()}\r\nEmail: {this.GetEmail()}";
        }

        // --------------- Database access ---------------
        public OleDbConnection con;
        public OleDbCommand selectCommand;
        public OleDbCommand insertCommand;
        public OleDbCommand updateCommand;
        public OleDbCommand deleteCommand;
        public OleDbDataAdapter adapter;
        public string cmd;

        public void DbSetup()
        {
            con = new OleDbConnection();
            selectCommand = new OleDbCommand();
            insertCommand = new OleDbCommand();
            updateCommand = new OleDbCommand();
            deleteCommand = new OleDbCommand();
            adapter = new OleDbDataAdapter();

            adapter.SelectCommand = selectCommand;
            adapter.InsertCommand = insertCommand;
            adapter.UpdateCommand = updateCommand;
            adapter.DeleteCommand = deleteCommand;

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\bdako\\Downloads\\ChattBankMDB.mdb";
        }
        public void SelectDB(int id)
        { // This function will fill out the properties of the customer from the database using a given id
            DbSetup();
            cmd = $@"SELECT * FROM Customers WHERE CustID = '{id}'";
            adapter.SelectCommand.CommandText = cmd;
            adapter.SelectCommand.Connection = con;
            try
            {
                con.Open();
                OleDbDataReader reader;
                reader = adapter.SelectCommand.ExecuteReader();

                reader.Read();
                this.id = id;
                SetFirstName(reader.GetString(2));
                SetLastName(reader.GetString(3));
                SetAddress(reader.GetString(4));
                SetEmail(reader.GetString(5));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void InsertDB(string password)
        { // This function will insert a new customer into the database but requires a password to be passed through
            DbSetup();
            cmd = $@"INSERT INTO Customers (CustID, CustPassword, CustFirstName, CustLastName, CustAddress, CustEmail)" +
                $@" VALUES ('{this.id}', '{password}', '{GetFirstName()}', '{GetLastName()}', '{GetAddress()}', '{GetEmail()}')";
            adapter.InsertCommand.CommandText = cmd;
            adapter.InsertCommand.Connection = con;
            try
            {
                con.Open();
                Debug.WriteLine(adapter.InsertCommand.ExecuteNonQuery());
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void UpdateDB()
        { // Function will update the information of a customer in the table
            DbSetup();
            cmd = $@"UPDATE Customers SET CustFirstName = '{GetFirstName()}', CustLastName = '{GetLastName()}'," +
                $@"CustAddress = '{GetAddress()}', CustEmail = '{GetEmail()}' WHERE CustID = '{id}'";
            adapter.UpdateCommand.CommandText = cmd;
            adapter.UpdateCommand.Connection = con;
            try
            {
                con.Open();
                Debug.WriteLine(adapter.UpdateCommand.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void DeleteDB(int id)
        { // Function removes a customer from the database with a given id
            DbSetup();
            cmd = $@"DELETE FROM Customers WHERE id = '{id}'";
            adapter.DeleteCommand.CommandText = cmd;
            adapter.DeleteCommand.Connection = con;
            try
            {
                con.Open();
                adapter.DeleteCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public string FetchPass(int id)
        {
            string password = "";
            DbSetup();
            cmd = $@"SELECT CustPassword FROM Customers WHERE CustId = '{id}'";
            adapter.SelectCommand.CommandText = cmd;
            adapter.SelectCommand.Connection = con;
            try
            {
                con.Open();
                OleDbDataReader reader;
                reader = adapter.SelectCommand.ExecuteReader();

                reader.Read();
                password = reader.GetValue(0).ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return password;
        }
    }
}
