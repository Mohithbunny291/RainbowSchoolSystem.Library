using RainbowSchoolSystem.Library;

namespace RainbowSchoolSystem.Tests
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void Student_Creation_Test()
        {
            // Arrange
            var stu = new Student { Id = 191, Name = "Karan" };

            
            Assert.AreEqual(191, stu.Id);
            Assert.AreEqual("Karan", stu.Name);
        }
    }
}