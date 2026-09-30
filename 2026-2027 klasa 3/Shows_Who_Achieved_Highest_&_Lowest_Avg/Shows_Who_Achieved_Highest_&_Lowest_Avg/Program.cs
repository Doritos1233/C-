namespace Shows_Who_Achieved_Highest___Lowest_Avg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRORAM KTORY PODAJE KTO DOSTAL NAJLEPSZA ORAZ NAJGORSZA SREDNIA");
            Console.Write("Ilość uczniów: ");
            int liczba_ucz = int.Parse(Console.ReadLine());

            double[][] oceny = new double[liczba_ucz][];

            for (int i = 1; i <= liczba_ucz; i++)
            {
                Console.Write($"uczeń {i}, Ilość ocen: ");
                int liczba_ocen = int.Parse(Console.ReadLine());
                oceny[i - 1] = new double[liczba_ocen];

                for (int j = 0; j < liczba_ocen; j++)
                {
                    Console.Write($"ocena dla ucznia {i}: ");
                    double oceny_ucz = double.Parse(Console.ReadLine());
                    oceny[i - 1][j] = oceny_ucz;
                }
            }

            double min = 99999999, max = 0;
            for (int i = 0; i < liczba_ucz; i++)
            {
                Console.WriteLine();
                int liczba_ocen_ucz = oceny[i].Length;
                double srednia = 0;
                for (int j = 0; j < liczba_ocen_ucz; j++)
                {
                    srednia += oceny[i][j];
                }
                srednia /= liczba_ocen_ucz;
                Console.WriteLine($"Srednia ucznia {i + 1}: {srednia}");

                if (srednia > max) max = srednia;
                if (srednia < min) min = srednia;
            }

            Console.WriteLine();
            Console.WriteLine($"max srednia: {max}");
            Console.WriteLine($"min srednia: {min}");
        }
    }
}
