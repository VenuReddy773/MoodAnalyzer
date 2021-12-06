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
                if (message == null)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.Null, "Mood should not be null");
                }
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.Empty, "Mood should not be empty");
                }
                if (message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (NullReferenceException) 
            {
                return "Happy";
            }
        }
    }
}
