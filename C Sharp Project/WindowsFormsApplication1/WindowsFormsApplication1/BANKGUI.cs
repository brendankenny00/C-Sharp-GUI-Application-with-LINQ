using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace WindowsFormsApplication1
{
    

    public partial class BANKGUI : Form
    {
        private BankInterface b;
        static int count, index;

        public BANKGUI()
        {
            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel);
            Type requiredType = typeof(BankInterface);

            try
            {
                b = (BankInterface)Activator.GetObject(requiredType, "tcp://localhost:9998/MyBank");
                Console.WriteLine("Connected:");
            }
            catch (Exception e3) { Console.WriteLine("error:" + e3.ToString()); }
            InitializeComponent();
            count = b.readCustomerCount();
            index = 0; Console.WriteLine("Here1={0}", count);

            display(0); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)// Next Record Button, the user can navigate to the next record
        {
            if (index<(count-1)) 
                index++;
            Console.WriteLine("Display Count={0}", count);
            Console.WriteLine("Display Index={0}", index);
            display(index);

           
        }

        private void button1_Click(object sender, EventArgs e)//First Record Button, displays the first record in the array
        {
            index = 0;
            display(index);

        }

        private void button3_Click(object sender, EventArgs e)//Previous Record Button, the user can navigate through previous records
        {
            if (index > 0)
                index--;
            Console.WriteLine("Display Count={0}", count);
            Console.WriteLine("Display Index={0}", index);
            display(index);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)//Delete Button
        {
          b.delete_Record(t1.Text);
        }

        private void button6_Click(object sender, EventArgs e)//Clear Button, Clears all fields and GUI Components
        {
            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
            t5.Clear();
            checkBox1.Checked = false;
            Current.Checked = false;
            Deposit.Checked = false;
            Student.Checked = false;

        }

        private void button7_Click(object sender, EventArgs e)//Exit Button
        {
            
            MessageBox.Show("Exiting Application"); 
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void display(int index) //Display Method, displays all relevant info to the GUI components - textboxs, radio buttons etc
        {

            String name = b.readCustomerName(index);
            t1.Text = name;
            t2.Text = "" + b.read_account(name);
           t3.Text = "" + b.readCustomerCurrency(name);
           t4.Text = "" + b.read_balance(name);
            t5.Text = "" + b.read_phoneNo(name);

            if (b.Account_Type(name).Equals("Deposit"))
            {
                Deposit.PerformClick();
            }

            else if (b.Account_Type(name).Equals("Current"))
            {
                Current.PerformClick();
            }

            else 
            {
                Student.PerformClick(); Console.WriteLine("Clicked={0}", name);
                Student.Checked = true;

            }

            if (b.Loan_Approved(name).Equals("Yes"))
            {
                checkBox1.Checked = !checkBox1.Checked;   
            }

            else { checkBox1.Checked = false; }
        }

        private void Deposit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nextRecordToolStripMenuItem_Click(object sender, EventArgs e)//Next Record Method Menu Item
        {
            if (index < (count - 1))
                index++;
            Console.WriteLine("Display Count={0}", count);
            Console.WriteLine("Display Index={0}", index);
            display(index);
        }

        private void previousRecordToolStripMenuItem_Click(object sender, EventArgs e)//Previous Record Method Menu Item
        {
            if (index > 0)
                index--;
            Console.WriteLine("Display Count={0}", count);
            Console.WriteLine("Display Index={0}", index);
            display(index);
        }

        private void firstRecordToolStripMenuItem_Click(object sender, EventArgs e)//First Record Menu Item
        {
            index = 0;
            display(index);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)//Search Method Menu Item
        {
            String name = t6.Text;
            bool res = b.searchCustomerName(name);
            if (res == false)
            {
                MessageBox.Show("Not Found");
                t6.Text = "";
            }
            else
            {
                t1.Text = "" + name;
                t2.Text = "" + b.read_account(name);
                t3.Text = "" + b.readCustomerCurrency(name);
                t4.Text = "" + b.read_balance(name);
                t5.Text = "" + b.read_phoneNo(name);
                t6.Text = "";

                if (b.Account_Type(name).Equals("Deposit") && (Deposit.Checked == false))
                {
                    Deposit.PerformClick();
                }

                else if (b.Account_Type(name).Equals("Current"))
                {
                    Current.PerformClick();
                }

                else if (b.Account_Type(name).Equals("Student"))
                {
                    Student.PerformClick();
                }

                if (b.Loan_Approved(name).Equals("Yes"))
                {
                    checkBox1.Checked = !checkBox1.Checked;
                }

                else { checkBox1.Checked = false; }

            }
        }

        private void clearAllFieldsToolStripMenuItem_Click(object sender, EventArgs e)//Clear All Fields Menu Item
        {
            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
            t5.Clear();
            checkBox1.Checked = false;
            Current.Checked = false;
            Deposit.Checked = false;
            Student.Checked = false;

        }

        private void aboutBOIAccountsAdminToolStripMenuItem_Click(object sender, EventArgs e)//About Menu Item
        {
            MessageBox.Show("This System is used to Display for and Search for Bank Customer Records");
           
        }

        private void helpMessageToolStripMenuItem_Click(object sender, EventArgs e)//Help Message
        {
            MessageBox.Show("You Can Do It!");
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)//Exit Application Menu Item
        {
            MessageBox.Show("Exiting Application");
            this.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            String name = t6.Text;
            bool res = b.searchCustomerName(name);
            if (res == false)
            { MessageBox.Show("Not Found");
                t6.Text = "";
            }
            else
            {
                t1.Text = "" + name;
                t2.Text = "" + b.read_account(name);
                t3.Text = "" + b.readCustomerCurrency(name);
                t4.Text = "" + b.read_balance(name);
                t5.Text = "" + b.read_phoneNo(name);
                t6.Text = "";

                if (b.Account_Type(name).Equals("Deposit") && (Deposit.Checked == false))
                {
                    Deposit.PerformClick();
                }

                else if (b.Account_Type(name).Equals("Current"))
                {
                    Current.PerformClick();
                }

                else if (b.Account_Type(name).Equals("Student"))
                {
                    Student.PerformClick();
                }

                if (b.Loan_Approved(name).Equals("Yes"))

                {
                    checkBox1.Checked = !checkBox1.Checked;   
                }

                else { checkBox1.Checked = false; }
            }
        }
    }
}
