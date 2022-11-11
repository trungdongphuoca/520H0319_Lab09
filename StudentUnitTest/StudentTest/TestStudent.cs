using StudentServiceLib;

namespace StudentTest
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void WhenScore8()
        {
            Student student = new Student();

            student.Score = 8;

            Assert.AreEqual(8, student.Score);
        }

        public void WhenScore11()
        {
            Student student = new Student();

            student.Score = 11;

            Assert.AreEqual(11, student.Score);
        }
        public void WhenScoreMinus10()
        {
            Student student = new Student();

            student.Score = -11;

            Assert.AreEqual(-11, student.Score);
        }
    }
}