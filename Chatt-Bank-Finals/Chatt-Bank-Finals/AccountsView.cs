using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatt_Bank_Finals
{
    public partial class AccountsView : Form
    {
        public static AccountsView instance;
        internal Customer customer;

        public AccountsView()
        {
            InitializeComponent();
            instance = this;
            customer = Login.instance.customer;
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            if (AccViewRad.Checked) // This checks which radio button is selected
            {
                if (AccNoBox.Text != "") // This is a null check
                {
                    Accounts acc = new Accounts();
                    acc.SelectDB(Convert.ToInt32(AccNoBox.Text));
                    if (customer.GetId() == acc.GetCustId()) // This if statment checks if the customer ids match
                    {
                        acc.Display(AccViewBox);
                    }
                    else
                    {
                        MessageBox.Show("That Account number is not connected to this account");
                    }
                }
                else
                {
                    MessageBox.Show("You forgot to enter an account number");
                }
            }
            else
            {
                string accType = "";
                if (mma.Checked) { accType = "MMA"; }
                else if (chk.Checked) { accType = "CHK"; } // This will determine the account type
                else { accType = "SAV"; }

                // Need to get the next account number in the order
                int nextNum;
                nextNum = new Accounts().GetMaxNum() + 1;

                if (IntDepBox.Text != "") // Checks if deposit is null
                {
                    Accounts acc = new Accounts(nextNum, customer.GetId(), accType, Convert.ToDouble(IntDepBox.Text));
                    acc.InsertDB();
                    MessageBox.Show("Success");
                }
                else
                {
                    Accounts acc = new Accounts(nextNum, customer.GetId(), accType, 0);
                    acc.InsertDB();
                    MessageBox.Show("Success");
                }
            }
        }

        private void AccViewRad_CheckedChanged(object sender, EventArgs e)
        {
            if (AccViewRad.Checked)
            {
                CreatePanel.Visible = false;
            }
            else { CreatePanel.Visible = true; }
        }

        private void DepWitBtn_Click(object sender, EventArgs e)
        {
            Deposit_Withdraw deposit_Withdraw = new Deposit_Withdraw();
            this.Close();
            deposit_Withdraw.Show();
        }
    }
}
