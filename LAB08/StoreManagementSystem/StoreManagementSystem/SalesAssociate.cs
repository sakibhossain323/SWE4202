using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem
{
    internal class SalesAssociate: Employee
    {
        public double Bonus { get; set; }
        public double TotalSalary
        {
            get { return BaseSalary+Bonus; } 
        }

        public SalesAssociate(string name, int age, double baseSalary): base(name, age, baseSalary)
        {
            Console.WriteLine("----Sales Associate has been added!----");
            ShowEmployeeInfo();
        }

        public override void ShowEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name} -- Age: {Age} -- BaseSalary: BDT {BaseSalary} -- Bonus: {Bonus} -- Total Salary: {TotalSalary}");
        }

        public void SellProduct(int id, int amt, Store store)
        {
            var p = store.FindProduct(id);
            
            int temp = p.Curlevel;
            p.Curlevel -= amt;

            if(temp != p.Curlevel)
            {
                double curBonus = (p.Price*amt) * 0.01;
                Bonus += curBonus;

                Console.WriteLine($"{p.Name} has been sold and {Name} has received a bonus of {curBonus}!");
            }
        }
    }
}
