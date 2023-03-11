
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionTwo
    {
        public static int GetPitDepth(int[] points)
        {
			try
			{
                var n = points.Length;
                var depth = -1;
                var i = 0;
                var j = 0;
                var k = 0;
                var p = 0;
                var q = 0;
                var r = 0;

                if (n < 3) {
                    return depth; 
                }

                while (i < n - 2)
                {
                    p = points[i];
                    j = i + 1;

                    while (points[j] < points[j - 1] && j < n - 1)
                    {
                        j++;
                    }

                    if (j == i + 1)
                    {
                        i++;
                    }

                }
			}
			catch (Exception)
			{
                throw new NotImplementedException();
            }
        }
    }
}
