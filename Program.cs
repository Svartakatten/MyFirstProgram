namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables

            int MyNumber = 15;

            //If integer is higher than 10 then write "Talet är för stort" else "Oj, lågt tal!"

            if (MyNumber > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj, Lågt tal!");
            }

            //Write to user about their name and save it as a variable, send it back with the text "hej" 

            Console.WriteLine("Vad heter du?");

            string Name = Console.ReadLine();

            Console.WriteLine($"Hej {Name}!");

            //Creates a integer that is 0 until it loops up to 15, that is also "MyNumber"'s value

            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}