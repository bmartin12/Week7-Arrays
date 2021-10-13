using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal valida, mida ta hommikusöögiks sööb

            string[] food = { "võileib justuga", "jogurt", "banaan", "peekon", "muna" };

            food[3] = "viinerid";
            food[1] = "keefir";
            Console.WriteLine("Mida sa tahad hommikusöögiks tahad süüa, menüüs on:");

            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }
            Console.WriteLine("Vali toit (siesta number 1 - 5:");
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine($"oled valinud {food[choice]}");
        }
    }
}
