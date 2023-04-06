using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethodEqualAsync()
        {
                var client = new HttpClient();
                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com/posts"))
                using (HttpResponseMessage response = client.SendAsync(request).Result)
                {
                    Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                }
         }

        [TestMethod]
        public async Task TestMethodTrueAsync()
        {
            var client = new HttpClient();
            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com/posts/1"))
            using (HttpResponseMessage response = client.SendAsync(request).Result)
            {
                Assert.IsTrue(response.IsSuccessStatusCode);                
            }
        }

        //[TestMethod]
        //public async Task TestMethodNegativeAsync()
        //{
        //    var client = new HttpClient();
        //    using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholde.tyicode.com/posts"))
        //    using (HttpResponseMessage response = client.SendAsync(request).Result)
        //    {
        //        Assert.IsFalse(!response.IsSuccessStatusCode);
        //    }
        //}       
    }
}
