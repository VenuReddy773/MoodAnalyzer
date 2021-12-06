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
        [Test]
        public void GivenMoodAnalyzerReflection_WhenAnalyze_ShouldReturnObject()
        {
            object expected = new MoodAnalyzerTest();
            object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerTesting.MoodAnalyzerTest", "MoodAnalyzerTest");
            expected.Equals(actual);
        }
        [Test]
        public void GivenImproperClassName_WhenAnalyze_ShouldReturnMoodAnalyzerException()
        {
            string expected = "Class not found";
            try
            {
                object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerTesting.MoodAnalyzerTest", "MoodAnalyzerTest");
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
        [Test]
        public void GivenImproperConstructorName_WhenAnalyze_ShouldReturnMoodAnalyzerException()
        {
            string expected = "Constructor not found";
            try
            {
                object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerTesting.MoodAnalyzerTest", "MoodAnalyzerTest");
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}