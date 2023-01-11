using Perseus.Core.Extensions;

namespace Perseus.Core.Tests
{
    public class ObjectExtensionsTests
    {
        [Test]
        public void ObjectIsNotNull()
        {
            object? obj1 = null;
            object? obj2 = "Hello!";

            Assert.Throws<ArgumentNullException>(() =>
            {
                obj1.NotNull();
            });

            Assert.DoesNotThrow(() =>
            {
                obj2.NotNull();
            });
        }
    }
}
