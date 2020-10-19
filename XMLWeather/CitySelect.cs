using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CitySelect : UserControl
    {
        public CitySelect()
        {
            InitializeComponent();
        }
        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                tryAgain.Text = "";
                Form1.place = cityInput.Text;
                if (cityInput.Text == "")
                {
                    tryAgain.Text = "Please try again.";
                }
                else
                {
                    Form f = this.FindForm();
                    f.Controls.Remove(this);
                }


            }
            catch
            {
                tryAgain.Text = "Please try again.";
            }

        }
    }
}
