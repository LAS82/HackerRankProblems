﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleAndOrange
{
    class Program
    {
        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int startingPointHouse, int endPointHouse, int appleTreePosition, int orangeTreePosition, int[] apples, int[] oranges)
        {
            int applesInMyHouse = returnNumberOfFruitsInside(startingPointHouse, endPointHouse, appleTreePosition, apples);
            int orangesInMyHouse = returnNumberOfFruitsInside(startingPointHouse, endPointHouse, orangeTreePosition, oranges);

            Console.WriteLine(applesInMyHouse);
            Console.WriteLine(orangesInMyHouse);
        }

        static int returnNumberOfFruitsInside(int startingPointHouse, int endPointHouse, int treePosition, int[] fruitsPosition)
        {
            int position;
            int insideFruits = 0;

            foreach (int fruitPosition in fruitsPosition)
            {
                position = fruitPosition + treePosition;

                if (position >= startingPointHouse && position <= endPointHouse)
                    insideFruits++;
            }

            return insideFruits;
        }

        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));
            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
