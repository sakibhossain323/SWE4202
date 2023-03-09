using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double BaseSalary { get; set; }

        public Employee(string name, int age, double baseSalary)
        {
            Name = name;
            Age = age;
            BaseSalary = baseSalary;
        }

        public abstract void ShowEmployeeInfo();
        public abstract void SellProduct(int id, int amt, Store store);

        public void AddProduct(int id, string name, double price, int curLev, int minLev, int reqAmt, Store store)
        {
            var product = new Product(id, name, price, curLev, minLev, reqAmt);
            store.AddProduct(product);
        }

        
    }
}
