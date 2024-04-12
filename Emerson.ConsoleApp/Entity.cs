namespace Emerson.ConsoleApp
{
    // Sample class with code analysis issue
    public abstract class Entity
    {
        public string Name { get; set; }

        public Entity(string name)
        {
            Name = name;
        }
    }
}
