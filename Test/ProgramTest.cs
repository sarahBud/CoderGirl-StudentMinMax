using StudentMinMax;
using System;
using System.IO;
using Xunit;

namespace Test
{
    public class ProgramTest
    {
        [Fact]
        public void Main_Bill()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(Environment.NewLine))
                {
                    Console.SetIn(sr);

                    Program.Main();
                }

                var result = sw.ToString().Split(Environment.NewLine);

                Assert.EndsWith("bill Min: 16 Max: 23", result[1]);
            }
        }

        [Fact]
        public void Main_Grace()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(Environment.NewLine))
                {
                    Console.SetIn(sr);

                    Program.Main();
                }

                var result = sw.ToString().Split(Environment.NewLine);

                Assert.EndsWith("grace Min: 10 Max: 45", result[3]);
            }
        }

        [Fact]
        public void Main_Joe()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(Environment.NewLine))
                {
                    Console.SetIn(sr);

                    Program.Main();
                }

                var result = sw.ToString().Split(Environment.NewLine);

                Assert.EndsWith("joe Min: 10 Max: 40", result[0]);
            }
        }

        [Fact]
        public void Main_John()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(Environment.NewLine))
                {
                    Console.SetIn(sr);

                    Program.Main();
                }

                var result = sw.ToString().Split(Environment.NewLine);

                Assert.EndsWith("john Min: 14 Max: 89", result[4]);
            }
        }

        [Fact]
        public void Main_Sue()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(Environment.NewLine))
                {
                    Console.SetIn(sr);

                    Program.Main();
                }

                var result = sw.ToString().Split(Environment.NewLine);

                Assert.EndsWith("sue Min: 2 Max: 32", result[2]);
            }
        }
    }
}