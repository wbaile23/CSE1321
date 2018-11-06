using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Class: CSE 1321L
// Section: 08
//Term: Fall 18
// Instructor: Kristin Hegna
// Name: William P. Bailey II
// Assignment#: 6

namespace BankAcct
{
	class BankAccount
	{
		private int id = 0;
		private double balance = 0.0;
		private double annualInterestRate = 0.0;
		private DateTime dateCreated = DateTime.Now;
		public double withdraw = 0;
		public double deposit = 0;


		public BankAccount()
		{
		}
		public BankAccount(int newId, double newBalance, double newAnnualInterestRate, DateTime newDateCreated)
		{
			id = newId;
			balance = newBalance;
			annualInterestRate = newAnnualInterestRate;
			dateCreated = newDateCreated;
		}
		public int getId()
		{
			return id;
		}
		public double getBalance()
		{
			return balance;
		}
		public double getAnnualInterestRate()
		{
			return annualInterestRate;
		}
		public DateTime getDateCreated()
		{
			return dateCreated;
		}

		public void SetId(int acctId)
		{
			id = acctId;
		}
		public void SetBalance(int acctBalance)
		{
			balance = acctBalance;
		}
		public void SetAnnualInterestRate(int acctInterest)
		{
			annualInterestRate = acctInterest;
		}

		public double getMonthlyInterestRate()
		{
			double monthlyInterestRate = annualInterestRate / 12;
			return monthlyInterestRate;
		}
		public double getMonthlyInterest()
		{
			return balance * getMonthlyInterestRate();
		}
		public void Withdraw(double withdraw)
		{
			balance = balance - withdraw;
		}
		public void Deposit(double deposit)
		{
			balance = balance + deposit;
		}
		public override string ToString()
		{
			string account = "Account ID: \t\t" + id + "\nAccount Balance: \t$" + balance + "\nInterest Rate: \t\t" + annualInterestRate + "% \nDate Opened: \t\t" + dateCreated;
			return account;
		}

	}
}
