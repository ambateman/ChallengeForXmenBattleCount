using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Phoenix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            //First, find the min and max battles
            int maxBattles = numbers.Max();
            int minBattles = numbers.Min();

            int loserIndex = -1;  //Testing for >0 will let us break out if we can
            int winnerIndex = -1;  //Testing for >0 will let us break out if we can

            //Now scan for the winner and loser and return index
            for(int i = 0; i < names.Length; i++)
            {
                if (numbers[i] == maxBattles) winnerIndex = i;
                if (numbers[i] == minBattles) loserIndex = i;
                if (winnerIndex > 0 && loserIndex > 0) break;
            }


            resultLabel.Text = "Most battles belong to: " + names[winnerIndex].ToString() + " (Value: " + maxBattles.ToString() + ")<br/>";
            resultLabel.Text += "Least battles belong to: " + names[loserIndex].ToString() + " (Value: " + minBattles.ToString() + ")<br/>";

        }
    }
}