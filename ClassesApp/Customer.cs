using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Customer
    {
        public static int NextId = 0;

        private readonly int _id;

        private string _password;

        public string Password { set { _password = value; } }
        public int Id { get { return _id; } }   
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public Customer()
        {
            _id = NextId++;
            Name = "Default Name";
            Address = "Default Address";
            ContactNumber = "Default Contact Number";
        }
        //public Customer(string name, string address, string contactNumber)
        //{
        //    Name = name;
        //    Address = address;
        //    ContactNumber = contactNumber;
        //}

        //public Customer( string name)
        //{
        //    Name = name;
        //}

        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            _id = NextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void setDetails( string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void getDetails()
        {
            Console.WriteLine("Customer Name: " + Name + " and he lives in " + Address + " and his contact number is " + ContactNumber + " and his ID is " + _id + " and his Password is " + _password);
        }   
    }
}
