﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class BubbleSorter : ISortProcessor
    {
        public OrderBy Order { get; set; }
        public int[] Array { get; }

        public BubbleSorter(int[]array, OrderBy order)
        {
            Order = order;
            Array = Sort(array, Order);
        }

        public int[] Sort(int[] arr, OrderBy order)
        {
            {
                int n = arr.Length;
                for (int i = 0; i < n - 1; i++)
                    for (int j = 0; j < n - i - 1; j++)
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                            arr.PrintIntArray();
                        }
                return (Order == OrderBy.Asc) ? arr : arr.Reverse().ToArray();
            }
        }
    }
}
