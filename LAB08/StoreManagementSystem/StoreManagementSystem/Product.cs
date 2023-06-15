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
                if (value >= 0) curLevel = value;
                else Console.WriteLine($"Not enough amount of {Name}. Contact your Manager!");
            }
        }

        public Product(int id, string name, double price, int curlev, int minlev, int reqAmt)
        {
            Id = id;
            Name= name;
            Price= price;
            Curlevel= curlev;
            MinLevel= minlev;
            ReqAmount= reqAmt;
            
        }

        public void ShowProductInfo()
        {
            Console.WriteLine($"ID : {Id} -- Product Name: {Name} -- Price: BDT {Price} -- Qty: {Curlevel} -- Min.Qty {MinLevel} -- Req.Amt: {ReqAmount}");
        }

    }
}
