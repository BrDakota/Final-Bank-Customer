using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatt_Bank_Finals
{
    public partial class Deposit_Withdraw : Form
    {
        public static Deposit_Withdraw instance;
        internal Customer customer;


        public Deposit_Withdraw()
        {
            InitializeComponent();
            instance = this;
            customer = Login.instance.customer;
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            double balance = 0;
            Accounts acc = new Accounts();
            acc.SelectDB(Convert.ToInt32(acctNoBox.Text));
            balance = acc.GetBalance();

            if (customer.GetId() == acc.GetCustId())
            {
                if (deposit.Checked)
                {
                    balance += Convert.ToDouble(amountBox.Text);
                }
                else
                {
                    balance -= Convert.ToDouble(amountBox.Text);
                }

                acc.SetBalance(balance);
                acc.UpdateBalance();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AccountsView accountsView = new AccountsView();
            accountsView.Show();
            this.Close();
        }
    }
}
