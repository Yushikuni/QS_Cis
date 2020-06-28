using System;
using System.Collections.Generic;
using System.Text;

namespace QuestSystem_Cis
{
    public class Kill : Quest
    {
        protected int sumOfKill = -1;
        Kill(string typ, bool mainQuest, bool activeQuest, int sumOfKill):base(typ, mainQuest, activeQuest)
        {
            typ = this.s;
            mainQuest = this.mainQuest;
            activeQuest = this.activeQuest;
            this.sumOfKill = sumOfKill;
        }
        protected bool Rampage(int sumOfKill, int acuallyKill)
        {
            if(sumOfKill == acuallyKill)
            {
                return true;
            }
            return false;
        }

    }
}
