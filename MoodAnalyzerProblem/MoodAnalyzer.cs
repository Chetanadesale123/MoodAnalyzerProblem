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
                if (message.ToLower().Contains("null"))
                {
                    return "sad";
                }
                return "happy";

            }
            catch (Exception ex)
            {
                return "Happy";
            }
        }
    }
}