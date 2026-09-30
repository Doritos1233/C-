namespace 12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ksiazka_tel = new Dictionary<string, string>();

            Console.WriteLine("PROGRAM DO OBSŁUGI KSIĄŻKI TELEFONICZNEJ");
            Console.WriteLine("Podaj liczbe kontaktow ktore chcesz dodać");
            int liczba = int.Parse(Console.ReadLine());

            for (int i = 0; i < liczba; i++)
            {
                Console.Write("Prosze wpisac imię: ");
                string imie = Console.ReadLine();

                Console.Write("Prosze wpisać numer telefoniczny: ");
                string tel = Console.ReadLine();

                ksiazka_tel.Add(imie, tel);
            }

            while (true)
            {
                var kontakt1 = ksiazka_tel;

                Console.WriteLine("czyj numer chcesz wyszukać? \n //wpisz imię");

                string szukane_imie = Console.ReadLine();
                if (ksiazka_tel.ContainsKey(szukane_imie))
                {
                    string znaleziony_numer = ksiazka_tel[szukane_imie];
                    Console.WriteLine($"\n {szukane_imie}, {znaleziony_numer}");
                }
                else
                {
                    Console.WriteLine("\n nie ma takiego kontaktu");
                }

                Console.WriteLine("\n koniec aplikacji wpisz EXIT \n");
                string text = Console.ReadLine();
                if (text == "exit")
                {
                    break;
                }
            }
        }
    }
}
