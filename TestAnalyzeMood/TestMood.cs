using MoodAnalyzerProblem;
using NUnit.Framework;

namespace TestAnalyzeMood
{
    public class TestMood
    {
        [Test]
        public void GivenStringInput_WhenTestAnalyzeMood_shouldReturnSad()
        {
            MoodAnalyzer mood = new MoodAnalyzer();
            string result = mood.AnalyseMethod("I am in a sad mood");
            Assert.AreEqual(result, "sad");
        }
        [Test]
        public void GivenStringInput_WhenTestAnalyzeMood_shouldReturnHappy()
        {
            MoodAnalyzer mood = new MoodAnalyzer();
            string result = mood.AnalyseMethod("I am in a happy mood");
            Assert.AreEqual(result, "happy");
        }
    }
}