using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    abstract class Cloth
    {
        private readonly Dictionary<Task, double> _cost = new Dictionary<Task, double>();

        public double this[Task key]
        {
            get { return _cost[key]; }
            set { _cost[key] = value; }
        }
        
        public ClothType Type { get; protected set; }

        public Cloth(double ironCost, double  washCost)
        {
            _cost.Add(Task.Iron, ironCost);
            _cost.Add(Task.Wash, washCost);
            _cost.Add(Task.Both, ironCost + washCost);
        }
    }

    class Shirt : Cloth
    {
        public Shirt(double ironCost, double washCost) : base(ironCost, washCost)
        {
            Type = ClothType.Shirt;
        }
    }

    class Pant : Cloth
    {
        public Pant(double ironCost, double washCost) : base(ironCost, washCost)
        {
            Type = ClothType.Pant;
        }
    }

    class Suit : Cloth
    {
        public Suit(double ironCost, double washCost) : base(ironCost, washCost)
        {
            Type = ClothType.Suit;
        }
    }

    class BedSheet : Cloth
    {
        public BedSheet(double ironCost, double washCost) : base(ironCost, washCost)
        {
            Type = ClothType.BedSheet;
        }
    }
}
