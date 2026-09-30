namespace 13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM UCZNIOWIE WIELE OCEN JEDEN SLOWNIK I SREDNIA");
            var uczniowie = new Dictionary<string, List<double>>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("imie ucznia: ");
                string imie = Console.
                
                
                
                
                
                
                
                ReadLine();

                Console.Write("ile ocen ma uczeń: ");
                int liczba_ocen = int.Parse(Console.ReadLine());
                uczniowie[imie] = new List<double>();

                for (int y = 0; y < liczba_ocen; y++)
                {
                    Console.WriteLine($"wpisz ocene dla ucznia {imie}");
                    int ocena = int.Parse(Console.ReadLine());
                    uczniowie[imie].Add(ocena);
                }
            }

            foreach (var oceny in uczniowie)
            {
                Console.WriteLine($"uczeń: {oceny.Key} \n oceny: {oceny.Value} \n średnia: ");
            }
        }
    }
}
