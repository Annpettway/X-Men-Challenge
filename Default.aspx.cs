using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace X_Men_Challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Wolverine fewest Battles
            //Phoenix most Battles


            String[] names = new string[] {"Professor X", "Iceman", "Angel", "Beast", "Phoenix",
            "Cyclops", "Woverine", "Nightcrawler", "Storm", "Colossus"};

            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            for (int i = 0; i < numbers.Length; i++)

            {
                if (numbers[i] == numbers.Max())
                {
                    result += String.Format("Most Battles belong to: {0} (Value: {1})<br/>", names[i], numbers[i]);
                }

                if (numbers[i] == numbers.Min())
                {

                    result += String.Format("Least Battles belong to: {0} (Value: {1})<br/>", names[i], numbers[i]);
                }

            }

            resultLabel.Text = result;
                
        }

            
    }
}
