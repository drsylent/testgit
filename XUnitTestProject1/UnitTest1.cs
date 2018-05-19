using System;
using RDFSharp.Model;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void RDFResourceTest_ConstructorEmptyParameters()
        {
            // Arrange
            // -

            // Act
            RDFResource res = new RDFResource();

            // Assert
            Assert.True(res.IsBlank);
            Assert.NotNull(res.URI);
            Assert.NotNull(res.PatternMemberID);
        }

        [Fact]
        public void RDFResourceTest_ConstructorWithUri01()
        {
            // Arrange
            // -

            // Act
            RDFResource res = new RDFResource("http://www.pa.press.net/constituencies/281");

            // Assert
            Assert.False(res.IsBlank);
            Assert.NotNull(res.URI);
            Assert.NotNull(res.PatternMemberID);
        }

        [Fact]
        public void RDFResourceTest_ConstructorWithUri02()
        {
            // Arrange
            Action constructor = () => new RDFResource("random_false_uri");

            // Act
            // -

            // Assert
            Assert.Throws<RDFModelException>(constructor);

        }

    }
}
