using RainbowSchoolSystem.Library;

namespace RainbowSchoolSystem.Tests
{
    [TestFixture]
    public class TeacherTests
    {
        [Test]
        public void Teacher_Creation_Test()
        {
            // Arrange
            var teacher = new Teacher { Id = 1, Name = "John Doe", Subject = "Mathematics" };

            
            Assert.AreEqual(1, teacher.Id);
            Assert.AreEqual("John Doe", teacher.Name);
            Assert.AreEqual("Mathematics", teacher.Subject);
        }
    }
}