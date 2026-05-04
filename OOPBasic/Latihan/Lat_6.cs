using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic.Latihan
{
    public class Lat_6
    {
        public static void main()
        {
            PercentageDiscount percentageDiscount = new PercentageDiscount("Diskon 20%", 20);
            Console.WriteLine("=== Percentage Discount ===");
            percentageDiscount.describe(100);

            FlatDiscount flatDiscount = new FlatDiscount("Diskon $15");
            Console.WriteLine("\n=== Flat Discount ===");
            flatDiscount.Amount = 15;
            flatDiscount.describe(100);

            BuyOneGetOneFree bogoDiscount = new BuyOneGetOneFree("Buy One Get One Free");
            Console.WriteLine("\n=== Buy One Get One Free ===");
            bogoDiscount.describe(100);

        }
    }

    class Discount
    {
        protected string label;

        public virtual decimal apply(decimal price)
        {
            return 0.0m;
        }

        public virtual void describe(decimal originalPrice)
        {
            Console.WriteLine($"Label : {originalPrice} -> ${this.apply(originalPrice)}");
        }
    }

    class PercentageDiscount : Discount 
    {

        private decimal percentage;
        public decimal Percentage
        {
            get { return percentage; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Percentage harus antara 0 dan 100");
                }
                percentage = value;
            }
        }
        public PercentageDiscount(string label, decimal percentage)
        {
            this.label = label;
            this.percentage = percentage;
        }
        public override decimal apply(decimal price)
        {
            return price * (1 - this.percentage / 100);
        }
        public override void describe(decimal originalPrice) 
        {
           base.describe(originalPrice);
        }
    }

    class FlatDiscount : Discount 
    {

        private decimal amount;
        public decimal Amount
        {
            get { return amount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Amount harus lebih besar dari 0");
                }
                amount = value;
            }
        }

        public FlatDiscount(string label)
        {
            this.label = label;
        }
        public override decimal apply(decimal price)
        {
            return price - this.amount;
        }

        public override void describe(decimal originalPrice)
        {
           base.describe(originalPrice);
        }
    }

    class BuyOneGetOneFree : Discount
    {
        public BuyOneGetOneFree(string label)
        {
            this.label = label;
        }
        public override decimal apply(decimal price)
        {
            return price / 2;
        }
        public override void describe(decimal originalPrice)
        {
            base.describe(originalPrice);
        }
    }
}
