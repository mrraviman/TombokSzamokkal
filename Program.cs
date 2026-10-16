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
            static void Main(string[] args)
        {
            Feltolt();
            Osszegzes();
            Megszamol();
        }
    }
}
