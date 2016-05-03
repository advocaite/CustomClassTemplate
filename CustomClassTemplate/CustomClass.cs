using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZzukBot.Engines.CustomClass;

namespace CustomClassTemplate
{
    class advo : CustomClass
    {
        public override string CustomClassName
        {
            get
            {
                //keep this the same as the name you want class to be called
                return "advo";
            }
        }

        public override byte DesignedForClass
        {
            get
            {
                //return PlayerClass.Druid;
                //return PlayerClass.Hunter;
                //return PlayerClass.Mage;
                //return PlayerClass.Paladin;
                //return PlayerClass.Priest;
                //return PlayerClass.Rogue;
                return PlayerClass.Shaman;
                //return PlayerClass.Warlock;
                //return PlayerClass.Warrior;
            }
        }

        public override void Rest() 
        {
            //do something while rest conditin is active

        }
       
        public override bool Buff()
        {
            //do something while buff conditin is active or just return true.
            return true;
        }
        
        public override void PreFight()
        {
            //do something while prefight conditin is active
        }
      
         public override void Fight()
        {
            //do something while Fight conditin is active
        }

    }
    
       
}
