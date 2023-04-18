
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class Bank
{
	private int account_number;
	private string account_name;
	private double account_balance;


	public int Account_Number()
	{
		get { return account_number; }
		set { account_number = value; }
	}

	public string Account_Name()
	{
		get { return account_name; }
		set { account_name = value; }
	}

	public double Account_Balance()
	{
		get { return account_balance; }
		set { account_balance = value; }
	}

	public void Deposit (double amount) 
	{
		account_balance += amount;
	}
	public void Withdraw (double amount)
	{
		account_balance -= amount;
	}
}
