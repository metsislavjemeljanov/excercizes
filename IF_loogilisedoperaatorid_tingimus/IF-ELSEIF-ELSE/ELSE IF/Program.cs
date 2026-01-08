namespace ELSE_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kui pikk sa oled? sissta sentimeetrites");
            int pikkus = int.Parse(Console.ReadLine());
            if (pikkus < 0)
            {
                Console.WriteLine("Slline pikkus on võimatu");
            }
            else if (pikkus < 100)
            {
                Console.WriteLine("Olen juntsu, hit the gym");
            }
            else if (pikkus < 200)
            {
                Console.WriteLine("Oled normi pikkusega kolge");
            }
            else if (pikkus > 200)
            {
                Console.WriteLine("Ossaraks, vaat kus hiiglane!");
            }
        }
    }
}
