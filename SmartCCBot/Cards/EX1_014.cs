using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//King Mukla
namespace HREngine.Bots
{
    [Serializable]
public class EX1_014 : Card
    {
		public EX1_014() : base()
        {
            
        }
		
        public EX1_014(CardTemplate newTemplate, bool isFriend, int id) : base(newTemplate,isFriend,id)
        {
            
        }

        public override void Init()
        {
            base.Init();
        }

        public override void OnPlay(ref Board board, Card target = null,int index = 0,int choice = 0)
        {
            base.OnPlay(ref board, target,index);
            board.EnemyCardDraw += 2;
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
