using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductMaintenanceClasses;


namespace ProductTests
{
    class Program
    {
        static void Main(string[] args)
        {

            TestProductConstructors();
            TestProductPropertyGetters();
            TestProductPropertySetters();
            TestProductToString();

            TestProductAll();

            Console.WriteLine();    // writes to screen
            Console.ReadLine();     // waits for user to hit the "enter" key, allows program to stay open long enough to see what happened
        }

        static void TestProductConstructors()
        {
            Product p1 = new Product();     // creating new product, () = default parameter 
            Product p2 = new Product("T100", "This is a test product", 100M);       // creating another product using overloaded constructor via 3 parameters

            Console.WriteLine("Testing both constructors");     // to get something to show on screen use "WriteLine"
            Console.WriteLine("Default constructor.  Expecting default values. " + p1.GetDisplayText(", "));        // testing default contructor, expecting default values which are nothing, turns p1 into string and prints on screen (nothing)
            Console.WriteLine("Overloaded constructor.  Expecting T100, 100, This is a test product. " + p2.GetDisplayText("\t"));      // testing overloaded constructor, 
            Console.WriteLine();        // () = will print a blank line
        }

        static void TestProductPropertyGetters()
        {
            Product p1 = new Product("T100", "This is a test product", 100M);

            Console.WriteLine("Testing getters");       //not changing value
            Console.WriteLine("Code.  Expecting T100. " + p1.Code);
            Console.WriteLine("Description.  Expecting This is a test product. " + p1.Description);
            Console.WriteLine("Price.  Expecting 100. " + p1.Price);
            Console.WriteLine();
        }

        static void TestProductPropertySetters()
        {
            Product p1 = new Product("T100", "This is a test product", 100M);

            Console.WriteLine("Testing setters");
            p1.Code = "T000";       //changing property
            p1.Description = "First product";
            p1.Price = 200;
            Console.WriteLine("Expecting T000, 200, First product. " + p1.GetDisplayText(", "));
            Console.WriteLine();
        }

        static void TestProductToString()
        {
            Product p1 = new Product("T100", "This is a test product", 100M);

            Console.WriteLine("Testing ToString");      
            Console.WriteLine("Expecting T100, 100, This is a test product. " + p1.ToString());     //expecting it to tostring itself, explicity call tostring on p1
            Console.WriteLine("Expecting T100, 100, This is a test product. " + p1);        //takes p1 object and concatenate to a string using the tostring method
            Console.WriteLine();
        }

        static void TestProductAll()
        {
            TestProductConstructors();
            TestProductPropertyGetters();
            TestProductPropertySetters();
            TestProductToString();
            Console.WriteLine();
        }
    }
}
