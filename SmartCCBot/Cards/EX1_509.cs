using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Murloc Tidecaller
namespace HREngine.Bots
{
    [Serializable]
public class EX1_509 : Card
    {
		public EX1_509() : base()
        {
            
        }
		 
        public EX1_509(CardTemplate newTemplate, bool isFriend, int id) : base(newTemplate,isFriend,id)
        {
            
        }

        public override void Init()
        {
            base.Init();
        }
       

        public override void OnPlay(ref Board board, Card target = null,int index = 0,int choice = 0)
        {
            base.OnPlay(ref board, target,index);
        }

        public override void OnDeath(ref Board board)
        {
            base.OnDeath(ref board);
        }

        public override void OnPlayOtherMinion(ref Board board, Card Minion)
        {
            base.OnPlayOtherMinion(ref board, Minion);

            if(Minion != null)
            {
                if (Minion.Race == CRace.MURLOC)
                    board.GetCard(Id).currentAtk++;
            }
            
        }

        public override void OnCastSpell(ref Board board, Card Spell)
        {
		    base.OnCastSpell(ref board, Spell);
        }
		
    }
}
