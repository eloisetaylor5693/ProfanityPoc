using NUnit.Framework;

namespace ProfanityPoc.ProfanityDetectorLib
{
    [TestFixture]
    public sealed class DetectAllProfanitiesTests
    {
        [Test]
        public void GivenSentenceWithProfanity_DetectAllProfanities_FlagsProfanities()
        {
            var sut = new ProfanityFilter.ProfanityFilter();
            var result = sut.DetectAllProfanities("0 shits given");

            Assert.That(result, Contains.Item("shits"));
        }
    }
}
