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
    {/// <summary>
    /// Variables
    /// </summary>
        private string Message;
        /// <summary>
        /// Constructer 
        /// </summary>
        /// <param name="mess"></param>
        public Mood(string mess)
        {
            //declaring GlobalValue
            Message = mess;
        }
        /// <summary>
        /// Method to show Mood
        /// </summary>
        /// <returns></returns>
        public string Analysemood()
        {
            try
            {

                if (Message.Contains("sad"))
                    return "sad";
                else
                    return "Happy";
            }
            catch
            { return "Happy";
            }
        }


    }
}
