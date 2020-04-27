using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumbers
{
    class Program
    {
        static List<bool> ToBase2(int number)
        {

            List<bool> bitList = new List<bool>();

            while (number > 0)
            {
                bitList.Add(Convert.ToBoolean(number % 2));
                number = number / 2;
            }

            bitList.Reverse();

            return bitList;

        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            List<bool> bitList = ToBase2(n);
            int onBitsTogether = 0;
            int tempOnBitsTogether = 0;

            for (int i = 0; i < bitList.Count; ++i)
            {
                if (bitList[i])
                    ++tempOnBitsTogether;
                else
                    tempOnBitsTogether = 0;

                if (tempOnBitsTogether >= onBitsTogether)
                    onBitsTogether = tempOnBitsTogether;
            }

            Console.WriteLine(onBitsTogether);
            Console.ReadKey();

        }
    }
}
