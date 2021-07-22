﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    public class BankAccount : IBankAccount
    {
        private double _accountBalance;
        private string _accountName;
        private string _accountNumber;
        private string _accountType;


        public BankAccount(string accountName, string accountNumber, string accountType, double startingBalance = 0)
        {
            _accountName = accountName;
            _accountNumber = accountNumber;
            _accountType = accountType;
            _accountBalance = startingBalance;
        }


        public string AccountName => _accountName;

        public string AccountNumber => _accountNumber;

        public string AccountType => _accountType;

        public double Deposit(double amountToDeposit)
        {
            // Validate the input value to ensure it is positive 
            if (amountToDeposit <= 0)
            {
                Console.WriteLine("Invalid amount! Please enter a positive value.");
            }
            else
            {
                _accountBalance += amountToDeposit;
            }
            return _accountBalance;
        }

        public double GetBalance()
        {
            throw new NotImplementedException();
        }

        public double Withdraw(double amountToWithdraw)
        {
            // Validate the input value to ensure it is positive 
            if (amountToWithdraw <= 0)
            {
                Console.WriteLine("Invalid amount! Please enter a positive value.");
            }
            else if (amountToWithdraw > _accountBalance)
            {
                Console.WriteLine("Insufficient funds! Please enter an amount less than your balance.");
            }
            else
            {
                _accountBalance -= amountToWithdraw;
            }
            return _accountBalance;
        }
    }
}
