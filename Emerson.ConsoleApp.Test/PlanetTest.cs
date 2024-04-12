namespace Emerson.ConsoleApp.Test
{
    public class PlanetTest
    {
        [Fact]
        public void Instantiate_WithName_ShouldHaveName()
        {
            var name = "Planet1";
            var target = new Planet(name);

            Assert.Equal(target.Name, name);
        }
    }
}