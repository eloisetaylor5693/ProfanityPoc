using NUnit.Framework;

namespace ProfanityPoc.ProfanityDetectorLib
{
    [TestFixture]
    public sealed class CensorStringTests
    {
        [Test]
        public void GivenSentenceWithProfanity_DetectAllProfanities_FlagsProfanities()
        {
            var sut = new ProfanityFilter.ProfanityFilter();
            var result = sut.CensorString("0 shits given");

            Assert.That(result, Is.EqualTo("0 ***** given"));
        }
    }
}
