using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace IdleRGB
{
    public partial class Settings : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Settings"/> class.
        /// </summary>
        public Settings()
        {
            InitializeComponent();
            showSettings();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        public void showSettings()
        {
            TimeSpan it = Properties.Settings.Default.idleTime;

            hoursTextBox.Text = it.Hours.ToString();
            minutesTextBox.Text = it.Minutes.ToString();
            secondsTextBox.Text = it.Seconds.ToString();

            Show();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int h;
            int m;
            int s;

            h = m = s = 0;

            if (hoursTextBox.Text != "")
                h = Int32.Parse(hoursTextBox.Text);
            if (minutesTextBox.Text != "")
                m = Int32.Parse(minutesTextBox.Text);
            if (secondsTextBox.Text != "")
                s = Int32.Parse(secondsTextBox.Text);

            TimeSpan it = new TimeSpan(h, m, s);

            if (!it.Equals(new TimeSpan(0, 0, 0)))
            {
                Properties.Settings.Default.idleTime = it;
                Properties.Settings.Default.Save();

                Debug.WriteLine("idleTime = " + Properties.Settings.Default.idleTime.ToString());

                Close();
                Application.Restart();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
