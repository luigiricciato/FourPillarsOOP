using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPillarsOOP.Encapsulation;

internal class BankAccount
{
    private decimal _balance = 0;

    public BankAccount(string ownerName, int accountNumber)
    {
        OwnerName = ownerName;
        AccountNumber = accountNumber;
    }

    public int AccountNumber { get; }
    public string OwnerName { get; }

    public decimal GetBalance()
    {
        return _balance;
    }
    public void MakeWithdrawal(decimal amount)
    {
        if (amount > _balance)
        {
            throw new InvalidOperationException("Not enough money on account");
        }
        _balance -= amount;
    }
    public void MakeDeposit(decimal amount)
    {
        _balance += amount;
    }
}
