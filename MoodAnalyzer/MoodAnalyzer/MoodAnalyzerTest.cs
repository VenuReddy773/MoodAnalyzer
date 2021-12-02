using System;

namespace MoodAnalyzer
{
    public class MoodAnalyzerTest
    {
        string message;
        public MoodAnalyzerTest(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.Contains("Happy"))
                    return "Happy";
                else
                    return "Sad";
            }
            catch (NullReferenceException)
            {
                return "Happy";
            }
        }
    }
}
