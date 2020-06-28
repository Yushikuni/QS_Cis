using System;
using System.Collections.Generic;
using System.Text;

namespace QuestSystem_Cis
{
    public class Quest
    {
        ///<summary>
        ///included: 
        ///             Main / side quests
        ///             Type             
        /// </summary>
        protected string s = " ";
        protected bool mainQuest = false;
        protected bool activeQuest = false;

        protected Quest(string typ, bool mainQuest, bool activeQuest)
        {
            s = typ;
            this.mainQuest = mainQuest;
            this.activeQuest = activeQuest;
        }
    }
}
