using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MeteoFacile.Classes
{
    public partial class NotificationDesigner1 : Form {
        public NotificationDesigner1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox) sender;

            if (NotificationManager.addHeader = true) { 
                checkBox.Checked = true; 
            } else { checkBox.Checked = false; }
          
            if (checkBox.Checked) {
                NotificationManager.addHeader = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (NotificationManager.addText = true)
            {
                checkBox.Checked = true;
            }
            else { checkBox.Checked = false; }

            if (checkBox.Checked)
            {
                NotificationManager.addText = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (NotificationManager.addImage = true)
            {
                checkBox.Checked = true;
            }
            else { checkBox.Checked = false; }

            if (checkBox.Checked)
            {
                NotificationManager.addImage = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (NotificationManager.addSchedule = true)
            {
                checkBox.Checked = true;
            }
            else { checkBox.Checked = false; }

            if (checkBox.Checked)
            {
                NotificationManager.addchedule = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (NotificationManager.addProgressiveBar = true)
            {
                checkBox.Checked = true;
            }
            else { checkBox.Checked = false; }

            if (checkBox.Checked)
            {
                NotificationManager.addProgressiveBar = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (NotificationManager.addButton = true)
            {
                checkBox.Checked = true;
            }
            else { checkBox.Checked = false; }

            if (checkBox.Checked)
            {
                NotificationManager.addButton = true;
            }
        }
    }
}
