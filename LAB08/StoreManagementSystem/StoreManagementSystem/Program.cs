using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store MyStore= new Store();
            Manager MichaelScott = new Manager("MichaelScott", 42, 40000);
            SalesAssociate JimHalpert = new SalesAssociate("Jim Halpert", 28, 30000);
            SalesAssociate PamBeesly = new SalesAssociate("Pam Beesley", 25, 30000);

            Console.WriteLine();
            Console.WriteLine();

            MichaelScott.AddProduct(1, "Logitech G304", 3400, 10, 2, 5, MyStore);
            MichaelScott.AddProduct(2, "AMD Ryzen 3600", 17000, 20, 5, 7, MyStore);
            MichaelScott.AddProduct(3, "Nvidia Geforce RTX 3090", 151000, 10, 3, 4, MyStore);

            Console.WriteLine();
            Console.WriteLine();

            JimHalpert.SellProduct(1, 4, MyStore);
            PamBeesly.SellProduct(2, 17, MyStore);
            JimHalpert.SellProduct(1, 10, MyStore);

            Console.WriteLine();
            Console.WriteLine();

            MichaelScott.AddExistingProduct(1, 10, MyStore);

            Console.WriteLine();
            Console.WriteLine();

            MyStore.ShowStoreDetails();

            Console.WriteLine();
            Console.WriteLine();

            JimHalpert.SellProduct(1, 15, MyStore);
            JimHalpert.SellProduct(2, 2, MyStore);
            JimHalpert.SellProduct(3, 9, MyStore);

            Console.WriteLine();
            Console.WriteLine();

            MichaelScott.SendRequisition(MyStore);


            Console.WriteLine();
            Console.WriteLine();

            MichaelScott.ShowEmployeeInfo();
            JimHalpert.ShowEmployeeInfo();
            PamBeesly.ShowEmployeeInfo();

            Console.WriteLine();
            Console.WriteLine();

            MyStore.ShowStoreDetails();
        }
    }
}
