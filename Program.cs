// class Program
// {
//     static void MyMethod(string name)
//     {
//         Console.WriteLine(name + "Matrasulov");
//     }
// static void Main(string[] args)
//     {
//         MyMethod("Jaxongir ");
//         MyMethod("Abror ");
//         MyMethod("Xushnud ");
//     }
// }



class Program
{
    static int MyMethod(int x, int y, int a, int d)
    {
        return x + y * a + d;
    }
    static void Main(string[] args)
    {
        int k = MyMethod(2, 5, 4, 3);
        Console.WriteLine(k);
    }
}
