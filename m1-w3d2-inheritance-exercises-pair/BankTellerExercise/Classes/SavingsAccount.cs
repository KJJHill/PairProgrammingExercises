using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public override DollarAmount Withdraw(DollarAmount amountToWithdraw)
        {
            DollarAmount serviceCharge = new DollarAmount(200);
            DollarAmount totalWithdraw = serviceCharge.Plus(amountToWithdraw);

            if ((Balance.totalAmountInCents >= 15000) &&
                (Balance.totalAmountInCents > amountToWithdraw.totalAmountInCents))
            {
                balance = balance.Minus(amountToWithdraw);
            }
            else if ((Balance.totalAmountInCents < 15000) &&
                (Balance.totalAmountInCents > amountToWithdraw.totalAmountInCents))
            {
                balance = balance.Minus(totalWithdraw);
            }

            return Balance;
        }
    }
}
