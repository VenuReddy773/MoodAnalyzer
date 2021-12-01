using MoodAnalyzer;
using NUnit.Framework;

namespace MoodAnalyzerTesting
{
    public class Tests
    {
        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
           // string message="I am in Sad Mood";
            MoodAnalyzerTest mood = new MoodAnalyzerTest("I am in Sad Mood");
            string result=mood.AnalyzeMood();
            Assert.AreEqual(result,"Sad");
        }
        [Test]
        public void GivenHappyMessage_WhenAnalyze_ShouldReturnHappy()
        {
            //string message = "I am in Happy Mood";
            MoodAnalyzerTest mood = new MoodAnalyzerTest("I am in Happy Mood");
            string result = mood.AnalyzeMood();
            Assert.AreEqual(result, "Happy");
        }
    }
}