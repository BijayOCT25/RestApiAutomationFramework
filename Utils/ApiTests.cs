using NUnit.Framework;
using RestApiAutomationFramework.Utils;
using System.Net;

namespace RestApiAutomationFramework.Tests
{
    [TestFixture]
    public class ApiTests
    {
        private string _baseUrl;
        private HttpClientHelper _httpClient;

        [SetUp]
        public void Setup()
        {
            // Read base URL from JSON config
            _baseUrl = JsonDataReader.ReadFromFile<string>("TestData/TestData.json");
            _httpClient = new HttpClientHelper();
        }

        [Test]
        public async Task GetPosts_ReturnsSuccess()
        {
            // Arrange
            string url = $"{_baseUrl}/posts";

            // Act
            var response = await _httpClient.GetAsync(url);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [Test]
        public async Task GetComments_ReturnsSuccess()
        {
            // Arrange
            string url = $"{_baseUrl}/comments";

            // Act
            var response = await _httpClient.GetAsync(url);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
