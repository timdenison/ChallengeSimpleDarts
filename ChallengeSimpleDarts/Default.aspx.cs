using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Darts;

namespace ChallengeSimpleDarts
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            Game game = new Game("Marcie", "Bob");
            while (game.player1.Score <300 && game.player2.Score <300)
                game.ThrowDarts();
            string winner;
            if (game.player1.Score > game.player2.Score)
            {
                winner = game.player1.Name;
            }
            else
            {
                winner = game.player2.Name;
            }
            
            resultLabel.Text = String.Format("{0}: {1} <br /> {2}: {3} <br /> {4} wins!", game.player1.Name, game.player1.Score,
                game.player2.Name, game.player2.Score, winner);
            
        }

        public class Game
        {
            Random _random = new Random();
            public Player player1;
            public Player player2;

            public Game(string player1Name, string player2Name)
            {
                this.player1 = new Player(player1Name);
                this.player2 = new Player(player2Name);
                this.player1.Name = player1Name;
                this.player2.Name = player2Name;
            }

            public void ThrowDarts()
            {
                for (int i = 1; i <= 6; i++)
                {
                    Dart dart = new Dart(_random);
                    if (i < 4)
                    {
                        dart.Throw();
                        this.player1.Score += Score.ComputeScore(dart);
                    }
                    else
                    {
                        dart.Throw();
                        this.player2.Score += Score.ComputeScore(dart);
                    }
                    
                }
            }

           

        }

    }
}