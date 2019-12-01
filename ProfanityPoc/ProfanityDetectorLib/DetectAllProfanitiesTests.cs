using NUnit.Framework;

namespace ProfanityPoc.ProfanityDetectorLib
{
    [TestFixture]
    public sealed class DetectAllProfanitiesTests
    {
        [Test]
        public void GivenSentenceWithProfanity_DetectAllProfanities_FlagsProfanities()
        {
            var filter = new ProfanityFilter.ProfanityFilter();
            var result = filter.DetectAllProfanities("0 shits given");

            Assert.That(result, Contains.Item("shits"));
        }
    }
}
