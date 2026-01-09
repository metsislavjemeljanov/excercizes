namespace IF_ELSE_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if-elseif-else 2.
            Console.WriteLine("Kui vana sa oled?");
            int kasutajaVanus = 0;
            kasutajaVanus = int.Parse(Console.ReadLine());
            Console.WriteLine("Mis aasta hetkel kalendaris on?");
            int praeguneAasta = 0;
            praeguneAasta = int.Parse(Console.ReadLine());

            int generatsioon = praeguneAasta - kasutajaVanus;

            if (generatsioon <= 2025 && generatsioon > 2020)
            {
                Console.WriteLine("Kes sulle arvuti andis?");
            }
            else if (generatsioon <= 2020 && generatsioon > 2015)
            {
                Console.WriteLine("Skibidi sigmaless");
            }
            else if (generatsioon <= 2015 && generatsioon > 2010)
            {
                Console.WriteLine("Kas ta tahab saada programmeerijaks?");
                string vastus = "";
                vastus = Console.ReadLine();

                if (vastus == "jah")
                {
                    Console.WriteLine("Tubli");
                }
                else
                {
                    Console.WriteLine("Kahju");
                }
            }
            else if (generatsioon <= 2010)
            {
                Console.WriteLine("Mitu page comicsit ta täna oma reddioti lugemise ajal leidis");
            }
            
        }

    }
}
