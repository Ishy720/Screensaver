using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ambience
{
    public partial class Screensaver : Form
    {
        userSettings user = new userSettings();
        Timer t = new Timer();
        string affix = "";

        public Screensaver()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            settingsGroupBox.Visible = false;
            refreshVisuals();

            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

        }

        private void refreshVisuals()
        {
            this.BackColor = System.Drawing.Color.FromName(user.getBackgroundColour());
            this.Refresh();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string time = "";

            string currentDay = DateTime.Now.ToString("dd");
            string month = DateTime.Now.ToString("MMMM");
            string year = DateTime.Now.ToString("yyyy");

            try
            {
                int intDay = Int32.Parse(currentDay);
                if (intDay == 1)
                {
                    affix = "st";
                }
                else if (intDay == 2)
                {
                    affix = "nd";
                }
                else if (intDay == 3)
                {
                    affix = "rd";
                }
                else
                {
                    affix = "th";
                }
            }

            catch
            {
                Console.WriteLine("Oof");
            }

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            timeLbl.Text = time;
            dateLbl.Text = currentDay + affix + " " + month + " " + year;
            refreshVisuals();
        }

        private void timeLbl_Click(object sender, EventArgs e)
        {
            settingsGroupBox.Visible = true;
        }

        private void dateLbl_Click(object sender, EventArgs e)
        {
            settingsGroupBox.Visible = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            settingsGroupBox.Visible = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backColorDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            user.setBackgroundColour(backColorDropDownList.SelectedItem.ToString());
        }
    }
}
