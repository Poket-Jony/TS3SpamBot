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

        private void chkBoxSpamNewClients_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBoxSpamNewClients.Checked)
            {
                ts3Client.Notifier.OnClientEnterView += Notifier_OnClientEnterView;
                ts3Client.ClientNotifyRegister(ts3Client.CurrentHandlerId, Notifications.notifycliententerview);
            }
            else
            {
                ts3Client.Notifier.OnClientEnterView -= Notifier_OnClientEnterView;
                ts3Client.ClientNotifyUnregister(ts3Client.CurrentHandlerId, Notifications.notifycliententerview);
                timerPokeSpamNewClients.Stop();
                spamNewClientCount = 0;
                spamNewClient = 0;
            }
        }

        private int spamNewClient = 0;
        private int spamNewClientCount = 0;
        private void Notifier_OnClientEnterView(ClientEnterView clientEnterView)
        {
            this.Invoke((MethodInvoker)delegate {
                if (chkBoxSpamNewClients.Checked)
                {
                    spamNewClient = clientEnterView.Client.ClId;
                    if (timerPokeSpamNewClients.Enabled)
                        spamNewClientCount = 0;
                    else
                        timerPokeSpamNewClients.Start();
                }
            });
        }

        private void timerPokeSpamNewClients_Tick(object sender, EventArgs e)
        {
            if(spamNewClientCount >= 150)
            {
                spamNewClientCount = 0;
                spamNewClient = 0;
                timerPokeSpamNewClients.Stop();
                return;
            }
            if (spamNewClientCount >= 50)
                ts3Client.ClientPoke(spamNewClient, txtBoxSpam.Text, true);
            spamNewClientCount++;
        }
    }
}
