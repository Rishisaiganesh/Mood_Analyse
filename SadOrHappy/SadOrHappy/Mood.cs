using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SadOrHappy
{/// <summary>
/// Public Mood Analyser
/// </summary>
    public class Mood
    {
        public const string Sadmood = "Iam In sad Mood";
        public const string Happymood = "Iam in Happy Mood";
        public string mess;
        public Mood(string message)
        {
            this.mess = message;
        }
        public string Moodchecking()
        {
            try
            {
                if (mess == null || mess == string.Empty)
                    throw new Exception();
                if (mess == Sadmood)
                    return "Sad";
                if (mess == Happymood)
                    return "Happy";
            }
            catch (Exception)
            {
                return "Happy";
            }
            return null;
                
           
        }
    }
} 
