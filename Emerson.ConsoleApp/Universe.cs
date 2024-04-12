namespace Emerson.ConsoleApp
{
    // Sample class with code analysis issue
    public class Universe
    {
        public Universe()
        {
        }

        public Universe(List<Entity> entities)
        {
            entities.ForEach(e => Entities.Add(e));
        }

        public List<Entity> Entities { get; set; }

        public string GetNames()
        {
            return string.Join(",", Entities.Select(n => n.Name));
        }
    }
}
