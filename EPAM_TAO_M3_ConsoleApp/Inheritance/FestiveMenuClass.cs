using System;

namespace EPAM_TAO_M3_ConsoleApp.Inheritance
{
    class FestiveMenuClass : MenuBaseClass
    {
        public FestiveMenuClass() : base(50.0)
        {
            GST = 5.0;
        }

        public enum EDays
        {
            MONDAY,
            TUESDAY
        };

        public override double MenuPrice { get; set; } = 159.0;
        public override void MainCourse()
        {
            Console.WriteLine("Veg. Kofta");
            Console.WriteLine("Paneer Lawabdaar");
            Console.WriteLine("Butter Roti/Naan");
            Console.WriteLine("Dal Makhani/Tadka");
            Console.WriteLine("Jeera Rice");
        }

        public override void MainCourse(string StrDay)
        {
            
            if(StrDay.ToUpper() == EDays.MONDAY.ToString())
            {
                Console.WriteLine("Kaju Curry");
                Console.WriteLine("Paneer Zafrani");
                Console.WriteLine("Butter Kulcha");
                Console.WriteLine("Dal Fry");
                Console.WriteLine("Veg. Biryaani");
            }
            else if(StrDay.ToUpper() == EDays.TUESDAY.ToString())
            {
                Console.WriteLine("Kaju Masala");
                Console.WriteLine("Paneer Corn Tikka Masala");
                Console.WriteLine("Butter Amritsari Kulcha");
                Console.WriteLine("Dal");
                Console.WriteLine("Veg. Biryaani");
            }
            else
            {
                MainCourse();
            }           
        }

        public void CalculateBill()
        {
            Console.WriteLine("The bill to be paid is, INR " + (MenuPrice + ((GST * MenuPrice)/100)));
        }
    }
}
