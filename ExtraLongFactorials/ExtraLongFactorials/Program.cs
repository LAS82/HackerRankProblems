﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    static System.Numerics.BigInteger factorial(int n)
    {

        if (n == 1)
            return 1;
        else
            return n * factorial(n - 1);

    }

    // Complete the extraLongFactorials function below.
    static void extraLongFactorials(int n)
    {

        Console.WriteLine(factorial(n));

    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        extraLongFactorials(n);
    }
}
