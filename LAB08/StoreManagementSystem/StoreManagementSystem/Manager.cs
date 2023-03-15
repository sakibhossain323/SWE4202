using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem
{
    internal class Manager: Employee
    {
        public Manager(string name, int age, double baseSalary): base(name, age, baseSalary)
        {
            Console.WriteLine("----Manager has been added!----");
            this.ShowEmployeeInfo();
        }

        public override void ShowEmployeeInfo()
        {
            Console.WriteLine($"Name: {this.Name} -- Age: {this.Age} -- BaseSalary: BDT {this.BaseSalary}");
        }

        public void AddProduct(int id, string name, double price, int curLev, int minLev, int reqAmt, Store store)
        {
            var product = new Product(id, name, price, curLev, minLev, reqAmt);
            store.AddProduct(product);
        }

        public void AddExistingProduct(int id, int amt, Store store)
        {
            var p = store.FindProduct(id);
            store.AddExistingProduct(p, amt);
        }

        public void SendRequisition(Store store)
        {
            foreach(Product p in store.Inventory)
            {
                if(p.Curlevel < p.MinLevel) store.AddExistingProduct(p, p.ReqAmount);
            }
        }
    }
}
