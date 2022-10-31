using ContosoCrafts.WebSite.Pages.Restaurants;
using NUnit.Framework;
using System.Linq;

namespace UnitTests.Pages.Restaurants
{
    /// <summary>
    /// Unit tests for the IndexModel class
    /// </summary>
    public class IndexTests
    {
        #region TestSetup

        public static IndexModel pageModel;

        [SetUp]
        public void TestInitialize()
        {
            pageModel = new IndexModel(TestHelper.ProductService)
            {
            };
        }

        #endregion TestSetup

        #region OnGet
        [Test]
        public void OnGet_Should_Retrieve_All_Products()
        {
            // Arrange
            var data = TestHelper.ProductService.GetAllData().Count();
            // Act
            pageModel.OnGet();
      
            // Assert
            Assert.AreEqual(true, pageModel.ModelState.IsValid);
            Assert.AreEqual(data, pageModel.Products.Count());
        }
        #endregion OnGet
    }
}
