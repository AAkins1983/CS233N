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

            //TestProductAll();

            Console.WriteLine();
            Console.ReadLine();
        }

        static void TestProductConstructors()
        {
            Product p1 = new Product();
            Product p2 = new Product("T100", "This is a test product", 100M);

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting default values. " + p1.GetDisplayText(", "));
            Console.WriteLine("Overloaded constructor.  Expecting T100, 100, This is a test product. " + p2.GetDisplayText("\t"));
            Console.WriteLine();
        }

        static void TestProductPropertyGetters()
        {
            Product p1 = new Product("T100", "This is a test product", 100M);

            Console.WriteLine("Testing getters");
            Console.WriteLine("Code.  Expecting T100. " + p1.Code);
            Console.WriteLine("Description.  Expecting This is a test product. " + p1.Description);
            Console.WriteLine("Price.  Expecting 100. " + p1.Price);
            Console.WriteLine();
        }

        static void TestProductPropertySetters()
        {
            Product p1 = new Product("T100", "This is a test product", 100M);

            Console.WriteLine("Testing setters");
            p1.Code = "T000";
            p1.Description = "First product";
            p1.Price = 200;
            Console.WriteLine("Expecting T000, 200, First product. " + p1.GetDisplayText(", "));
            Console.WriteLine();
        }

        static void TestProductToString()
        {
            Product p1 = new Product("T100", "This is a test product", 100M);

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting T100, 100, This is a test product. " + p1.ToString());
            Console.WriteLine("Expecting T100, 100, This is a test product. " + p1);
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
