using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Person
{
    public string Name { get; set; }
    public string PhoneNo { get; set; }

}

class Customer : Person
{

    public int AccountNo { get; set;}
    public double Balance { get; set; }
    public string Currency { get; set; }
    public string Account_Type { get; set; }
    public string LoanApproved { get; set; }
}


