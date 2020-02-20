using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator_1
{
    public partial class Form1 : Form
    {
        // Declaring and initializing the scoreTotal and scoreCount variables
        int scoreTotal = 0;
        int scoreCount = 0;
        public Form1()
        {

            InitializeComponent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /* Add the scores entered by the user and
             * calculate the total score and average and start to count the number of scores entered,
             * and display the result every time when the user enters a score */
            string scoreString = txtScore.Text;
            int score = Int32.Parse(scoreString);

            scoreTotal += score;
            scoreCount++;
            double average = scoreTotal / scoreCount;

             //average = Math.Round((average), 1);

            txtScoreTotal.Text = scoreTotal.ToString();
            txtScoreCount.Text = scoreCount.ToString();
            txtAverage.Text = average.ToString();

            txtScore.Focus();

        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            /* Clear all the textboxes and move the focus to
             the Score textbox in order to make them ready for another entries*/
            scoreTotal = 0;
            scoreCount = 0;

            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";

            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   // Close the application when finishing to use the app
        }
    }
}
