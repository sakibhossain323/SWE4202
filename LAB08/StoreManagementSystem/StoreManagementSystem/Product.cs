using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StoreManagementSystem
{
    internal class Product
    {
        public  string Name { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public int MinLevel { get; set; }
        public int ReqAmount { get; set; }

        private int curLevel;
        public int Curlevel
        {
            get { return curLevel; }
            set
            {
                if (curLevel >= 0) this.curLevel = value;
                else Console.WriteLine($"Not enough amount of {this.Name}. Contact your Manager");
            }
        }

        public Product(int id, string name, double price, int curlev, int minlev, int reqAmt)
        {
            this.Id = id;
            this.Name= name;
            this.Price= price;
            this.Curlevel= curlev;
            this.MinLevel= minlev;
            this.ReqAmount= reqAmt;
            
        }

        public void Productinfo()
        {
            Console.WriteLine($"ID :{this.Id} -- Product Name: {this.Name} -- Price: {this.Price} -- Qty: {this.Curlevel} -- Min.Qty {this.MinLevel} -- Req.Amt: {this.ReqAmount}");
        }

    }
}
