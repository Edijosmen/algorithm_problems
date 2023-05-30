using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_problems.HackerRang
{
    public  class DiagonalDifference
    {
        public static void Solutions()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DiagonalDifferencevalor(arr);
            Console.WriteLine(result);
        }

        private static int DiagonalDifferencevalor(List<List<int>> arr)
        {
            List<int> l1 = new List<int>();
            List<int> l2 = new List<int>();
            int arry = arr.Count;
            int dato1 = 0;
            int dato2 = 0;
           for(int i=0;i< arr.Count; i++)
            {
                List<int> fl = arr[i];
                l1.Add(fl[i]);
                dato1 += fl[i];
                l2.Add(fl[arry-1]);
                dato2 += fl[arry-1];
                arry += -1;
            }
            var mayor = Math.Max(dato1, dato2);
            var menor = Math.Min(dato1, dato2);
            return mayor - menor;
        }
    } 
}
