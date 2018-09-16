using StudentMinMax;
using Xunit;

namespace Test
{
    public class StudentTest
    {
        [Fact]
        public void GetMaximumScore_ReturnValue()
        {
            var student = new Student { Scores = new int[] { 1, 2, 3, 4, 5 } };
            Assert.Equal(5, student.GetMaximumScore());
        }

        [Fact]
        public void GetMinimumScore_ReturnValue()
        {
            var student = new Student { Scores = new int[] { 1, 2, 3, 4, 5 } };
            Assert.Equal(1, student.GetMinimumScore());
        }
    }
}