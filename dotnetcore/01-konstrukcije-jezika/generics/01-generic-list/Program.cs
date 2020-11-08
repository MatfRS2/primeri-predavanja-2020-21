namespace RS2.GenericList
{
    public class Program
    {
    static void Main()
    {
        // int is the type argument
        OneWayList<int> list = new OneWayList<int>();

        for (int x = 0; x < 5; x++)
        {
            list.AddHead(x);
        }
        foreach (int i in list)
        {
            System.Console.Write(i + " ");
        }
        
        OneWayList<Poruka> list2 = new OneWayList<Poruka>();

        for (int x = 0; x < 5; x++)
        {
            list2.AddHead(new Poruka{
                Sadrzaj = "Broj" + x,
                BrojPonavljanja = 1
            });
        }
        foreach (Poruka p in list2)
        {
            p.PrikazNaKonzolu();
        }
    }
    }

}
