using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Score
    {
        public static int ComputeScore (Dart dart)
        {
            if (dart.Bullseye)
                if (dart.InnerBullseye)
                {
                    return 50;
                }
                else
                    return 25;
            else
            {
                if (dart.DoubleBand)
                    return (2 * dart.BaseScore);
                else if (dart.TripleBand)
                    return (2 * dart.BaseScore);
                else
                    return dart.BaseScore;
            }
        }
    }
}