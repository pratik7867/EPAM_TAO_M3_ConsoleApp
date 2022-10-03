namespace EPAM_TAO_M3_ConsoleApp.Inheritance
{
    interface IMenu
    {
        double MenuPrice { get; }

        void Starter();
        void MainCourse();
        void MainCourse(string StrDay);
        void Desserts();

    }
}
