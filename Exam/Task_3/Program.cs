﻿using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IntArray intArray = new IntArray(10);
            CharArray charArray = new CharArray(15);

            charArray = intArray as CharArray;
        }
    }
}
