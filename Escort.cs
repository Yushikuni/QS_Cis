using System;
using System.Collections.Generic;
using System.Text;

namespace QuestSystem_Cis
{
    public class Escort : Quest
    {
        protected bool endEscort = true;
        Escort(string typ, bool mainQuest, bool activeQuest, bool endEscort):base(typ, mainQuest, activeQuest)
        {
            typ = this.s;
            mainQuest = this.mainQuest;
            activeQuest = this.activeQuest;
            this.endEscort = endEscort;
        }
        protected bool EndOfEscort(bool endEscort)
        {
            if(endEscort)
            {
                return true;
            }
            return false;
        }
    }
}
