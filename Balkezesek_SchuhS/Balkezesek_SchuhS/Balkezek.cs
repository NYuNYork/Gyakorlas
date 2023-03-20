//1.lépés
namespace HelloWorld
{
    internal class Balkezek
    {
        //név;első;utolsó;súly;magasság
        //ezek az osztály szintű változók amikbe
        //majd letároljuk a meghvott sorok darabjait
        public string Nev;
        public string Elso;
        public string Utolso;
        public int Suly;
        public int Magassag;

        public Balkezek (string Sor)
        {
            var dbok = Sor.Split(';');
            this.Nev = dbok[0];
            this.Elso = dbok[1];
            this.Utolso = dbok[2];
            this.Suly = int.Parse(dbok[3]);
            this.Magassag = int.Parse(dbok[4]);
        }
    }
}