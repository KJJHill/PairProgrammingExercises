using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public override DollarAmount Withdraw(DollarAmount amountToWithdraw)
        {
            DollarAmount withdrawFee = new DollarAmount(1000);
            DollarAmount totalWithdraw = withdrawFee.Plus(amountToWithdraw);
 
            if (Balance.Minus(amountToWithdraw).totalAmountInCents > 0)
            {
                balance = balance.Minus(amountToWithdraw);
            }
            else if (Balance.Minus(totalWithdraw).totalAmountInCents > -10000)
            {
                balance = balance.Minus(totalWithdraw);
            }

            return Balance;
        }
    }
}
