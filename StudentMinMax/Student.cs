using System.IO;
using System.Text;

namespace StudentMinMax
{
    public class Student
    {
        public string Name { get; set; }

        public int[] Scores { get; set; }

        public int? GetMaximumScore()
        {
            int maxScore = Scores[0];


            foreach (string student in File.ReadAllLines(@"studentdata.txt"))
            {

                for (int i = 0; i < Scores.Length; i++)
                {

                    if (maxScore > Scores[i]) maxScore = Scores[i];
                    {

                    }

                }
            }

            return maxScore;
        }

        public int? GetMinimumScore()
        {
            int minScore = Scores[0];
            for (int i = 0; i < Scores.Length; i++)
            {
                if (minScore < Scores[i]) minScore = Scores[i];
                {

                }
            }
            return minScore;
        }
    }
}