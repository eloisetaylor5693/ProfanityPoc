using NUnit.Framework;

namespace ProfanityPoc
{
    public class ProfanityDetectorTests
    {
        [TestCase("hello")]
        [TestCase("Scunthorpe")]
        [TestCase("flowers")]
        public void GivenWordsWhichAreNotProfane_IsProfanity_IsFalse(string wordWhichIsNotProfane)
        {
            var filter = new ProfanityFilter.ProfanityFilter();
            var result = filter.IsProfanity(wordWhichIsNotProfane);
            Assert.That(result, Is.False);
        }

        [TestCase("shitface")]
        [TestCase("SHITFACE")]
        public void GivenProfanities_IsProfanity_IsTrue(string profanity)
        {
            var filter = new ProfanityFilter.ProfanityFilter();
            var result = filter.IsProfanity(profanity);
            Assert.That(result, Is.True);
        }

        [Test]
        public void GivenProfanityThatLibraryDoesNotRecognise_IsProfanity_IsFalse()
        {
            var filter = new ProfanityFilter.ProfanityFilter();
            var result = filter.IsProfanity("sh1tface");
            Assert.That(result, Is.False);
        }

        [Test]
        public void GivenPluralProfanity_IsProfanity_IsFalse()
        {
            var filter = new ProfanityFilter.ProfanityFilter();
            var result = filter.IsProfanity("shits");
            Assert.That(result, Is.True);
        }
    }
}