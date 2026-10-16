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
        static void Main(string[] args)
        {
            Feltolt();
        }
    }
}
