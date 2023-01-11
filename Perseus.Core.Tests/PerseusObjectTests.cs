namespace Perseus.Core.Tests
{
    public class PerseusObjectTests
    {
        [Test]
        public void PerseusObjectEquals()
        {
            PerseusObject obj1 = new();
            PerseusObject obj2 = new();

            Assert.Multiple(() =>
            {
                Assert.That(obj1.ID, Is.Not.EqualTo(obj2.ID));
                Assert.That(obj1, Is.Not.EqualTo(obj2));
            });
        }

        [Test]
        public void PerseusObjectInstanceCount()
        {
            int count = PerseusObject.Instances;

            _ = new PerseusObject();
            _ = new PerseusObject();

            Assert.That(PerseusObject.Instances, Is.EqualTo(count + 2));
        }
    }
}
