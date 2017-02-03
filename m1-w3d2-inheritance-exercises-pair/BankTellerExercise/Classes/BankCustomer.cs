using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankCustomer
    {
        private string name;

        private bool isVip = false;

        private DollarAmount totalCustBalance = new DollarAmount(0);

        public DollarAmount TotalCustBalance
        {
            get { return totalCustBalance; }
        }
        public bool IsVip
        {
            get { return isVip; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        private BankAccount[] accounts = new BankAccount[0];

        public BankAccount[] Accounts
        {
            get { return accounts; }

        }

        public void AddAccount(BankAccount newAccount)
        {
            List<BankAccount> _bankAccountList = accounts.ToList();
            _bankAccountList.Add(newAccount);
            accounts = _bankAccountList.ToArray();

            totalCustBalance = totalCustBalance.Plus(newAccount.Balance);

            if (totalCustBalance.totalAmountInCents >= 2500000)
            {
                isVip = true;
            }

        }


    }
}
