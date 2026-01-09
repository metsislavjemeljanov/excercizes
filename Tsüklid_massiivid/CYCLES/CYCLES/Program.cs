namespace CYCLES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for 2. Root
            int ruuduKülg = 0;
            Console.WriteLine("Kui suurt ruutu sa tahad");
            ruuduKülg = int.Parse(Console.ReadLine());
            for (int i = 0; i < ruuduKülg; i++)
            {
                string seeRida = "";
                for(int j = 0; j < ruuduKülg; j++)
                {
                    seeRida += "HH";
                }
                Console.WriteLine(seeRida);
            }
            Console.WriteLine("Tsüklid on lõpetanud");
        }
    }
}
