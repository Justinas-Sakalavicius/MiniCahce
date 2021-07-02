using Xunit;
using ConsoleApp6;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void GetItemExpectNull()
        {
            var cache = new Cache();
            string testKey = "1";

            var result = cache.GetItem(testKey);

            Assert.Null(result);
        }

        [Fact]
        public void GetItemExpectValue()
        {
            var cache = new Cache();
            string testKey = "1";
            var value = 2;
            cache.AddItem(testKey, value);

            var result = cache.GetItem(testKey);

            Assert.Equal(value, result);
        }
    }
}
