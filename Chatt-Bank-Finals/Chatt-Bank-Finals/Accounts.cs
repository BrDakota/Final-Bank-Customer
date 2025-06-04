using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chatt_Bank_Finals
{
    internal class Accounts
    {
        // --------------- Properties ---------------
        int accNo;
        int custId;
        string accType;
        double balance;

        // --------------- Constructors ---------------
        public Accounts()
        {
            accNo = 0;
            custId = 0;
            accType = "";
            balance = 0.00;
        }
        public Accounts(int accNo, int custId, string accType, double balance)
        {
            this.accNo = accNo;
            this.custId = custId;
            this.accType = accType;
            this.balance = balance;
        }

        // --------------- Get and Set ---------------
        public int GetAccNo() { return accNo; }
        public int GetCustId() { return custId; }
        public string GetAccType() { return accType; }
        public double GetBalance() { return balance; }

        public void SetAccNo(int accNo) { this.accNo = accNo; }
        public void SetCustId(int id) { this.custId = id; }
        public void SetAccType(string type) { this.accType = type; }
        public void SetBalance(double balance) { this.balance = balance; }

        // --------------- Behaviors ---------------
        public void Display(TextBox textBox)
        {
            // The display function is primarily used for testing
            textBox.Text = $"Account Number: {accNo}\r\nCustomer Id: {custId}\r\n" +
                $"Account Type: {accType}\r\nBalance: {balance}";
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
        public void SelectDB(int accNo)
        { // This function will fill out the properties of the customer from the database using a given id
            DbSetup();
            cmd = $@"SELECT * FROM Accounts WHERE AcctNo = '{accNo}'";
            adapter.SelectCommand.CommandText = cmd;
            adapter.SelectCommand.Connection = con;
            try
            {
                con.Open();
                OleDbDataReader reader;
                reader = adapter.SelectCommand.ExecuteReader();

                reader.Read();
                this.accNo = accNo;
                SetCustId(Convert.ToInt32(reader.GetString(1)));
                SetAccType(reader.GetString(2));
                SetBalance(Convert.ToDouble(reader.GetValue(3)));
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
        public void InsertDB()
        { // This function will insert a new customer into the database but requires a password to be passed through
            DbSetup();
            cmd = $@"INSERT INTO Accounts (AcctNo, Cid, Type, Balance)" +
                $@"VALUES ('{accNo}', '{custId}', '{accType}', '{balance}')";
            adapter.InsertCommand.CommandText = cmd;
            adapter.InsertCommand.Connection = con;
            try
            {
                con.Open();
                adapter.InsertCommand.ExecuteNonQuery();
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
            cmd = $@"UPDATE Accounts SET Cid = '{custId}', Type = '{accType}', Balance = '{balance}' WHERE AcctNo = '{accNo}'";
            adapter.UpdateCommand.CommandText = cmd;
            adapter.UpdateCommand.Connection = con;
            try
            {
                con.Open();
                adapter.UpdateCommand.ExecuteNonQuery();
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
        public void DeleteDB(int accNo)
        { // Function removes a customer from the database with a given id
            DbSetup();
            cmd = $@"DELETE FROM Accounts WHERE AcctNo = '{accNo}'";
            adapter.DeleteCommand.CommandText = cmd;
            adapter.DeleteCommand.Connection = con;
            try
            {
                con.Open();
                adapter.DeleteCommand.ExecuteNonQuery();
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
        public void UpdateBalance()
        { // This function will update the balance of a customer after changes are made
            DbSetup();
            cmd = $@"UPDATE Accounts SET Balance = '{balance}' WHERE AcctNo = '{accNo}'";
            adapter.UpdateCommand.CommandText = cmd;
            adapter.UpdateCommand.Connection = con;
            try
            {
                con.Open();
                adapter.UpdateCommand.ExecuteNonQuery();
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
        public int GetMaxNum()
        { // Gets max account number to create next account number
            int num = 0;
            DbSetup();
            cmd = "SELECT MAX(AcctNo) FROM Accounts";
            adapter.SelectCommand.CommandText = cmd;
            adapter.SelectCommand.Connection = con;
            try
            {
                con.Open();
                OleDbDataReader reader;
                reader = adapter.SelectCommand.ExecuteReader();

                reader.Read();
                num = Convert.ToInt32(reader.GetValue(0));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally { con.Close(); }
            Debug.WriteLine(num);
            return num;
        }
    }
}