using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceClasses;

namespace CustomerTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestCustomerConstructors();
            //TestCustomerPropertyGetters();
            //TestCustomerPropertySetters();
            //TestCustomerListConstructor();
            //TestCustomerListFill(); 
            //TestCustomerAdd();
            //TestCustomerRemove();
            //TestCustomerListIndexers();
            //TestCustomerListCount();
            //TestCustomerListSave();

            Console.WriteLine("Press the enter key");    // writes to screen
            Console.ReadLine();     // waits for user to hit the "enter" key, allows program to stay open long enough to see what happened
        }

        public static void TestCustomerListConstructor()
        {
            CustomerList list = new CustomerList();
            Console.WriteLine("Testing the constructor");
            Console.WriteLine("Count. Expect 0 " + list.Count);
            Console.WriteLine("ToString. Expect nothing " + list);
        }

        public static void TestCustomerAdd()
        {
            CustomerList list = new CustomerList();
            Customer c1 = new Customer("Mickey", "Mouse", "mmouse@disney.com");
            Customer c2 = new Customer("Donald", "Trump", "makeamericagreatagain@rep.com");
            list.Add(c1);
            list.Add(c2);

            Console.WriteLine("Testing Add");
            Console.WriteLine("Count. Expect 2 " + list.Count);
            Console.WriteLine("ToString. Expect mickey and donald " + list);
        }

        public static void TestCustomerRemove()
        {
            CustomerList list = new CustomerList();
            Customer c1 = new Customer("Mickey", "Mouse", "mmouse@disney.com");
            Customer c2 = new Customer("Donald", "Trump", "makeamericagreatagain@rep.com");
            list.Add(c1);
            list.Add(c2);
            list.Remove(c2);

            Console.WriteLine("Testing Remove");
            Console.WriteLine("Count. Expect 1 " + list.Count);
            Console.WriteLine("ToString. Expect mickey " + list);
        }

        static void TestCustomerConstructors()
        {
            Customer c1 = new Customer();     // creating new product, () = default parameter 
            Customer c2 = new Customer("Manda", "Akins", "AAkins83@gmail.com");       // creating another product using overloaded constructor via 3 parameters

            Console.WriteLine("Testing both constructors");     // to get something to show on screen use "WriteLine"
            Console.WriteLine("Default constructor.  Expecting ??? ???, ???. " + c1);        // testing default contructor, expecting default values which are nothing, turns p1 into string and prints on screen (nothing)
            Console.WriteLine("Overloaded constructor.  Expecting Manda Akins, AAkins83@gmail.com. " + c2);      // testing overloaded constructor, 
            Console.WriteLine();        // () = will print a blank line
        }

        static void TestCustomerPropertyGetters()
        {
            Customer c1 = new Customer("Manda", "Akins", "AAkins83@gmail.com");

            Console.WriteLine("Testing getters");       //not changing value
            Console.WriteLine("First Name.  Expecting Manda. " + c1.FirstName);
            Console.WriteLine("Last Name.  Expecting Akins. " + c1.LastName);
            Console.WriteLine("Email Address.  Expecting AAkins83@gmail.com. " + c1.Email);
            Console.WriteLine();
        }

        static void TestCustomerPropertySetters()
        {
            Customer c1 = new Customer("Manda", "Akins", "AAkins83@gmail.com");

            Console.WriteLine("Testing setters");
            c1.FirstName = "Manda";       //changing property
            c1.LastName = "Akins";
            c1.Email = "AAkins83@gmail.com";
            Console.WriteLine("Expecting Manda, Akins, AAkins83@gmail.com. " + c1);
            Console.WriteLine();
        }

        static void TestCustomerListFill()
        {
            CustomerList cList = new CustomerList();
            cList.Fill();

            Console.WriteLine("Testing Fill");
            Console.WriteLine("Expecting list of customers:\n" + cList);
            Console.WriteLine();
        }

        static void TestCustomerListCount()
        {
            CustomerList cList = new CustomerList();
            cList.Fill();
            Console.WriteLine("Expecting 1 " + cList.Count);
        }
    }
}
