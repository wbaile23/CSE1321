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
	class TestBankAccount
	{
		static void Main(String[] args)
		{
			BankAccount a1 = new BankAccount();

			Console.WriteLine(a1.ToString());

			Console.WriteLine();

			
			DateTime dateCreated = DateTime.Now;

			BankAccount myObject = new BankAccount(123456, 10000.00, 0.025, dateCreated);
			
			myObject.Withdraw(3500.00);
			myObject.Deposit(500.00);
			Console.WriteLine("Account ID: \t\t" + myObject.getId() + "\nAccount Balance: \t$" + myObject.getBalance());
			Console.WriteLine("Monthly Interest \t$" + myObject.getMonthlyInterest());
			Console.WriteLine("Date account created: \t" + myObject.getDateCreated());

			Console.ReadLine();
		}
	}
}
