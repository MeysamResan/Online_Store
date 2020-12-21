using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public class Goods
    {
        public string ProductName;
        public int ProductID;
        public int ProductPrice;
        public int N;

        public static List<Goods> AllProductsList = new List<Goods>();
        public static List<Goods> Search = new List<Goods>();

        public Goods(int N, string ProductName, int ProductID, int ProductPrice)
        {
            this.ProductName = ProductName;
            this.ProductID = ProductID;
            this.ProductPrice = ProductPrice;
            this.N = N;
        }
    }
}
