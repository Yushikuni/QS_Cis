using System;
using System.Collections.Generic;
using System.Text;

namespace QuestSystem_Cis
{
    public class Gather:Quest
    {
        protected int sumOfGather = -1;
        Gather(string typ, bool mainQuest, bool activeQuest, int sumGether) : base(typ, mainQuest, activeQuest)
        {
            typ = this.s;
            mainQuest = this.mainQuest;
            activeQuest = this.activeQuest;
            sumOfGather = sumGether;
        }
        protected bool GatherComplete(int sumOfGather, int acuallySum)
        {
            if(sumOfGather == acuallySum)
            {
                return true;
            }
            return false;
        }
    }

}
