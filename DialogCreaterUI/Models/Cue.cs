using System;
using System.Collections.Generic;
using System.Text;

namespace DialogCreaterUI.Models
{
    public class Cue
    {
        public string npc_phrase { get; private set; }
        public string[] answers { get; private set; }

        public Cue()
        {
            answers = new string[6];
        }
    }
}
