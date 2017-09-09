using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Windows.Input;

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
            ShowSettings();
        }

        public void ShowSettings()
        {
            TimeSpan it = Properties.Settings.Default.idleTime;

            InitializeComboBox(hoursBox, 24);
            hoursBox.SelectedItem = it.Hours;

            InitializeComboBox(minutesBox, 60);
            minutesBox.SelectedItem = it.Minutes;

            InitializeComboBox(secondsBox, 60);
            secondsBox.SelectedItem = it.Seconds;

            Show();
        }

        private void InitializeComboBox(ComboBox comboBox, int upperLimit)
        {
            for (int i = 0; i < upperLimit + 1; i++)
                comboBox.Items.Add(i);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int h = (int)hoursBox.SelectedItem;
            int m = (int)minutesBox.SelectedItem;
            int s = (int)secondsBox.SelectedItem;

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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
