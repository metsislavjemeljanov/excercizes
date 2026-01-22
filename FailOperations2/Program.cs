using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace FailOperations2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayThisFile();
            FindWord("die");

        }

        private static void FindWord(string filter)
        {
            using (StreamReader thisFile = new StreamReader("C:\\Users\\opilane\\source\\repos\\Metšislav jemeljanov\\excercizes\\FailOperations2\\laulusõnad.txt"))
            {
                int lnr = 0;
                while (thisFile.EndOfStream == false)
                {
                    string thisLine = thisFile.ReadLine();
                    lnr++;
                    if (thisLine.Contains(filter))
                    {
                        Console.WriteLine("Sõna leitud realt #"+lnr+"");
                    }
                }
                thisFile.Close();
            }
        }

        private static void DisplayThisFile()
        {
            string rida = "";
            using (StreamReader thisFile = new StreamReader("C:\\Users\\opilane\\source\\repos\\Metšislav jemeljanov\\excercizes\\FailOperations2\\laulusõnad.txt"))
            {
                int currentRow = 0;
                while(thisFile.EndOfStream == false)
                {
                    currentRow++;
                    rida = thisFile.ReadLine();
                    int pikkus = rida.Length;
                    Console.WriteLine($"#{currentRow} pikkus: {pikkus} tekst: {rida}");
                }
                thisFile.Close();
            }
        }
    }
}
