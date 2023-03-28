using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_tabele
{
    internal class Program
    {
        private static void suma(double[] tab)
        {
            double wynik = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                wynik += tab[i];
            }
            Console.WriteLine(wynik);
        }
        private static void iloczyn(double[] tab)
        {
            double wynik = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                wynik *= tab[i];
            }
            Console.WriteLine(wynik);
        }
        private static void sr(double[] tab)
        {
            double wynik = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                wynik += tab[i];
            }
            wynik = wynik / tab.Length;
            Console.WriteLine(wynik);
        }
        private static void min(double[] tab)
        {
            double wynik = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if(wynik > tab[i])
                {
                    wynik = tab[i];
                }
                
            }
            Console.WriteLine(wynik);
        }
        private static void max(double[] tab)
        {
            double wynik = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (wynik < tab[i])
                {
                    wynik = tab[i];
                }

            }
            Console.WriteLine(wynik);
        }
        private static void Menu(double[] tab, ref bool petla)
        {
            Console.WriteLine("1. Wyświetl tablicę");
            Console.WriteLine();
            Console.WriteLine("2. Wyświetl obróconą tablicę");
            Console.WriteLine();
            Console.WriteLine("3. Wyświetl nieparzyste indeksy");
            Console.WriteLine();
            Console.WriteLine("4. Wyświetl parzyste indeksy");
            Console.WriteLine();
            Console.WriteLine("5. Oblicz sumę elementów tablicy");
            Console.WriteLine();
            Console.WriteLine("6. Oblicz iloczyn elementów tablicy");
            Console.WriteLine();
            Console.WriteLine("7. Wyznacz wartość średnią");
            Console.WriteLine();
            Console.WriteLine("8. Wyznacz wartość minimalną");
            Console.WriteLine();
            Console.WriteLine("9. Wyznacz wartość maksymalną");
            Console.WriteLine();
            Console.WriteLine("10. Koniec programu");
            Console.WriteLine();
            Console.Write("Wybór: ");
            string wybór = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            switch (wybór)
            {
                case "Wyświetl tablicę":
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(tab[i]);
                    }
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "1":
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(tab[i]);
                    }
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "Wyświetl obróconą tablicę":
                    for (int i = 9; i > 0; i--)
                    {
                        Console.WriteLine(tab[i]);
                    }
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "2":
                    for (int i = 9; i > 0; i--)
                    {
                        Console.WriteLine(tab[i]);
                    }
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "Wyświetl nieparzyste indeksy":
                    for (int i = 0; i < 10; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(tab[i]);
                        }
                    }
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "3":
                    for (int i = 0; i < 10; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(tab[i]);
                        }
                    }
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "Wyświetl parzyste indeksy":
                    for (int i = 0; i < 10; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(tab[i]);
                        }
                    }
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "4":
                    for (int i = 0; i < 10; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(tab[i]);
                        }
                    }
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "Oblicz sumę elementów tablicy":
                    suma(tab);
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "5":
                    suma(tab);
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "Oblicz iloczyn elementów tablicy":
                    iloczyn(tab);
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "6":
                    iloczyn(tab);
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "Wyznacz wartość średnią":
                    sr(tab);
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "7":
                    sr(tab);
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "Wyznacz wartość minimalną":
                    min(tab);
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "8":
                    min(tab);
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "Wyznacz wartość maksymalną":
                    max(tab);
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "9":
                    max(tab);
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "Koniec programu":
                    petla = false;
                    break;
                case "10":
                    petla = false;
                    break;
                default:
                    Console.WriteLine("Operacja została anulowana!");
                    Console.WriteLine("Z powodu wybrania złej akcji.");
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
            }
        }

        

        static void Main(string[] args)
        {
            
            double[] tablica = new double[10];    
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Podaj zawartość komórki:");
                tablica[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            bool petla = true;
            while (petla)
            {
                Menu(tablica,ref petla);
            }
            Console.ReadKey();
        }
    }
}
