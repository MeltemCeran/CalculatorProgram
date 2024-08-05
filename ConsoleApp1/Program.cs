namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] birArray = { 23, 18, 56, 45, 300 };
            Array.Sort(birArray);

            foreach (int bir in birArray) 
            {
                Console.WriteLine(bir);

            }

        }
    }
}
