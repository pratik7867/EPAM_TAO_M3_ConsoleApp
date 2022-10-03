using System;

namespace EPAM_TAO_M3_ConsoleApp.Inheritance
{
    abstract class MenuBaseClass : IMenu
    {
        private double Tip { get;  set; }
        protected double GST { get; set; }
        public virtual double MenuPrice { get; set; } = 119.0;

        public MenuBaseClass(double TipAmt)
        {
            Tip = TipAmt;
        }

        public virtual void Desserts()
        {
            Console.WriteLine("Ice Cream with Brownie");
        }

        public virtual void Starter()
        {
            Console.WriteLine("Dry Manchurian");
        }
        public abstract void MainCourse();
        public abstract void MainCourse(string StrDay);
    }
}
