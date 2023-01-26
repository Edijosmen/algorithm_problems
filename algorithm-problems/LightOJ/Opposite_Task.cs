using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_problems.LightOJ
{
    public class Opposite_Task
    {
        public void Run_Opposite_Task()
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n > 10) Console.WriteLine($"10 {n - 10}");
                else
                    Console.WriteLine($"0 {n}");
            }
        }
    }
}
