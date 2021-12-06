using MoodAnalyzer;
using NUnit.Framework;

namespace MoodAnalyzerTesting
{
    public class Tests
    {
        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            MoodAnalyzerTest mood = new MoodAnalyzerTest("I am in Sad Mood");
            string result = mood.AnalyzeMood();
            Assert.AreEqual(result, "Sad");
        }
        [Test]
        public void GivenHappyMessage_WhenAnalyze_ShouldReturnHappy()
        {
            MoodAnalyzerTest mood = new MoodAnalyzerTest("I am in Happy Mood");
            string result = mood.AnalyzeMood();
            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenNullMessage_WhenAnalyze_ShouldReturnException()
        {
            MoodAnalyzerTest mood = new MoodAnalyzerTest("I am in Any mood");
            string actual = mood.AnalyzeMood();
            Assert.AreEqual(actual, "Happy");
        }
        [Test]
        public void GivenNullMood_WhenAnalyze_ShouldReturnException()
        {
            string expected = "Mood should not be null";
            try
            {
                MoodAnalyzerTest mood = new MoodAnalyzerTest(null);
                string actual = mood.AnalyzeMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [Test]
        public void GivenEmptyMood_WhenAnalyze_ShouldReturnException()
        {
            string expected = "Mood should not be empty";
            try
            {
                MoodAnalyzerTest moodAnalyser = new MoodAnalyzerTest("");
                string actual = moodAnalyser.AnalyzeMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}