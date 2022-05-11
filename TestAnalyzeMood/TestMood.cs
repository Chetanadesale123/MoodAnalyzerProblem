using MoodAnalyzerProblem;
using NUnit.Framework;

namespace TestAnalyzeMood
{
    public class TestMood
    {
        [Test]
        public void GivenStringInput_WhenTestAnalyzeMood_shouldReturnSad()
        {
            MoodAnalyzer mood = new MoodAnalyzer("I am in a sad mood");
            string result = mood.AnalyseMethod();
            Assert.AreEqual(result, "sad");
        }
        [Test]
        public void GivenStringInput_WhenTestAnalyzeMood_shouldReturnHappy()
        {
            MoodAnalyzer mood = new MoodAnalyzer("I am in a happy mood");
            string result = mood.AnalyseMethod();
            Assert.AreEqual(result, "happy");
        }
        [Test]
        public void GivenNullInput_WhenTestAnalyzeMood_shouldReturnHappy()
        {
            try
            {
                MoodAnalyzer mood = new MoodAnalyzer(null);
                string result = mood.AnalyseMethodInvalidInput();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(ex.Message, "message is null");
            }
        }
        [Test]
        public void GivenEmptyInput_WhenTestAnalyzeMood_shouldReturnHappy()
        {
            try
            {
                MoodAnalyzer mood = new MoodAnalyzer("");
                string result = mood.AnalyseMethodInvalidInput();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(ex.Message, "message is Empty");
            }
        }
    }
}
