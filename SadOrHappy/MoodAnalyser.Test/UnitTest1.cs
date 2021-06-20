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
            //Sring Message
            string expected = "sad";
            //Object
            Mood mood = new Mood("sad");
            //Assert 
            Assert.AreEqual(expected, mood.Analysemood());
        }
        [Test]
        //Returns Happy
        public void Mood_Should_be_happy()
        {
            //String Mesage
            string expected = "Happy";
            //Creating Object
            Mood obj = new Mood("Happy");
            //Assert
            Assert.AreEqual(expected, obj.Analysemood());
        }
        [Test]
        //Mood Should Return Only Happy
        public void Should_Return_Happy()
        {
            // Expected Only happy
            string expected = "Happy";
            //Creating An Object
            Mood happy = new Mood(null);
            //Assert 
            Assert.AreEqual(expected, happy.Analysemood());
        }
    }
}