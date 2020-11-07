namespace RS2.PropertyHiding
{

    public class Zaposleni
{
    private string _name;
    
    public string Name
    {
        get {return _name;}
        set {_name = value;}
    }
}

public class Menadzer : Zaposleni
{
    private string _name;

    // Notice the use of the new modifier:
    public new string Name
    {
        get {return _name;}
        set {_name = value + ", Manager";}
    }
}

class TestHiding
{
    static void Main()
    {
        Menadzer m1 = new Menadzer();

        // Derived class property.
        m1.Name = "John";

        // Base class property.
        ((Zaposleni)m1).Name = "Mary";

        System.Console.WriteLine("Ime u izvedenoj klasi: {0}", m1.Name);
        System.Console.WriteLine("Ime u isnocnoj klasi: {0}", 
            ((Zaposleni)m1).Name);
    }
}
/* Output:
    Name in the derived class is: John, Manager
    Name in the base class is: Mary
*/
}
