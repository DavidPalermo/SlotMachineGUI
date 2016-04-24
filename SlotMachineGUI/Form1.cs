using SlotMachineGUI.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SlotMachineGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblPoints.Text = "Points: 200";
        }
        int img1, img2, img3, winVal, points = 200, jackpot = 200;        
        string calcOutVal;
        const int playCost = -10;        
        Random rnd = new Random();
        Image[] imgBoxPics = {Resources.AwkwardSeal, Resources.seal1, Resources.seal2, Resources.seal3, Resources.seal4,
                                 Resources.seal5, Resources.seal6, Resources.seal7, Resources.seal8, Resources.sealsinger};
       
        /*
        # btnPlay_Click is the Main driving method of this app,
        # it increases and updates the Jackpot per click.
        */
        private void btnPlay_Click(object sender, EventArgs e)
        {
            jackpot += 10;
            lblJackpot.Text = String.Format("Jackpot is {0} points", jackpot);
            lblPoints.Text = calcPoints(playCost);
            lblResults.Text = "";
            PlayCost();            
            if (points < 10)
            {
                btnPlay.Visible = false;
                btnClear.Visible = true;
                lblResults.Text = "You Lose!";
            }
        }

        /*
        # PlayCost method checks for any matching pictures that are awarded points, 
        # establishes the amount of points to be awarded, passes the award value 
        # to the calcPoints method, and lastly informs the User of what happened
        # through the lblPoints and lblResults labels as necessary.
        */
        private void PlayCost()
        {
            imgBox1.Image = imgBoxPics[rndelement(ref img1)];
            imgBox2.Image = imgBoxPics[rndelement(ref img2)];
            imgBox3.Image = imgBoxPics[rndelement(ref img3)];
            if (img1 == 0 && img2 == 0 && img3 == 0)
            {
                lblResults.Text = String.Format("You hit the jackpot! \n+ {0}", jackpot);
                lblPoints.Text = calcPoints(jackpot);
                jackpot = 200;
            }
            else if (img1 == img2 && img1 == img3)
            {
                winVal = rnd.Next(55, 75);
                lblResults.Text = String.Format("You won! \n+ {0}", winVal);
                lblPoints.Text = calcPoints(winVal);
            }
            else if (img1 == img2 || img1 == img3 || img2 == img3)
            {
                winVal = rnd.Next(20, 30);
                lblResults.Text = String.Format("You won! \n+ {0}", winVal);
                lblPoints.Text = calcPoints(winVal);
            }
            else
                lblResults.Text = "Sorry, you did not win.";
        }        

        /*
        # Method to adjust the User's points
        # @param int numIn passed in from the PlayCost method to be converted to a string
        # @return string calcOutVal as a formated string representation of points.
        */
        private string calcPoints(int numIn)
        {
            points += numIn;
            calcOutVal = String.Format("Points: {0}", points); 
            return calcOutVal;
        }

        /*
        # Method to randomly pick a number based off the imgBoxPics array
        # @param ref int num passed in to be assigned the random pick 
        # @return num is the randomly picked number.
        */
        private int rndelement(ref int num)
        {
            num = rnd.Next(0, imgBoxPics.Length);
            return num;
        }

        /*
        # Method to reset the application for further play. 
        # Resets the User's points and posts it to the lblPoints label.         
        */
        private void btnClear_Click(object sender, EventArgs e)
        {
            points = 200;
            btnClear.Visible = false;
            btnPlay.Visible = true;
            lblResults.Text = "";
            lblPoints.Text = String.Format("Points: {0}", points);
        }
    }
}
