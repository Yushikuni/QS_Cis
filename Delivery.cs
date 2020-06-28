using System;
using System.Collections.Generic;
using System.Text;

namespace QuestSystem_Cis
{
    public class Delivery : Quest
    {
        protected string nameThing = " ";
        protected bool sthToDeliv = false;
        Delivery(string typ, bool mainQuest, bool activeQuest, string nameThing, bool sthToDeliv) : base(typ, mainQuest,activeQuest)
        {
            typ = base.s;
            mainQuest = this.mainQuest;
            activeQuest = this.activeQuest;
            this.nameThing = nameThing;
            this.sthToDeliv = sthToDeliv;
        }

        protected bool deliveryComplete(bool sthToDeliv)
        {
            if(!sthToDeliv)
            {
                return true;
            }
            return false;
        }
    }
}
