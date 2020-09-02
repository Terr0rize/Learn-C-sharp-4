using System;

namespace C_sharp_learning
{
    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {
            Console.WriteLine("__________________________" + "  for");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + "\n");
            }
            Console.WriteLine("__________________________" + "  continue");
            for (int i = 10; i >=5; i--)
            {
                if (i == 8)
                    continue; //пропустил итерацию
                    //break выйдет из цикла for
                Console.WriteLine(i + "\n");
            }

            Console.WriteLine("__________________________" + "  While");
            int key = 0;

            while(key <5)
            {
                Console.WriteLine(key);
                key++;
            }
            Console.WriteLine("__________________________" + "  Do While");
            int Liora;
            do
            {
                Console.WriteLine("Enter Number");
                Liora = Convert.ToInt32(Console.ReadLine());
            } while (Liora != 5);
            {
                Console.WriteLine("Good. You write 5.");
            }
            

            Console.ReadKey();
        }
    }
}
