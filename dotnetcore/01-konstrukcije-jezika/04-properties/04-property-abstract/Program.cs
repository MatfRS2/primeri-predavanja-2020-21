
using System;

namespace RS2.PropertyAbstract
{

abstract class Oblik
{
    public abstract double Povrsina
    {
        get;
        set;
    }
}

class Kvadrat : Oblik
{
    public double ivica;

    //constructor
    public Kvadrat(double a){
        ivica = a;
    }

    public override double Povrsina
    {
        get {return ivica * ivica;}
        set {ivica = System.Math.Sqrt(value);}
    }
}

class Kocka : Oblik
{
    public double ivica;

    //constructor
    public Kocka(double a) { 
        ivica = a;
    }

    public override double Povrsina
    {
        get {return 6 * ivica * ivica;}
        set {ivica = System.Math.Sqrt(value / 6);}
    }
}

class Program
{
    static void Main()
    {
        System.Console.Write("Unesi duzinu ivice: ");
        double ivica = double.Parse(System.Console.ReadLine());

        Kvadrat kv = new Kvadrat(ivica);
        Kocka ko = new Kocka(ivica);

        System.Console.WriteLine("Povrsina kvadrata = {0:F2}", kv.Povrsina);
        System.Console.WriteLine("Povrsina kocke = {0:F2}", ko.Povrsina);
        System.Console.WriteLine();

        System.Console.Write("Unesi povrsinu: ");
        double povrsina = double.Parse(System.Console.ReadLine());

        kv.Povrsina = povrsina;
        ko.Povrsina = povrsina;

        System.Console.WriteLine("ivica kvadrata = {0:F2}", kv.ivica);
        System.Console.WriteLine("ivica kocke = {0:F2}", ko.ivica);
    }
}
/* Example Output:
    Enter the ivica: 4
    Area of the square = 16.00
    Area of the cube = 96.00

    Enter the area: 24
    ivica of the square = 4.90
    ivica of the cube = 2.00
*/

}

