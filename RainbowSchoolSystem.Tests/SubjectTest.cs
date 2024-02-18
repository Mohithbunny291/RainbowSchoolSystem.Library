using RainbowSchoolSystem.Library;

namespace RainbowSchoolSystem.Tests
{
    [TestFixture]
    public class SubjectTest
    {
        [Test]
        public void Subject_Creation_Test()
        {
            // Arrange
            var subject = new Subject { Id = 101, Name = "Java"};

            
            Assert.AreEqual(101, subject.Id);
            Assert.AreEqual("Java", subject.Name);
        }
    }
}