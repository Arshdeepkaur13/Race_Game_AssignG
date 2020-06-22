using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Game_AssignG
{
    public class ResultDeclare: racing
    {
        public int budgetSet(String data,int Budget,int winnerDog) {

            String []filter = data.Split(' ');

            if (Convert.ToInt32(filter[2]) == winnerDog)
            {
                return Budget + Convert.ToInt32(filter[5]);
            }
            else {
                return Budget - Convert.ToInt32(filter[5]);
            }
        }
    }
}
