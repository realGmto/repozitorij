using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori
{
    public class Kalkulator
    {
        public static int izracun = 0, a;
        public static bool choice;
        static void Main(string[] args)
        {
            int odabir;
            Upisi:
                Console.WriteLine("zelis li zbrajati ili množiti (1=zbrajanje 2=mnozenje)");
            odabir = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (odabir == 1)
            {
                Funkcija_zbrajanja();
            }
            else if (odabir == 2)
            {
                Funkcija_mnozenje();
            }
            else
            {
                Console.WriteLine("pogresan upis, ponovi");
                goto Upisi;
            }

            Console.WriteLine("vas izracun je "+izracun);
            Console.ReadKey();
        }
        public static void Funkcija_zbrajanja()
        {
            do
            {
                Console.WriteLine("upisi sljedeci broj");
                a = Convert.ToInt32(Console.ReadLine());
                izracun = izracun + a;
                Console.WriteLine("zelis li nastaviti sa upisivanjemo (true ili false)");
                choice = Convert.ToBoolean(Console.ReadLine());
                Console.Clear();
            } while (choice == true);
        }
        public static void Funkcija_mnozenje()
        {
            izracun = 1;
            do
            {
                Console.WriteLine("upisi sljedeci broj");
                a = Convert.ToInt32(Console.ReadLine());
                izracun = izracun * a;
                Console.WriteLine("zelis li nastaviti sa upisivanjemo (true ili false)");
                choice = Convert.ToBoolean(Console.ReadLine());
                Console.Clear();
            } while (choice == true);
        }
    }
}
