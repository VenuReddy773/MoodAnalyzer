using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyzerException:Exception 
    {
        public readonly ExceptionType type;
        public MoodAnalyzerException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }   
        public enum ExceptionType
        {
            Null, Empty, NO_SUCH_CLASS, NO_SUCH_CONSTRUCTOR, NO_SUCH_METHOD
        }
    }
}
