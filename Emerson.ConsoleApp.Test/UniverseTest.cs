namespace Emerson.ConsoleApp.Test
{
    public class UniverseTest
    {
        [Fact]
        public void Add_1Planet_ShouldContain_1Entity()
        {
            var planet1 = new Planet("Planet1");

            var target = new Universe(new List<Entity>() { planet1 });

            Assert.Equal(1, target.Entities.Count());
        }
    }
}
