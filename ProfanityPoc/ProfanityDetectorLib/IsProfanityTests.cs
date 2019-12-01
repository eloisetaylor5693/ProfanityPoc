using NUnit.Framework;

namespace ProfanityPoc.ProfanityDetectorLib
{
    [TestFixture]
    public sealed class IsProfanityTests
    {
        [TestCase("hello")]
        [TestCase("Scunthorpe")]
        [TestCase("flowers")]
        public void GivenWordsWhichAreNotProfane_IsProfanity_IsFalse(string wordWhichIsNotProfane)
        {
            var sut = new ProfanityFilter.ProfanityFilter();
            var result = sut.IsProfanity(wordWhichIsNotProfane);

            Assert.That(result, Is.False);
        }

        [TestCase("shitface")]
        [TestCase("SHITFACE")]
        public void GivenProfanities_IsProfanity_IsTrue(string profanity)
        {
            var sut = new ProfanityFilter.ProfanityFilter();
            var result = sut.IsProfanity(profanity);

            Assert.That(result, Is.True);
        }

        [Test]
        public void GivenProfanityThatLibraryDoesNotRecognise_IsProfanity_IsFalse()
        {
            var sut = new ProfanityFilter.ProfanityFilter();
            var result = sut.IsProfanity("sh1tface");

            Assert.That(result, Is.False);
        }

        [Test]
        public void GivenPluralProfanity_IsProfanity_IsFalse()
        {
            var sut = new ProfanityFilter.ProfanityFilter();
            var result = sut.IsProfanity("shits");

            Assert.That(result, Is.True);
        }
    }
}