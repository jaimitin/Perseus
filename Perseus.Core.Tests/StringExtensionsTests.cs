using Perseus.Core.Extensions;

namespace Perseus.Core.Tests
{
    public class StringExtensionsTests
    {
        private readonly string? sEmpty = string.Empty;
        private readonly string? sNull = null;
        private readonly string? sWhiteSpace = " ";
        private readonly string? sContent = "Hello!";

        [Test]
        public void StringIsNullOrEmpty()
        {
            Assert.Multiple(() =>
            {
                Assert.That(sEmpty.IsNullOrEmpty(), Is.True);
                Assert.That(sNull.IsNullOrEmpty(), Is.True);
                Assert.That(sWhiteSpace.IsNullOrEmpty(), Is.False);
                Assert.That(sContent.IsNullOrEmpty(), Is.False);
            });
        }

        [Test]
        public void StringIsNullOrWhiteSpace()
        {
            Assert.Multiple(() =>
            {
                Assert.That(sEmpty.IsNullOrWhiteSpace(), Is.True);
                Assert.That(sNull.IsNullOrWhiteSpace(), Is.True);
                Assert.That(sWhiteSpace.IsNullOrWhiteSpace(), Is.True);
                Assert.That(sContent.IsNullOrWhiteSpace(), Is.False);
            });
        }
    }
}