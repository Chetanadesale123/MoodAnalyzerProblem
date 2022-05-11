namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyseMethod()
        {
            if (message.ToLower().Contains("sad"))
            {
                return "sad";
            }
            return "happy";
        }
        public string AnalyseMethodInvalidInput()
        {
            try
            {
                if (message == null)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MOOD, "Message is Null");
                }
                if (message.Equals(""))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MOOD, "Message is Empty");
                }
                if (message.ToLower().Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch (MoodAnalysisException ex)
            {
                return ex.Message;
            }
        }
    }
}

