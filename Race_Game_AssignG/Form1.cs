using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_Game_AssignG
{
    public partial class Form1 : Form
    {
        int dog = 0;
        int Mandeep = 100, Johan = 100, Harpreet = 100;
        int winnerNo = 0;

        racing race = new racing();

        ResultDeclare rslt = new ResultDeclare();

        public Form1()
        {
            InitializeComponent();
            //load the no in the amount combo box for selecting the bet amount 
            for (int y=1;y<=50;y++) {
                cbAmount.Items.Add(y.ToString());
            }
            run_btn.Enabled = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void set_btn_Click(object sender, EventArgs e)
        {
            //set the details of the better 
            if (CbPlayer.SelectedIndex == 0 && dog > 0 && Convert.ToInt32(cbAmount.SelectedItem.ToString()) <= Mandeep)
            {
                //means we have selected the Mandeep 
                mandeeplbl.Text = "Mandeep choosed " + dog + " dog and " + cbAmount.SelectedItem.ToString() + " Dollar";
                run_btn.Enabled = true;
            } else if (CbPlayer.SelectedIndex == 1 && dog > 0 && Convert.ToInt32(cbAmount.SelectedItem.ToString()) <= Johan) {
                johnlbl.Text = "Johan choosed " + dog + " dog and " + cbAmount.SelectedItem.ToString() + " Dollar";
                run_btn.Enabled = true;
            } else if (CbPlayer.SelectedIndex == 2 && dog > 0 && Convert.ToInt32(cbAmount.SelectedItem.ToString()) <= Harpreet) {
                    harpreetlbl.Text= "Harpreet choosed " + dog + " dog and " + cbAmount.SelectedItem.ToString() + " Dollar";
                run_btn.Enabled = true;
            }
            else {
                MessageBox.Show("You must folow the Details of the game to Play ");
            }
            dog = 0;
            firstdog.Checked = false;
            sdog.Checked = false;
            tdog.Checked = false;
            fdog.Checked = false;
        }

        private void firstdog_CheckedChanged(object sender, EventArgs e)
        {
            //check which no of dog is selected for the bet 
            if (firstdog.Checked == true) {
                dog = 1;
                sdog.Checked = false;
                tdog.Checked = false;
                fdog.Checked = false;
            }
        }

        private void sdog_CheckedChanged(object sender, EventArgs e)
        {
            //check which no of dog is selected for the bet 
            if (sdog.Checked == true)
            {
                dog = 2;
                firstdog.Checked = false;
                tdog.Checked = false;
                fdog.Checked = false;
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dog1.Left += race.jumpStep();
            Dog2.Left += race.jumpStep();
            Dog3.Left += race.jumpStep();
            Dog4.Left += race.jumpStep();
            //when ethe dog reach at the finishing point stop the game announce the result
            if (Dog1.Left>700) {
                winnerNo = 1;
                
                timer1.Enabled = false;
                resultset();
            }
            if (Dog2.Left > 700)
            {
                winnerNo = 2;
                
                timer1.Enabled = false;
                resultset();
            }
            if (Dog3.Left > 700)
            {
                winnerNo = 3;
                
                timer1.Enabled = false;
                resultset();
            }
            if (Dog4.Left > 700)
            {
                winnerNo = 4;
                
                timer1.Enabled = false;
                resultset();
            }
        }
        //anounce the result for the player 
        public void resultset() {
            MessageBox.Show(winnerNo +" dog Won the race");
            if (mandeeplbl.Text.Contains("dog")) {
                Mandeep=rslt.budgetSet(mandeeplbl.Text,Mandeep,winnerNo);
                mandeeplbl.Text = "Mandeep has Total $" + Mandeep;
            }
            if (johnlbl.Text.Contains("dog"))
            {
                Johan = rslt.budgetSet(johnlbl.Text, Johan, winnerNo);
                johnlbl.Text = "Johan has Total $" + Johan;
            }
            if (harpreetlbl.Text.Contains("dog"))
            {
                Harpreet = rslt.budgetSet(harpreetlbl.Text, Harpreet, winnerNo);
                harpreetlbl.Text = "Harpreet has Total $" + Harpreet;
            }

            firstdog.Checked = false;
            sdog.Checked = false;
            tdog.Checked = false;
            fdog.Checked = false;

            Dog1.Left = 0;
            Dog2.Left = 0;
            Dog3.Left = 0;
            Dog4.Left = 0;
            dog = 0;
            winnerNo = 0;
            CbPlayer.Text = "";
            cbAmount.Text = "";
            run_btn.Enabled = false;
        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void tdog_CheckedChanged(object sender, EventArgs e)
        {
            //check which no of dog is selected for the bet 
            if (tdog.Checked == true)
            {
                dog = 3;
                firstdog.Checked = false;
                sdog.Checked = false;
                fdog.Checked = false;

            }
        }

        private void fdog_CheckedChanged(object sender, EventArgs e)
        {
            //check which no of dog is selected for the bet 
            if (fdog.Checked == true)
            {
                dog = 4;
                firstdog.Checked = false;
                sdog.Checked = false;
                tdog.Checked = false;
            }
        }
    }
}
