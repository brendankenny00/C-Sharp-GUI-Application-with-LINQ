using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


interface BankInterface
{
    
    string readCustomerName(int index);
    int readCustomerCount();
    bool searchCustomerName(String name);
    
    int read_account(string nm);
    string readCustomerCurrency(string nm);

    double read_balance(string nm);
    string read_phoneNo(string nm);
    void delete_Record(string nm);
    string Account_Type(string nm);
    string Loan_Approved(string nm);
}

