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
            string mess = "Iam In Sad Mood";
            string expected = "Sad";
            //Object
            Mood mood = new Mood(mess);
            //Act
            string result = mood.Moodchecking();
            //Assert 
            Assert.AreEqual(expected, result);
        }
        [Test]
        //Returns Happy
        public void Mood_Should_be_happy()
        {
            string mess = "Iam in Happy Mood";
            string expected = "Happy";
            //Object
            Mood mood = new Mood(mess);
            //Act
            string result = mood.Moodchecking();
            //Assert 
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Its_Returns_only_happyMood()
        {
            string mess = " ";
            string expected = "Happy";
            Mood mood = new Mood(mess);
            string result = mood.Moodchecking();
            Assert.AreEqual(expected, result);
        }
    }
}