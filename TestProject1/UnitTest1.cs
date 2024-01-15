
using NuGet;

using Xunit;




namespace BmiCalculatorFromValentynTukov
{
    public class ProgramTests
    {
        [Fact]

        public void BMICalculation_ReturnsCorrectValue()
        {
            // Arrange
            double weight = 70; 
            double height = 1.75; 

            // Act

            double result = Utilites.BMI(weight, height);

            // Assert
            Assert.Equal(22.86, result); 
        }
        [Fact]

        public void MinUsefulWeight_Test()
        {
            // Arrange
            
            double height = 1.75;

            // Act

            double result = Utilites.MinUsefulWeight(height);

            // Assert
            Assert.Equal(56.96, result);
        }

        [Fact]

        public void MaxUsefulWeight_Test()
        {
            // Arrange

            double height = 1.75;

            // Act

            double result = Utilites.MaxUsefulWeight(height);

            // Assert
            Assert.Equal(76.26, result);
        }

    }
}

