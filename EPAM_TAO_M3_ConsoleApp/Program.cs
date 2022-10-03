using EPAM_TAO_M3_ConsoleApp.BreakContStaticOps;
using EPAM_TAO_M3_ConsoleApp.ExceptionHandling;
using EPAM_TAO_M3_ConsoleApp.Inheritance;
using EPAM_TAO_M3_ConsoleApp.StringOps;

namespace EPAM_TAO_M3_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //String/String Builder OPs
            StringOPsClass stringOPsClass = new StringOPsClass();
            stringOPsClass.ConcatStrings("Pratik", "Pandya");
            stringOPsClass.ExtractString("Pratik", 1);
            stringOPsClass.ExtractString("Pratik", 2, 2);
            stringOPsClass.CompareStrings("Dog", "Cat");
            stringOPsClass.StringBuilderOps();

            //Break-Continue-Static Keywords
            BreakContStaticOpsClass.BreakStatement(5);
            BreakContStaticOpsClass.ContinueStatement();

            //Exception Handling
            ExceptionHandlingClass exceptionHandlingClass = new ExceptionHandlingClass();
            exceptionHandlingClass.Division(5, 0);

            //Inheritance Chaining with Interface, Abstraction, Access Modifiers and Enum
            FestiveMenuClass festiveMenuClass = new FestiveMenuClass();
            festiveMenuClass.Starter();
            festiveMenuClass.MainCourse("MONDAY");
            festiveMenuClass.Desserts();
            festiveMenuClass.CalculateBill();

            //Custom Exception Handling
            stringOPsClass.CompareStrings("Dog1", "C@t");
        }
    }
}
