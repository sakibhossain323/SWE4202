using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    enum ClothType
    {
        Shirt,
        Pant,
        Suit,
        BedSheet
    }
    enum Task
    {
        Iron,
        Wash,
        Both
    }
    enum OrderStatus
    {
        Pending,
        Processing,
        Delivered
    }
    static class Utility
    {
        public static Dictionary<ClothType, Cloth> Cost { get; } = new Dictionary<ClothType, Cloth>()
        {
            { ClothType.Shirt, new Shirt(5.0, 10.0) },
            { ClothType.Pant, new Pant(5.0, 10.0) },
            { ClothType.Suit, new Suit(20.0, 30.0) },
            { ClothType.BedSheet, new BedSheet(10.0, 20.0) }
        };
    }
}
