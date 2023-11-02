using System.Net.NetworkInformation;

namespace Assignment3
{
    internal class Program
    {
        static void Task1()
        {
            int count = 0;
            List<int> list = new List<int>() { 10, 10, 10, 10, 10, 20, 20, 20, 2, 3, 1 };
            Dictionary<int, int> mp = new Dictionary<int, int>();
            foreach (int x in list)
            {
                if (mp.ContainsKey(x))
                {
                    mp[x]++;
                }
                else
                {
                    mp.Add(x, 1);
                }
            }
            foreach (int x in mp.Keys)
            {
                if (mp[x] > 1)
                {
                    count += mp[x];
                }
            }
            Console.WriteLine("there are " + count + " duplicates in the array");

        }
        static void Task2()
        {
            int maths, phy, chem;
            Console.WriteLine("Maths marks");
            int.TryParse(Console.ReadLine(), out maths);
            Console.WriteLine("Physics marks");
            int.TryParse(Console.ReadLine(), out phy);
            Console.WriteLine("Chemistry marks");
            int.TryParse(Console.ReadLine(), out chem);

            if ((maths >= 65 && phy >= 55 && chem >= 50)||(maths+phy)>=140)
            {
                Console.WriteLine("Candidate is eligible for admission");
            }
            else
            {
                Console.WriteLine("Canditate is not eligible for admission");
            }
        }
        static void Task3()
        {
            string customerId, name;
            int unitsConsumed = 0;
            Console.WriteLine("the Customer ID:");
            customerId=Console.ReadLine();
            Console.WriteLine("customer Name:");
            name=Console.ReadLine();
            Console.WriteLine("Units Consumed:");
            unitsConsumed=int.Parse(Console.ReadLine());
            float charge = 0;
            string chargedAt = "@1.20";
            if (unitsConsumed <= 199)
            {
                charge = 1.2f * unitsConsumed;
            }else if(unitsConsumed <400 && unitsConsumed >= 200)
            {
                charge = 1.5f * unitsConsumed;
                chargedAt = "@1.5";
            }
            else if(unitsConsumed <600 && unitsConsumed >= 400)
            {
                charge = 1.8f * unitsConsumed;
                chargedAt = "@1.8";
            }
            else if (unitsConsumed >=600)
            {
                charge = 2.0f * unitsConsumed;
                chargedAt = "@2.0";
            }
            float surcharge = 0;
            if (charge > 400)
            {
               surcharge = charge+ 0.15f * charge;
            }

            Console.WriteLine("Customer IDNO :"+customerId);
            Console.WriteLine("Customer Name :"+name);
            Console.WriteLine("units consumed :"+unitsConsumed);
            Console.WriteLine($"Amount charges Rs. {chargedAt} per unit: {charge}");
            Console.WriteLine("Surcharge amount :"+surcharge);
            Console.WriteLine($"Net amount paid by the customer : {charge + surcharge}");


        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
    }
}