using System;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(jumpingOnClouds(new int[7] {0, 0, 1, 0, 0, 1, 0}));
        }

        static int jumpingOnClouds(int[] c) 
        {
            int jumpNum = 0;
            int i = 0;
            
            while (i < c.Length - 1)
            {
                if(i + 2 == c.Length || c[i + 2] == 1)
                {
                    i++;
                    jumpNum++;
                }
                else
                {
                    i += 2;
                    jumpNum++;
                }
            }
            return jumpNum;
        }
    }
}
