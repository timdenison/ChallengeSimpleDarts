using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        public Random random;
        public bool DoubleBand;
        public bool TripleBand;
        public bool InnerBullseye;
        public bool Bullseye;
        public int BaseScore;

        
        public Dart (Random _random)
        {
            random = _random;
            DoubleBand = false;
            TripleBand = false;
            InnerBullseye = false;
            Bullseye = false;
        }

        public void Throw()
        {
            this.BaseScore = random.Next(0,21);
            if (BaseScore == 0)
            {
                this.Bullseye = true;
                if (random.Next(1, 21) == 1)
                {
                    this.InnerBullseye = true;
                    this.BaseScore = 50;
                }
                else this.BaseScore = 25;             
            }
            else
            {
                int bonus = random.Next(1,21);
                if (bonus == 1)
                    this.DoubleBand = true;
                else if (bonus == 2)
                    this.TripleBand = true;
            }
        }
    }
}
