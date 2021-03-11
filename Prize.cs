using System;
using System.Collections.Generic;

namespace Quest
{
    public class Prize
    {

        private string _text { get; set; }

        public Prize(string prizeName)
        {
            _text = prizeName;
        }

        public string ShowPrize(Adventurer person)
        {
            if (person.Awesomeness <= 0)
            {
                return "Oh boy, you are pretty bad at this...maybe you should give up.";
            }
            else if (person.Awesomeness > 1)
            {
                return $"Hey you survided. Your prize is your pride, and also a {_text}";
            }
            else
            {
                return "";
            }
        }
    }
}