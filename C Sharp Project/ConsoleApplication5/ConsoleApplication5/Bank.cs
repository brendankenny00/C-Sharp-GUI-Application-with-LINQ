using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Collections;

class Bank : MarshalByRefObject, BankInterface
{

    Customer [] clist =
    {new    Customer {Name="Brendan Kenny", Currency = "EUR", AccountNo = 12345678, Balance=5000.00, Account_Type ="Student",PhoneNo="0871234567", LoanApproved="Yes" },
    new    Customer {Name="John Kenny", Currency = "USD", AccountNo = 31032568, Balance=7000.00,Account_Type ="Deposit",PhoneNo="0863334995", LoanApproved="No"},
    new    Customer {Name="Diarmuid Kenny", Currency = "GBP", AccountNo = 56781045, Balance=3000.00,Account_Type ="Current",PhoneNo="0853214511", LoanApproved="Yes"},
    new    Customer {Name="Helen Kenny", Currency = "AUD", AccountNo = 11334488, Balance=6000.00, Account_Type ="Deposit",PhoneNo="0861114422", LoanApproved="No"},
    new    Customer {Name="Juliana Kenny", Currency = "USD", AccountNo = 22101778, Balance=16000.00, Account_Type ="Student",PhoneNo="0850002211", LoanApproved="Yes"},
    new    Customer {Name="Eric Kenny", Currency = "USD", AccountNo = 10100110, Balance=63000.00, Account_Type ="Current",PhoneNo="0837760010", LoanApproved="No"},
    new    Customer {Name="Dan McGoldrick", Currency = "NZD", AccountNo = 99033855, Balance=76000.00, Account_Type ="Deposit",PhoneNo="0874574512", LoanApproved="Yes"},
    new    Customer {Name="Elizabeth Petersen", Currency = "CHF", AccountNo = 55889910, Balance=4500.00, Account_Type ="Student",PhoneNo="0864593458", LoanApproved="No"},
    new    Customer {Name="Justin Kennedy", Currency = "GBP", AccountNo = 33765412, Balance=3000.00, Account_Type ="Current",PhoneNo="0856094512", LoanApproved="Yes"},
    new    Customer {Name="Jennifer Kenny", Currency = "AUD", AccountNo = 64400122, Balance=8000.00, Account_Type ="Current",PhoneNo="0836104612", LoanApproved="No"}};


    public string readCustomerName(int index)
{
    var c_list = from a in clist
                     select a;
        Customer c = (Customer)c_list.ElementAt(index);  
      return c.Name;
}

    public int read_account(string nm)
    {
        var c_list = from a in clist
                     where a.Name == nm
                     select a;
        Customer c = (Customer)c_list.ElementAt(0);
        return c.AccountNo;

    }

    public String readCustomerCurrency(string nm)
    {
        var c_list = from a in clist
                     where a.Name==nm
                     select a;
        Customer c = (Customer)c_list.ElementAt(0);
        return c.Currency;
        
    }

    public double read_balance(string nm)
    {
        var c_list = from a in clist
                     where a.Name == nm
                     select a;
        Customer c = (Customer)c_list.ElementAt(0);
        return c.Balance;
    }


    public string read_phoneNo(string nm)
    {
        var c_list = from a in clist
                     where a.Name == nm
                     select a;
        Customer c = (Customer)c_list.ElementAt(0);
        return c.PhoneNo;
    }


    public string Account_Type(string nm)
    {
        var c_list = from a in clist
                     where a.Name == nm
                     select a;
        Customer c = (Customer)c_list.ElementAt(0);
        return c.Account_Type;
    }

    public string Loan_Approved(string nm)
    {
        var c_list = from a in clist
                     where a.Name == nm
                     select a;
        Customer c = (Customer)c_list.ElementAt(0);
        return c.LoanApproved;
    }


    public bool searchCustomerName(String nm)
    {
        var c_list = from a in clist
                     where a.Name == nm
                     select a;
        if (c_list.Count() > 0) return true;
        else return false;

    }


    public void delete_Record(String nm)
    {
        var c_list = from a in clist
                     where a.Name == nm
                     select a;
        ArrayList list = new ArrayList(clist);
        int i = list.IndexOf(c_list);
        Console.WriteLine(i);
        
        list.RemoveAt(i);

            /*Remove(p_list);
        plist = null;
        for (int i=0; i<list.ToArray().Length; i++)
        {
            plist[i] = (Customer)list[i];
        }*/
    }



    public int readCustomerCount()
    {

        return clist.Count();

    }

  
   
}
