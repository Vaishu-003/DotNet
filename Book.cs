using System;

namespace thite
{
    class Shop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of receipts:");
            int n = Convert.ToInt32(Console.ReadLine());

            Receipt[] receipts = new Receipt[n];
            for (int i = 0; i < n; i++)
            {
                receipts[i] = new Receipt();
                Console.WriteLine("Enter the details of receipt " + (i + 1) + ":");
                receipts[i].GetData();
            }

            Console.WriteLine("no\titems\tquantity\tRs\tTotal");
            for (int i = 0; i < n; i++)
            {
                receipts[i].Display();
            }
        }
    }

    class Receipt
    {
        int no, quantity, rs, total;
        string items;

        public void GetData()
        {
            Console.WriteLine("Enter the Serial Number:");
            no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the item name:");
            items = Console.ReadLine();

            Console.WriteLine("Enter the Quantity:");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Rupees for each item:");
            rs = Convert.ToInt32(Console.ReadLine());

            total = rs * quantity;
        }

        public void Display()
        {
            Console.WriteLine(no + "\t" + items + "\t" + quantity + "\t" + rs + "\t" + total);
        }
    }
}
