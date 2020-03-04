using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models; 

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {
    [TestMethod]
    public void Sphere_GetSurfaceArea_SurfaceAreaOfSphere()
    {
      //Arrange
      Circle newCircle = new Circle(2);
      Sphere newSphere = new Sphere(newCircle);
      //Act
      float result = newSphere.GetSurfaceArea();
      // Assert
      Assert.AreEqual(result, 50.24f, .01f);
    }
    
  }
}
