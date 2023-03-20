//1.lépés
using System.IO;
using System.Text;
namespace HelloWorld
{
    class Program
    {
        //2.lépés tároló szerkezet kialakítása osztály szinten
        static List<Balkezek> Balkezes_List = new List<Balkezek>();
        static int Bekert;
        static void Main(string[] args)
        {
            //3.lépés a beolvasás meghívása mint eljárás
            Feladat2(); Console.WriteLine("\n----------------\n");
            Feladat3(); Console.WriteLine("\n----------------\n");
            Feladat4(); Console.WriteLine("\n----------------\n");
            Feladat5(); Console.WriteLine("\n----------------\n");
        }

        private static void Feladat5()
        {
            Console.WriteLine("Feladat 5: Bekérés 1990-1999");
            Bekert = 0;
            bool Sikerult = false;
            while(Bekert<1990 || 1999<Bekert)
            {
                Console.Write("Kérem adjon meg évszámot: ");
                Bekert=int.Parse(Console.ReadLine());
                if(1990<=Bekert && Bekert<=1999)
                { Sikerult=true;}

            }
            if(Sikerult==true)
            {
                Console.WriteLine("\n----------------\n");
                Feledat6(); 
            }
        }

        private static void Feledat6()
        {
            Console.WriteLine("Feladat 6");
            double Osszeg = 0;
            int db = 0;
            foreach (var b in Balkezes_List)
            {
                if(b.Elso.Contains(Bekert.ToString()))
                {
                    Osszeg += (double)b.Suly;
                    db++;
                }
            }
            double AtlagSuly = Osszeg / db;
            Console.WriteLine($"A játékosok átlag súlya: {AtlagSuly:0.00}");
        }

        private static void Feladat4()
        {
            Console.WriteLine("4.Feladat: 1999-október");
            foreach (var b in Balkezes_List)
            {
                if(b.Utolso.Contains("1999-10"))
                {
                    double CM= b.Magassag * 2.54;
                    Console.WriteLine($"Név: {b.Nev} : {CM:0.00} cm");
                }
            }
        }

        private static void Feladat3()
        {
            Console.WriteLine("Feladat 3: Beolvasott sorokszáma");
            Console.WriteLine($"Beolvasott sorok száma: {Balkezes_List.Count}");
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.Feladat: beolvasás");
            var sr = new StreamReader(@"balkezesek.csv", Encoding.UTF8);
            while(!sr.EndOfStream)
            {
                Balkezes_List.Add(new Balkezek(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}