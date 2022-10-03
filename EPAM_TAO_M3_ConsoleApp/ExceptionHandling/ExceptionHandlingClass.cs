using System;

namespace EPAM_TAO_M3_ConsoleApp.ExceptionHandling
{
    class ExceptionHandlingClass
    {
        int Result;
        public int Division(int Num1, int Num2)
        {
            try
            {
                Result = Num1 / Num2;
            }
            catch(Exception ex)
            {
                if(ex is ArithmeticException)
                {
                    Console.WriteLine("Illegal attempt to divide by zero.");
                }
                else
                {
                    throw ex;
                }
            }

            return Result;
        }
    }
}
