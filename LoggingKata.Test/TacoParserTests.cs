using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            var test = new TacoParser();//Arrange

            var store = test.Parse(line);
            var actual = store.Location.Longitude;//Act

            Assert.Equal(expected, actual);//Assert
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        public void ShouldParseLatitude(string line, double expected)
        {
            var test = new TacoParser();//Arrange

            var store = test.Parse(line);
            var actual = store.Location.Latitude;//Act

            Assert.Equal(expected, actual);//Assert
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", "Taco Bell Acwort...")]
        public void ShouldParseName(string line, string expected)
        {
            var test = new TacoParser();//Arrange

            var store = test.Parse(line);
            var actual = store.Name;//Act
            Console.WriteLine(expected);
            Console.WriteLine(actual);
            Assert.Equal(expected, actual);//Assert
           
        }

    }
}
