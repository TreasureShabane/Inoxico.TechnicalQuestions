
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionTwo
    {
        public static int GetPitDepth(int[] points)
        {
			try
			{
                var N = points.Length;
                var depth = -1;
                var i = 0;

                if(N < 3) {
                    return depth; 
                }
			}
			catch (Exception)
			{
                throw new NotImplementedException();
            }
        }
    }
}
