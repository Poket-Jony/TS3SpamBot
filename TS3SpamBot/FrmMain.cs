using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TS3ClientQueryFramework;
using TS3ClientQueryFramework.TS3Models;

namespace TS3SpamBot
{
    public partial class FrmMain : Form
    {
        public TS3Client ts3Client = new TS3Client();

        public FrmMain()
        {
            InitializeComponent();
            if(ts3Client.Connect())
            {
                comboBoxTab.DataSource = ts3Client.ServerConnectionHandlerList();
                comboBoxUser.DataSource = ts3Client.GetClientList();
                btnPokeSpam.Enabled = true;
                btnTextSpam.Enabled = true;
            }
        }

        private void comboBoxTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            ts3Client.Use((int)comboBoxTab.SelectedItem);
        }

        private void btnTextSpam_Click(object sender, EventArgs e)
        {
            timerTextSpam.Interval = (int)numSpeed.Value;
            timerTextSpam.Enabled = !timerTextSpam.Enabled;
        }

        private void btnPokeSpam_Click(object sender, EventArgs e)
        {
            timerPokeSpam.Interval = (int)numSpeed.Value;
            timerPokeSpam.Enabled = !timerPokeSpam.Enabled;
        }

        private void timerTextSpam_Tick(object sender, EventArgs e)
        {
            ts3Client.SendTextMessage(TextMessageTargetMode.TextMessageTarget_CLIENT, ((Client)comboBoxUser.SelectedItem).ClId, txtBoxSpam.Text, true);
        }

        private void timerPokeSpam_Tick(object sender, EventArgs e)
        {
            ts3Client.ClientPoke(((Client)comboBoxUser.SelectedItem).ClId, txtBoxSpam.Text, true);
        }
    }
}
