using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingManagementSystem
{
    public partial class FormBankingSystem : Form
    {
        readonly BankingSystem banksys = new BankingSystem();
        
        public FormBankingSystem()
        {
            InitializeComponent();
            ComboBoxAccType.Items.Add("Current");
            ComboBoxAccType.Items.Add("Savings");
            ClearAccountDetail();
            ShowNextAccountNumber();
        }

        private void ClearAccountDetail()
        {
            LabelDetailAccNo.Text = "";
            LabelDetailName.Text = "";
            LabelDetailBranch.Text = "";
            LabelDetailAccType.Text = "";
            LabelDetailBalance.Text = "";
            LabelDetailSuspended.Text = "";
        }

        private void ShowNextAccountNumber() 
        {
            LabelAccNoCreateNum.Text = Utility.GetNextAccountNo(banksys).ToString();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int accNo = Utility.GetNextAccountNo(banksys);
                string name = TextBoxName.Text;
                string branch = TextBoxBranch.Text;
                string acctyp = ComboBoxAccType.Text;
                double initDepo = Convert.ToDouble(TextBoxInitialDeposit.Text);
                banksys.CreateAccount(accNo, name, branch, acctyp, initDepo);
                
                ShowNextAccountNumber();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void ButtonAccDetail_Click(object sender, EventArgs e)
        {
            try
            {
                int accNo = Convert.ToInt32(TextBoxAccNoDetail.Text);
                BankAccount acc = banksys.FindAccount(accNo);

                LabelDetailAccNo.Text = accNo.ToString();
                LabelDetailName.Text = acc.AccountHolderName;
                LabelDetailBranch.Text = acc.BranchName;
                LabelDetailAccType.Text = acc.AccountType;
                LabelDetailBalance.Text = Math.Round(acc.Balance, 2).ToString();
                LabelDetailSuspended.Text = acc.IsSuspended.ToString();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void ButtonSuspend_Click(object sender, EventArgs e)
        {
            try
            {
                int accNo = Convert.ToInt32(TextBoxAccNoDetail.Text);
                BankAccount acc = banksys.FindAccount(accNo);
                acc.Suspend();
                MessageBox.Show($"Account No: {accNo} is suspended!");
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void ButtonDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                int accNo = Convert.ToInt32(TextBoxAccNoTransact.Text);
                double amount = Convert.ToDouble(TextBoxTransactAmount.Text);

                BankAccount acc = banksys.FindAccount(accNo);
                acc.Deposit(amount);
                double curBalance = Math.Round(acc.Balance, 2);
                MessageBox.Show($"{amount} BDT Deposited. Your current balance is {curBalance} BDT");
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void ButtonWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                int accNo = Convert.ToInt32(TextBoxAccNoTransact.Text);
                double amount = Convert.ToDouble(TextBoxTransactAmount.Text);

                BankAccount acc = banksys.FindAccount(accNo);
                acc.Withdraw(amount);
                double curBalance = Math.Round(acc.Balance, 2);
                MessageBox.Show($"{amount} BDT Withdrawn. Your current balance is {curBalance} BDT");
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void ButtonBalance_Click(object sender, EventArgs e)
        {
            try
            {
                int accNo = Convert.ToInt32(TextBoxAccNoTransact.Text);

                BankAccount acc = banksys.FindAccount(accNo);
                double balance = Math.Round(acc.Balance, 2);
                MessageBox.Show($"Your account Balance is {balance} BDT");

            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
    }
}
