namespace Set2Ex13
{
    internal class Program
    {
        public static bool EsteCrescatioareRotita(int[] secventa)
        {
            int rupturiOrdineCresc = 0;

            for (int i = 0; i < secventa.Length; i++)
            {
                if(secventa[i] >  secventa[(i + 1) % secventa.Length])
                {
                    rupturiOrdineCresc++;
                }
            }
            return rupturiOrdineCresc <= 1;
        }
        static void Main(string[] args)

        {
            Console.WriteLine("Introduceti secventa de numere separate prin spatii: ");
            string input = Console.ReadLine();
            int[] secventa = Array.ConvertAll(input.Split(' '), int.Parse);
            bool rezultat = EsteCrescatioareRotita(secventa);
            Console.WriteLine($"Secventa este crescatoare rotita: {rezultat}");
        }
    }
}
