using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * PROJECT 1 REQUIREMENTS:
 *  An existing customer should be able to
 *  1.) Login
 *  2.) View their accounts one at a time by providing Acct No
 *  3.) Create a new Account
 *  4.) Deposit or withdraw from any account
*/ 

namespace Chatt_Bank_Finals
{
    public partial class Login : Form
    {
        public static Login instance;
        internal Customer customer;

        public Login()
        {
            InitializeComponent();
            instance = this;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            /*
             * THIS IS FOR PROJECT 1
             * 
             * The customer should be able to enter an id and password
             * They should be taken to the accounts page if successful login
             * If unsuccessful they should should recieve a message
            */ 
            customer = new Customer();
            if (Log_PassBox.Text == customer.FetchPass(Convert.ToInt32(Log_IdBox.Text)))
            {
                customer.SelectDB(Convert.ToInt32(Log_IdBox.Text));
                AccountsView accountsView = new AccountsView();
                accountsView.Show();
                instance.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }
    }
}
