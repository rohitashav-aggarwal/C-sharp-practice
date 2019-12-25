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
        private string custName;
        private int cusAccNo;
        private char custType;
        private double custCharge;
        string path = @"C:\Users\837967\source\repos\C_sharp_practice\Customer Bill\Customer Bill\bin\Debug\Customers.txt";

        public Customer(){}
        public Customer(string name, int AccNo, char type)
        {
            custName = name;
            cusAccNo = AccNo;
            custType = type;
        }

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
        public void updateFile(Customer cus)
        {
            //string path = @"C:\Users\837967\source\repos\C_sharp_practice\Customer Bill\Customer Bill\bin\Debug\Customers.txt";

            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(cus.getName() + "," + cus.getAcc() + "," + cus.getCusType() + "," + cus.getCharge());
                }
                //FileStream fs = File.Create(path, 8);
            }
        }
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
       
        public override string ToString() // for display
        {
            return custName + ", " + cusAccNo.ToString() + ", " + custType + ", " + custCharge;
        }

    }
}
