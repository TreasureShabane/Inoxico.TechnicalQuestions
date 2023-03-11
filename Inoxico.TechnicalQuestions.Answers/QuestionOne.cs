
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionOne
    {
        public static int GetLongestSentance(string s)
        {
            try
            {
                int highest = 0;
                List<string> words = s.Split(".").ToList<string>();
                foreach (string item in words)
                {
                    if(item.Split(" ").Length > highest)
                    {
                        highest = item.Split(" ").Length;
                    }
                }

                return highest;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}




