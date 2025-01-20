namespace Set2Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numarul de elemente din secventa: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti elementele: ");
            int primulElem = int.Parse(Console.ReadLine());
            int elementAnt = primulElem;
            int elemCurent;
            int rupturi = 0;

            for(int i = 1; i < n; i++)
            {
                elemCurent = int.Parse(Console.ReadLine());
                if(elemCurent < elementAnt)
                {
                    rupturi++;
                }
                elementAnt = elemCurent;
            }
            if (primulElem < elementAnt)
            {
                rupturi++;
            }

            if (rupturi <= 1)
            {
                Console.WriteLine("Secventa este crescătoare rotită.");
            }
            else
            {
                Console.WriteLine("Secventa NU este crescătoare rotită.");
            }
        }
    }
}
