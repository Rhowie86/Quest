using System;
using System.Collections.Generic;

namespace Quest
{
    public class Hat
    {

        public int ShininessLevel { get; set; }

        public string ShininessDescription
        {
            get
            {
                if (ShininessLevel <= 2)
                {
                    return "This hat is really dull man, you look like crap.";
                }
                else if (ShininessLevel <= 5)
                {
                    return "This hat is noticable, but it still sort of sucks.";
                }
                else if (ShininessLevel <= 9)
                {
                    return "Hey that hat is pretty bright, lookin' good.";
                }
                else if (ShininessLevel > 9)
                {
                    return "Holy smokes that hat is blindingly bright. I dig your style.";
                }
                else
                {
                    return "Where is your hat dummy?";
                }
            }
        }

    }
}