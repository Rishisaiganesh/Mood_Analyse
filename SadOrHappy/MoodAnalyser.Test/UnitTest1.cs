using NUnit.Framework;
using SadOrHappy;

namespace MoodAnalyser.Test
{
    public class Tests
    {

        [Test]
        //Returns Sad
        public void Mood_should_Be_Sad()
        {
            string expected = "Sad";
            //Object
            Mood mood = new Mood("mess");
            //Act
            string result = mood.Moodchecking();
            //Assert 
            Assert.AreEqual(expected, result);
        }
        [Test]
        //Returns Happy
        public void Mood_Should_be_happy()
        {
            string expected = "Happy";
            //Object
            Mood mood = new Mood("mess");
            //Act
            string result = mood.Moodchecking();
            //Assert 
            Assert.AreEqual(expected, result);
        }
    }
}