namespace TombokSzamokkal
{
    internal class Program
    {
        static int[] tomb = new int[15];
        static void Feltolt()
        {
            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(-20, 21);
            }
            foreach(var item in tomb)
            {
                Console.Write(item + " ");
            }
        }
        static void Osszegzes()
        {
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine("\nA tömb elemeinek összege: " + osszeg);
        }
        static void Megszamol()
        {
            int pozitiv = 0;
            int negativ = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > 0)
                {
                    pozitiv++;
                }
                else if (tomb[i] < 0)
                {
                    negativ++;
                }
            }
            Console.WriteLine("Pozitív számok száma: " + pozitiv);
            Console.WriteLine("Negatív számok száma: " + negativ);
        }
        static void Eldontes()
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != 0)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van 0 a tömbben.");
            }
            else
            {
                Console.WriteLine("Nincs 0 a tömbben.");
            }
        }
        static void KeresesTetel()
        {
            int keresett = 0;
            int i = 0;
            while (i < tomb.Length && tomb[i] != keresett)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine($"A keresett szám az {i+1}. indexen található");

            }
            else
            {
                Console.WriteLine("A keresett szám nincs a tömbben.");
            }
        }
        static void Kivalasztas()
        {
            tomb[8] = 10;
            int i = 0;
            while (tomb[i] != 10)
            {
                i++;
            }
            Console.WriteLine($"A keresett szám az {i + 1}. helyen található");
        }
            static void Main(string[] args)
        {
            Feltolt();
            Osszegzes();
            Megszamol();
            Eldontes();
            KeresesTetel();
            Kivalasztas();
        }
    }
}
