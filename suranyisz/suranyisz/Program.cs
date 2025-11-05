using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suranyisz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                HelloWorld();
                Koszones();
                Ketszeres();
                KetSzamMuveletek();
                Nagyobbik();
                LegkisebbHarom();
                HaromszogSzerkesztheto();
                SzamtaniMertaniKozep();
                MasodfokuVanEMegoldas();
                MasodfokuMegoldasok();
                DerekszoguAtfogo();
                TeglatestFelszinTerfogat();
                KorKeruletTerulet();
                KorivTeruletIv();
                pozitiv();
                pozitiv1();
                osztok();
                egeszosszeg();
                Feladat19();
                Feladat20();
                CsakPozitivBevitel();
                OsszegTizAlatt();
                KettesFelbontas();
                CsakAlma();
                HarommalOsztasMaradek();
                PrimVizsgalat();
                PrimLista();
                PrimOsztok();
                PrimTenyezosFelbontas();
                LegnagyobbKozosOszto();
                LegkisebbKozosTobbszoros();
                Szorzotabla();
                OsszegtTabla();
                SzamjegyCsereSpecialis();
                KisbetukEsAscii();
                MintasTabla();
                CsillagHaromszogBalra();
                CsillagHaromszogJobbra();
                UresTeglalap();
                TokeletesSzamokEddig();
                VigenereTabla();
                ParatlanDb();
                ParosOsszeg();
                ParosokSorszammal();
                KeresesTombben();
                ElfordulasDb();
                KeresztnevekSzamlalasa();
                MinMaxKulonbseg();
                RendezettTomb();
                SzovegSzokozokkel();
                TabuBetuNelkul();
                MindenMasodikBetu();
                BetukAsciiKoddal();
                ForditottSzo();
                MondatSzavankent();
                ForditottNagybetus();
                SzavakElsoBetujeNagy();
            }
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello world!");
        }

        static void Koszones()
        {
            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Szia, {nev}!");
        }

        static void Ketszeres()
        {
            Console.Write("Adj meg egy számot: ");
            double szam = double.Parse(Console.ReadLine());
            Console.WriteLine($"A szám kétszerese: {szam * 2}");
        }

        static void KetSzamMuveletek()
        {
            Console.Write("Első szám: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Második szám: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Különbség: {a - b}");
            Console.WriteLine($"Szorzat: {a * b}");
            if (b != 0)
                Console.WriteLine($"Hányados: {a / b}");
            else
                Console.WriteLine("Nullával nem lehet osztani!");
        }

        static void Nagyobbik()
        {
            Console.Write("Első egész szám: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Második egész szám: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"A nagyobbik: {(a > b ? a : b)}");
        }

        static void LegkisebbHarom()
        {
            Console.Write("Első szám: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Második szám: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Harmadik szám: ");
            int c = int.Parse(Console.ReadLine());

            int min = Math.Min(a, Math.Min(b, c));
            Console.WriteLine($"A legkisebb: {min}");
        }

        static void HaromszogSzerkesztheto()
        {
            Console.Write("1. oldal: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("2. oldal: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("3. oldal: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("Szerkeszthető háromszög.");
            else
                Console.WriteLine("Nem szerkeszthető háromszög.");
        }

        static void SzamtaniMertaniKozep()
        {
            Console.Write("Első pozitív szám: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Második pozitív szám: ");
            double b = double.Parse(Console.ReadLine());

            if (a > 0 && b > 0)
            {
                double szamtani = (a + b) / 2;
                double mertani = Math.Sqrt(a * b);
                Console.WriteLine($"Számtani közép: {szamtani}, Mértani közép: {mertani}");
            }
            else
                Console.WriteLine("Csak pozitív számokkal működik!");
        }

        static void MasodfokuVanEMegoldas()
        {
            Console.WriteLine("Másodfokú egyenlet: ax^2 + bx + c = 0");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double D = b * b - 4 * a * c;
            if (D >= 0)
                Console.WriteLine("Van megoldás.");
            else
                Console.WriteLine("Nincs valós megoldás.");
        }

        static void MasodfokuMegoldasok()
        {
            Console.WriteLine("Másodfokú egyenlet: ax^2 + bx + c = 0");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Két megoldás: x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                double x0 = -b / (2 * a);
                Console.WriteLine($"Egy megoldás: x = {x0}");
            }
            else
            {
                Console.WriteLine("Nincs valós megoldás.");
            }
        }

        static void DerekszoguAtfogo()
        {
            Console.Write("Első befogó: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Második befogó: ");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"Átfogó hossza: {c:F2}");
        }

        static void TeglatestFelszinTerfogat()
        {
            Console.Write("a él: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b él: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c él: ");
            double c = double.Parse(Console.ReadLine());

            double felszin = 2 * (a * b + a * c + b * c);
            double terfogat = a * b * c;
            Console.WriteLine($"Felszín: {felszin}, Térfogat: {terfogat}");
        }

        static void KorKeruletTerulet()
        {
            Console.Write("Kör átmérője: ");
            double d = double.Parse(Console.ReadLine());
            double r = d / 2;
            double kerulet = 2 * Math.PI * r;
            double terulet = Math.PI * r * r;
            Console.WriteLine($"Kerület: {kerulet}, Terület: {terulet}");
        }

        static void KorivTeruletIv()
        {
            Console.Write("Sugár: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Középponti szög (fok): ");
            double alfa = double.Parse(Console.ReadLine());

            double ivHossz = 2 * Math.PI * r * (alfa / 360);
            double terulet = Math.PI * r * r * (alfa / 360);
            Console.WriteLine($"Körív hossza: {ivHossz}, Szelet területe: {terulet}");
        }

        static void pozitiv()
        {
            Console.Write("Adj meg egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }


        static void pozitiv1()
        {
            Console.Write("Adj meg egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }


        static void osztok()
        {
            Console.Write("Adj meg egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"A(z) {n} osztói: ");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }


        static void egeszosszeg()
        {
            Console.Write("Adj meg egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine());
            int osszeg = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    osszeg += i;
            }
            Console.WriteLine($"A(z) {n} osztóinak összege: {osszeg}");
        }

        static void Feladat19()
        {
            Console.Write("Adj meg egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine());
            int osszeg = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    osszeg += i;
            }

            if (osszeg == 2 * n)
                Console.WriteLine($"{n} tökéletes szám.");
            else
                Console.WriteLine($"{n} nem tökéletes szám.");
        }

        static void Feladat20()
        {
            Console.Write("Hatványalap: ");
            int alap = int.Parse(Console.ReadLine());
            Console.Write("Kitevő: ");
            int kitevo = int.Parse(Console.ReadLine());

            int eredmeny = 1;
            for (int i = 0; i < kitevo; i++)
            {
                eredmeny *= alap;
            }

            Console.WriteLine($"Hatványérték: {eredmeny}");
        }
        static void CsakPozitivBevitel()
        {
            int szam;
            do
            {
                Console.Write("Adj meg egy pozitív számot: ");
                szam = int.Parse(Console.ReadLine());
            } while (szam <= 0);
            Console.WriteLine($"Elfogadott szám: {szam}");
        }

        static void OsszegTizAlatt()
        {
            int osszeg = 0, szam;
            do
            {
                Console.Write("Adj meg egy számot (>=10 esetén leáll): ");
                szam = int.Parse(Console.ReadLine());
                if (szam < 10)
                    osszeg += szam;
            } while (szam < 10);
            Console.WriteLine($"Beolvasott számok összege: {osszeg}");
        }

        static void KettesFelbontas()
        {
            Console.Write("Kérek egy egész számot: ");
            int n = int.Parse(Console.ReadLine());
            int eredeti = n;
            Console.Write($"{eredeti} = ");
            while (n % 2 == 0)
            {
                Console.Write("2*");
                n /= 2;
            }
            Console.WriteLine(n);
        }

        static void CsakAlma()
        {
            string szo;
            do
            {
                Console.Write("Írj be egy szót: ");
                szo = Console.ReadLine();
            } while (szo != "alma");
            Console.WriteLine("Az alma gyümölcs!");
        }

        static void HarommalOsztasMaradek()
        {
            Console.Write("Kérek egy egész számot: ");
            int n = int.Parse(Console.ReadLine());
            int hanyados = n / 3;
            int maradek = n % 3;
            Console.WriteLine($"{n} = {hanyados}*3+{maradek}");
        }
        static void PrimVizsgalat()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());
            bool prim = n > 1;
            for (int i = 2; i <= Math.Sqrt(n) && prim; i++)
                if (n % i == 0) prim = false;
            Console.WriteLine(prim ? "Prímszám." : "Nem prímszám.");
        }

        static void PrimLista()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Prímszámok {n}-ig:");
            for (int i = 2; i <= n; i++)
            {
                bool prim = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                    if (i % j == 0) prim = false;
                if (prim) Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void PrimOsztok()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"A(z) {n} prímosztói: ");
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    bool prim = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                        if (i % j == 0) prim = false;
                    if (prim) Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static void PrimTenyezosFelbontas()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"{n} = ");
            int i = 2;
            while (n > 1)
            {
                if (n % i == 0)
                {
                    Console.Write(i);
                    n /= i;
                    if (n > 1) Console.Write("*");
                }
                else i++;
            }
            Console.WriteLine();
        }

        static void LegnagyobbKozosOszto()
        {
            Console.Write("Első szám: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Második szám: ");
            int b = int.Parse(Console.ReadLine());

            int x = a, y = b;
            while (y != 0)
            {
                int t = y;
                y = x % y;
                x = t;
            }
            Console.WriteLine($"LNKO({a},{b}) = {x}");
        }
        static void LegkisebbKozosTobbszoros()
        {
            Console.Write("Első szám: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Második szám: ");
            int b = int.Parse(Console.ReadLine());

            int x = a, y = b;
            while (y != 0)
            {
                int t = y;
                y = x % y;
                x = t;
            }
            int lnko = x;
            int lkkt = a * b / lnko;
            Console.WriteLine($"LKKT({a},{b}) = {lkkt}");
        }

        static void Szorzotabla()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{n} * {i} = {n * i}");
        }

        static void OsszegtTabla()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                    Console.Write((i + j) + "\t");
                Console.WriteLine();
            }
        }
        static void SzamjegyCsereSpecialis()
        {
            for (int x = 10; x <= 99; x++)
            {
                for (int y = 10; y <= 99; y++)
                {
                    int xy = x * y;
                    int x1 = x % 10 * 10 + x / 10;
                    int y1 = y % 10 * 10 + y / 10;
                    if (x * y == x1 * y1 && (x != x1 || y != y1))
                        Console.WriteLine($"{x} és {y}");
                }
            }
        }

        static void KisbetukEsAscii()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.Write($"{c} {Convert.ToInt32(c)}\t");
                if ((c - 'a' + 1) % 5 == 0)
                    Console.WriteLine();
            }
        }
        static void MintasTabla()
        {
            Console.Write("Sorok száma: ");
            int sor = int.Parse(Console.ReadLine());
            Console.Write("Oszlopok száma: ");
            int oszlop = int.Parse(Console.ReadLine());

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    bool parosSor = i % 2 == 1;
                    bool parosOszlop = j % 2 == 0;
                    char ch = (parosSor == parosOszlop) ? 'O' : 'X';
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
        }


        static void CsillagHaromszogBalra()
        {
            Console.Write("Add meg a háromszög magasságát: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        static void CsillagHaromszogJobbra()
        {
            Console.Write("Add meg a háromszög magasságát: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int j = i; j < a; j++) Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++) Console.Write("*");
                Console.WriteLine();
            }
        }

        static void UresTeglalap()
        {
            Console.Write("Szélesség (N): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Magasság (M): ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == m - 1 || j == 0 || j == n - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void TokeletesSzamokEddig()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Tökéletes számok:");
            for (int i = 1; i <= n; i++)
            {
                int osszeg = 0;
                for (int j = 1; j <= i; j++)
                    if (i % j == 0) osszeg += j;
                if (osszeg == 2 * i) Console.WriteLine(i);
            }
        }

        static void VigenereTabla()
        {
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(abc.Substring(i) + abc.Substring(0, i));
            }
        }

        static void ParatlanDb()
        {
            Console.Write("Hány számot olvasunk be? ");
            int db = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < db; i++)
            {
                Console.Write($"[{i + 1}]. szám: ");
                int n = int.Parse(Console.ReadLine());
                if (n % 2 != 0) count++;
            }
            Console.WriteLine($"Páratlan számok darabszáma: {count}");
        }


        static void ParosOsszeg()
        {
            Console.Write("Hány számot olvasunk be? ");
            int db = int.Parse(Console.ReadLine());
            int osszeg = 0;
            for (int i = 0; i < db; i++)
            {
                Console.Write($"[{i + 1}]. szám: ");
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0) osszeg += n;
            }
            Console.WriteLine($"Páros számok összege: {osszeg}");
        }


        static void ParosokSorszammal()
        {
            Console.Write("Hány számot olvasunk be? ");
            int db = int.Parse(Console.ReadLine());
            for (int i = 0; i < db; i++)
            {
                Console.Write($"[{i + 1}]. szám: ");
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                    Console.WriteLine($"{i + 1}. elem: {n}");
            }
        }

        static void KeresesTombben()
        {
            Console.Write("Hány számot olvasunk be? ");
            int db = int.Parse(Console.ReadLine());
            int[] t = new int[db];
            for (int i = 0; i < db; i++)
            {
                Console.Write($"[{i + 1}]. szám: ");
                t[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Keresett szám: ");
            int keres = int.Parse(Console.ReadLine());
            int index = Array.IndexOf(t, keres);
            if (index == -1)
                Console.WriteLine("Nincs benne a tömbben.");
            else
                Console.WriteLine($"Első előfordulás indexe: {index}");
        }


        static void ElfordulasDb()
        {
            Console.Write("Hány számot olvasunk be? ");
            int db = int.Parse(Console.ReadLine());
            int[] t = new int[db];
            for (int i = 0; i < db; i++)
            {
                Console.Write($"[{i + 1}]. szám: ");
                t[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Keresett szám: ");
            int keres = int.Parse(Console.ReadLine());
            int count = t.Count(x => x == keres);
            Console.WriteLine($"{keres} ennyiszer fordul elő: {count}");
        }
        static void KeresztnevekSzamlalasa()
        {
            Console.Write("Hány nevet olvasunk be? ");
            int db = int.Parse(Console.ReadLine());
            string[] nevek = new string[db];
            for (int i = 0; i < db; i++)
            {
                Console.Write($"[{i + 1}]. név: ");
                nevek[i] = Console.ReadLine();
            }

            Console.Write("Keresett név: ");
            string keres = Console.ReadLine();
            int count = nevek.Count(n => n == keres);
            Console.WriteLine($"{keres} nevű tanuló ennyien vannak: {count}");
        }
        static void MinMaxKulonbseg()
        {
            Console.Write("Hány számot olvasunk be? ");
            int db = int.Parse(Console.ReadLine());
            int[] t = new int[db];
            for (int i = 0; i < db; i++)
            {
                Console.Write($"[{i + 1}]. szám: ");
                t[i] = int.Parse(Console.ReadLine());
            }

            int kul = t.Max() - t.Min();
            Console.WriteLine($"Különbség: {kul}");
        }


        static void RendezettTomb()
        {
            Console.Write("Hány számot olvasunk be? ");
            int db = int.Parse(Console.ReadLine());
            int[] t = new int[db];
            for (int i = 0; i < db; i++)
            {
                Console.Write($"[{i + 1}]. szám: ");
                t[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(t);
            Console.WriteLine("Rendezett tömb:");
            foreach (int x in t) Console.Write(x + " ");
            Console.WriteLine();
        }

      static void SzovegSzokozokkel()
        {
            Console.Write("Adj meg egy szót: ");
            string szo = Console.ReadLine();
            Console.WriteLine(string.Join(" ", szo.ToCharArray()));
        }

        static void TabuBetuNelkul()
        {
            Console.Write("Szó: ");
            string szo = Console.ReadLine();
            Console.Write("Tabu betű: ");
            char tabu = Console.ReadLine()[0];
            string uj = new string(szo.Where(ch => ch != tabu).ToArray());
            Console.WriteLine(uj);
        }

        static void MindenMasodikBetu()
        {
            Console.Write("Szó: ");
            string szo = Console.ReadLine();
            for (int i = 0; i < szo.Length; i += 2)
                Console.Write(szo[i]);
            Console.WriteLine();
        }

        static void BetukAsciiKoddal()
        {
            Console.Write("Szó: ");
            string szo = Console.ReadLine();
            foreach (char c in szo)
                Console.WriteLine($"{c} -> {Convert.ToInt32(c)}");
        }

        static void ForditottSzo()
        {
            Console.Write("Szó: ");
            string szo = Console.ReadLine();
            Console.WriteLine(new string(szo.Reverse().ToArray()));
        }
        static void MondatSzavankent()
        {
            Console.Write("Mondat: ");
            string mondat = Console.ReadLine();
            string[] szavak = mondat.Split(' ');
            foreach (string s in szavak)
                Console.WriteLine(s);
        }

        static void ForditottNagybetus()
        {
            Console.Write("Szó: ");
            string szo = Console.ReadLine();
            string uj = new string(szo.Reverse().ToArray()).ToUpper();
            Console.WriteLine(uj);
        }

        static void SzavakElsoBetujeNagy()
        {
            Console.Write("Mondat: ");
            string mondat = Console.ReadLine();
            string[] szavak = mondat.Split(' ');
            for (int i = 0; i < szavak.Length; i++)
            {
                if (szavak[i].Length > 0)
                    szavak[i] = char.ToUpper(szavak[i][0]) + szavak[i].Substring(1);
            }
            Console.WriteLine(string.Join(" ", szavak));
        }
    }
}
    }
}