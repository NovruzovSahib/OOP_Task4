using OOP_Task4;

internal class Program
{
    private static void Main(string[] args)
    {
        Asus asus = new Asus(11,"laptop",2019,true,1700,"Asus Tuf Gaming");
        asus.GetComputer();

        HP hp = new HP(12, "Personal", 2020, false, 1650, "HP Pavilion");
        hp.GetComputer();

        Lenovo lenovo = new Lenovo(13, "Laptop", 2021, true, 2100, "Legion");
        lenovo.GetComputer();


        Console.ReadLine();
    }

}