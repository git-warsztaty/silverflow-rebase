namespace silverflow_rebase
{
    internal class Person
    {
        private const int ADULT_AGE = 18;
        private readonly string _name;
        private readonly int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name => _name;
        public int Age => _age;

        public bool IsAdult => Age >= ADULT_AGE;
    }
}