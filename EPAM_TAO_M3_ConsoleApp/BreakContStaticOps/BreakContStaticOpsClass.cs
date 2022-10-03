using System;

namespace EPAM_TAO_M3_ConsoleApp.BreakContStaticOps
{
    class BreakContStaticOpsClass
    {
        static bool BoolIsPrime;

        public static void BreakStatement(int IntNum)
        {
            BoolIsPrime = true;

            for (int i=2; i<IntNum; i++)
            {
                if(IntNum%i == 0)
                {
                    BoolIsPrime = false;
                    break;
                }
            }

            if(BoolIsPrime)
            {
                Console.WriteLine(IntNum + " is a Prime Number.");
            }
            else
            {
                Console.WriteLine(IntNum + " is not a Prime Number.");
            }
        }

        public static void ContinueStatement()
        {          
            for(int i=0; i<10; i++)
            {
                if(i<5)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }           
        }

    }
}
