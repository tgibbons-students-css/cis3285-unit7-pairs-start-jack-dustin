using Domain;
using Services;
using System;
using System.Windows.Forms;

namespace AccountsForms
{
    /// <summary>
    /// This is the main GUI form for the accounts
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// accService is the link to the accounts through the 
        /// IAccountServices interface
        /// </summary>
        IAccountServices accService = new AccountService();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Create a new account button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string accountName = txtAccountName.Text;
            listBoxAccounts.Items.Add(accountName);
            accService.CreateAccount(accountName, AccountType.Silver);
        }
        /// <summary>
        /// Account listbox item selected
        /// Find the account and update the balance displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string accName = listBoxAccounts.SelectedItem.ToString();
            decimal balance = accService.GetAccountBalance(accName);

            txtBalance.Text = balance.ToString();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal deposit = Decimal.Parse(txtDepositAmount.Text);
            string accountName = listBoxAccounts.SelectedItem.ToString();

            accService.Deposit(accountName, deposit);

            decimal balance = accService.GetAccountBalance(accountName);
            txtBalance.Text = balance.ToString();

            txtDepositAmount.Text = "";
            ptsBox.Text = accService.GetRewardPoints(accountName).ToString();
        }

        private void btnWithDrawal_Click(object sender, EventArgs e)
        {
            decimal withdraw = Decimal.Parse(txtWithdrawalAmount.Text);
            string accountName = listBoxAccounts.SelectedItem.ToString();

            accService.Withdrawal(accountName, withdraw);

            decimal balance = accService.GetAccountBalance(accountName);
            txtBalance.Text = balance.ToString();

            txtWithdrawalAmount.Text = "";
            ptsBox.Text = accService.GetRewardPoints(accountName).ToString();
        }
    }
}
