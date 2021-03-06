using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Mind Control
namespace HREngine.Bots
{
    [Serializable]
public class CS1_113 : Card
    {
		public CS1_113() : base()
        {
            
        }
		
        public CS1_113(CardTemplate newTemplate, bool isFriend, int id) : base(newTemplate,isFriend,id)
        {
            
        }

        public override void Init()
        {
            base.Init();
            TargetTypeOnPlay = TargetType.MINION_ENEMY;
        }

        public override void OnPlay(ref Board board, Card target = null,int index = 0,int choice = 0)
        {
            base.OnPlay(ref board, target,index);
            if(target != null)
            {
                board.MinionEnemy.Remove(target);
                board.MinionFriend.Add(target);
                board.Resimulate();

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
