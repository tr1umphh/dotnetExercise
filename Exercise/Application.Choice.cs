namespace Exercise;

public static partial class Application
{
    private class Choice
    {
        private string Name { get; set; }
        private Options Value { get; set; }

        public Choice(string name, Options value)
        {
            Name = name;
            Value = value;
        }

        public Options getMenu()
        {
            return Value;
        }

    }
}