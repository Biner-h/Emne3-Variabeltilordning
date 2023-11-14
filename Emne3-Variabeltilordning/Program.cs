namespace Emne3_Variabeltilordning
{
    internal class Program
    {   //Modell
        int tall1 = 5;
        int tall2 = 15;

        string tekst = "Denne konsollen returnerer ingenting";

        public int getANumber(int number1, int number2)
        {
            return number1 + number2;
        }

        //View
        public void run() => Console.WriteLine($"Svaret er: {getANumber(tall1, tall2)}");

        public void nothing() => Console.WriteLine(tekst);

        //Controller
        static void Main(string[] args)
        {
            Program program = new Program();
            program.run();
            program.nothing();
        }
    }
}