using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Customer
    {
        // Customer data variables
        private string custName;
        private int cusAccNo;
        private char custType;
        private double custCharge;
        // path where file will be created or stored
        string path = @"C:\Users\837967\source\repos\C_sharp_practice\Customer Bill\Customer Bill\bin\Debug\Customers.txt";

        public Customer(){} // empty constructor
        public Customer(string name, int AccNo, char type) // custructor for setting name, account and type
        {
            custName = name;
            cusAccNo = AccNo;
            custType = type;
        }

        // get set method for all customer data
        public string getName()
        {
            return custName;
        }
        public void setName(string name)
        {
            custName = name;

        }
        public int getAcc()
        {
            return cusAccNo;
        }
        public void setAcc(int acc)
        {
            cusAccNo = acc;
        }
        public char getCusType()
        {
            return custType;
        }
        public void setCusType(char type)
        {
            custType = type;
        }
        public double getCharge()
        {
            return custCharge;
        }
        public void setCharge(double charge)
        {
            custCharge = charge;
        }

        // update file method to update customer data to the file
        public void updateFile(Customer cus)
        {
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(cus.getName() + "," + cus.getAcc() + "," + cus.getCusType() + "," + cus.getCharge());
                }
            }
        }

        // read file method to display the data
        public List<Customer> readFile()
        {
            List<Customer> data = new List<Customer>(); // create an empty list
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)// while there is still unread data
                    {
                        string line = sr.ReadLine();
                        string[] fields = line.Split(',');// split where the commas are
                        Customer c = new Customer();
                        c.custName = fields[0];
                        c.cusAccNo = Convert.ToInt32(fields[1]);
                        c.custType = Convert.ToChar(fields[2]);
                        c.custCharge = Convert.ToDouble( fields[3]);
                        data.Add(c); // add it to the list
                    }
                }
                return data;
            }
        }

        public override string ToString() //overridden ToString method for display
        {
            return custName + ", " + cusAccNo.ToString() + ", " + custType + ", " + custCharge;
        }

    }
}
