namespace HelloConsoleProperties
{
    public class Artikal
    {
        string _name;
        decimal _cost;

        public Artikal(string name, decimal cost)
        {
            _name = name;
            _cost = cost;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public decimal Price
        {
            get => _cost;
            set => _cost = value;
        }       
    }
}