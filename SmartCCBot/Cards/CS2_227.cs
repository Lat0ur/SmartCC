using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Venture Co. Mercenary
namespace HREngine.Bots
{
    [Serializable]
public class CS2_227 : Card
    {
		public CS2_227() : base()
        {
            
        }
		
        public CS2_227(CardTemplate newTemplate, bool isFriend, int id) : base(newTemplate,isFriend,id)
        {
            
        }

        public override void Init()
        {
            base.Init();
        }

        public override void OnPlay(ref Board board, Card target = null,int index = 0,int choice = 0)
        {
            base.OnPlay(ref board, target,index);
            foreach(Card c in board.Hand)
            {
                if(c.Type == CType.MINION)
                {
                    c.CurrentCost += 3;
                }
            }
        }

        public override void OnDeath(ref Board board)
        {
            base.OnDeath(ref board);
        }

        public override void OnPlayOtherMinion(ref Board board, Card Minion)
        {
            base.OnPlayOtherMinion(ref board, Minion);
        }

        public override void OnCastSpell(ref Board board, Card Spell)
        {
		    base.OnCastSpell(ref board, Spell);
        }
		
    }
}
