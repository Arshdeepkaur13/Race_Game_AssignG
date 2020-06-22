using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Game_AssignG
{
    public class racing
    {
        //generate the random to move step
        Random rd = new Random();
        public int jumpStep() {
            return rd.Next(1, 35);
        }
    }
}
