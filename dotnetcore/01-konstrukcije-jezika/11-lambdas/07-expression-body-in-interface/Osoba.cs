namespace HelloConsoleProperties
{
    public class Osoba
    {
        private string _firstName;
        private string _lastName;
    
        public Osoba(string first, string last)
        {
            _firstName = first;
            _lastName = last;
        }

        public string Name => $"{_firstName} {_lastName}";

    }
}