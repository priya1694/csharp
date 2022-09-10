﻿using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[4][];
              
            jaggedArray[0] = new int[2] { 7, 9 };
            jaggedArray[1] = new int[4] { 12, 42, 26, 38 };
            jaggedArray[2] = new int[6] { 3, 5, 7, 9, 11, 13 };
            jaggedArray[3] = new int[3] { 4, 6, 8 };
             
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Element({0}): ", i + 1);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
               
            }
           
        }
    }
    }

