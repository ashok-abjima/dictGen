using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Collection_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Dictionary<string, String> dic = new Dictionary<string, String>();

            //    dic.Add("India", "New Delhi");
            //    dic.Add("Russia", "MosCow");
            //    dic.Add("Serbia", "Belgrade");
            //    dic.Add("Ireland", "Dublin");
            //    dic.Add("Thailand", "Bangkok");
            //    dic.Add("Egypt", "Cairo");
            //    dic.Add("Canada", "Ottawa");


            //    Console.WriteLine("Enter Country Name");
            //    String Key = Console.ReadLine();
            //    String Val = dic[Key];


            //    Console.WriteLine(Key + " " + Val);
            //    Console.ReadKey();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            dict.Add("Ram", 1000);
            dict.Add("Shyam", 2000);
            dict.Add("Krishna", 3000);
            string[] t = dict.Keys.ToArray();
            foreach (string item in t)
            {
                Console.WriteLine("{0}{1}", item, dict[item]);
            }

            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic.Add(1000, "Ram");
            dic.Add(2000, "Shyam");
            dic.Add(3000, "Krishna");

            string firstValue = dic[1000];
            Console.WriteLine(firstValue);
            if (dic.TryGetValue(1000, out string fourValue))
            {
                Console.WriteLine(fourValue);
            }
            if (dic.ContainsKey(5000))
            {
                Console.WriteLine("Ask");
            }

            //dic.Clear();
            //dic.Remove(1000);
            //dic.Count;

            int[] k = dic.Keys.ToArray();

            foreach (int item in k)
            {
                Console.WriteLine("{0}{1}", item, dic[item]);

            }
            Console.ReadKey();

        }
    }
}
