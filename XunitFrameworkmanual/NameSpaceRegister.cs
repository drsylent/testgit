using System;
using RDFSharp.Model;
using Xunit;

namespace XunitFrameworkmanual
{
    public class RDFNamespaceRegisterTest
    {
        [Fact]
        public void RDFNamespaceRegisterTest_GetByUri()
        {
            // Arrange
            RDFNamespace nsp = new RDFNamespace("randompref", "http://www.ePolitix.com/2001/03/rdf-schema#");
            RDFNamespaceRegister.AddNamespace(nsp);

            // Act
            var res = RDFNamespaceRegister.GetByUri("http://www.ePolitix.com/2001/03/rdf-schema#");

            // Assert
            Assert.Equal(nsp, res);
        }
        [Fact]
        public void RDFNamespaceRegisterTest_GetByPref()
        {
            // Arrange
            RDFNamespace nsp = new RDFNamespace("randompref", "http://www.ePolitix.com/2001/03/rdf-schema#");
            RDFNamespaceRegister.AddNamespace(nsp);

            // Act
            var res = RDFNamespaceRegister.GetByPrefix("randompref");

            // Assert
            Assert.Equal(nsp, res);
        }
        [Fact]
        public void RDFNamespaceRegisterTest_GetByUriNoFound()
        {
            // Arrange
            RDFNamespace nsp = new RDFNamespace("randompref", "http://www.ePolitix.com/2001/03/rdf-schema#");

            // Act
            var res = RDFNamespaceRegister.GetByPrefix("http://www.ePolitix.com/2001/03/rdf-schema#");

            // Assert
            Assert.Null(res);
        }
        [Fact]
        public void RDFNamespaceRegisterTest_GetByPrefNoFound()
        {
            // Arrange
            RDFNamespace nsp = new RDFNamespace("randompref", "http://www.ePolitix.com/2001/03/rdf-schema#");

            // Act
            var res = RDFNamespaceRegister.GetByPrefix("randompref");

            // Assert
            Assert.Null(res);
        }

    }
}
