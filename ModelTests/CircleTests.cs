using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests 
{
    public class CircleTests
    {
        [TestMethod]
        
            public void Circle_GetCircum_DiameterOfCircle()
            {
                //Arrange
                Circle newCircle = new Circle(2);
                //Act
                float result = newCircle.GetCircum();
                Assert.AreEqual(result, 12.56f);
            }
        
    }
}