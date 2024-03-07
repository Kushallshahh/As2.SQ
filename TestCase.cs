using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TestCases
{
    public class Class1
    {
        [TestFixture]
        public class TriangleTest1

        {
//Scalene
[Test]
public void ValidScaleneTriangle_Input30and40and50_OutputValidScaleneTriangle()
{
    // Arrange
    int side1 = 30;
    int side2 = 40;
    int side3 = 50;
    string expected = "A triangle is formed and it is a SCALENE";

    // Act
    string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

    // Assert
    Assert.AreEqual(expected, actual);
}

[Test]
public void ValidScaleneTriangle_Input45and60and75_OutputValidScaleneTriangle()
{
    // Arrange
    int side1 = 45;
    int side2 = 60;
    int side3 = 75;
    string expected = "A triangle is formed and it is a SCALENE";

    // Act
    string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

    // Assert
    Assert.AreEqual(expected, actual);
}


[Test]
public void ValidScaleneTriangle_Input55and72and87_OutputValidScaleneTriangle()
{
    // Arrange
    int side1 = 55;
    int side2 = 72;
    int side3 = 87;
    string expected = "A triangle is formed and it is a SCALENE";

    // Act
    string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

    // Assert
    Assert.AreEqual(expected, actual);
}

[Test]
public void ValidScaleneTriangle_Input25and63and48_OutputValidScaleneTriangle()
{
    // Arrange
    int side1 = 25;
    int side2 = 63;
    int side3 = 48;
    string expected = "A triangle is formed and it is a SCALENE";

    // Act
    string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

    // Assert
    Assert.AreEqual(expected, actual);
}


[Test]
public void ValidScaleneTriangle_Input20and35and45_OutputValidScaleneTriangle()
{
    // Arrange
    int side1 = 20;
    int side2 = 35;
    int side3 = 45;
    string expected = "A triangle is formed and it is a SCALENE";

    // Act
    string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

    // Assert
    Assert.AreEqual(expected, actual);
}

 //Isosceles
 [Test]
 public void ValidIsoscelesTriangle_Input50and50and80_OutputValidIsoscelesTriangle()
 {
     // Arrange
     int side1 = 50;
     int side2 = 50;
     int side3 = 80;
     string expected = "A triangle is formed and it is an ISOSCELES";

     // Act
     string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

     // Assert
     Assert.AreEqual(expected, actual);
 }

 [Test]
 public void ValidIsoscelesTriangle_Input30and40and30_OutputValidIsoscelesTriangle()
 {
     // Arrange
     int side1 = 30;
     int side2 = 40;
     int side3 = 30;
     string expected = "A triangle is formed and it is an ISOSCELES";

     // Act
     string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

     // Assert
     Assert.AreEqual(expected, actual);
 }

 [Test]
 public void ValidIsoscelesTriangle_Input70and40and70_OutputValidIsoscelesTriangle()
 {
     // Arrange
     int side1 = 70;
     int side2 = 40;
     int side3 = 70;
     string expected = "A triangle is formed and it is an ISOSCELES";

     // Act
     string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

     // Assert
     Assert.AreEqual(expected, actual);
 }


            
             //Equilateral
 [Test]
 public void ValidEquilateralTriangle_Input60and60and60_OutputValidEquilateralTriangle()
 {
     // Arrange
     int side1 = 60;
     int side2 = 60;
     int side3 = 60;
     string expected = "A triangle is formed and it is an EQUILATERAL";

     // Act
     string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

     // Assert
     Assert.AreEqual(expected, actual);
 }
            //Invalid 0
            [Test]
            public void ZeroLengthSide_Input0and40and50_OutputInvalidTriangle()
            {
                // Arrange
                int side1 = 0;
                int side2 = 40;
                int side3 = 50;
                string expected = "INVALID triangle - a zero was entered";

                // Act
                string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void ZeroLengthSide_Input20and0and45_OutputInvalidTriangle()
            {
                // Arrange
                int side1 = 20;
                int side2 = 0;
                int side3 = 45;
                string expected = "INVALID triangle - a zero was entered";

                // Act
                string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void ZeroLengthSide_Input30and40and0_OutputInvalidTriangle()
            {
                // Arrange
                int side1 = 30;
                int side2 = 40;
                int side3 = 0;
                string expected = "INVALID triangle - a zero was entered";

                // Act
                string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

                // Assert
                Assert.AreEqual(expected, actual);
            }
            //Invalid non zero
            [Test]
            public void InvalidResponse_Input10and20and30_OutputInvalidTriangle()
            {
                // Arrange
                int side1 = 10;
                int side2 = 20;
                int side3 = 30;
                string expected = "A triangle is not formed based on the input values";

                // Act
                string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void InvalidResponse_Input5and5and15_OutputInvalidTriangle()
            {
                // Arrange
                int side1 = 5;
                int side2 = 5;
                int side3 = 15;
                string expected = "A triangle is not formed based on the input values";

                // Act
                string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void InvalidResponse_Input8and15and40_OutputInvalidTriangle()
            {
                // Arrange
                int side1 = 8;
                int side2 = 15;
                int side3 = 40;
                string expected = "A triangle is not formed based on the input values";

                // Act
                string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

                // Assert
                Assert.AreEqual(expected, actual);
            }




        }
    }
}
