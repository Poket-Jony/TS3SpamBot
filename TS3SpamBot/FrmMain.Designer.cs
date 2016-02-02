namespace TS3SpamBot
{
    partial class FrmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBoxSpam = new System.Windows.Forms.TextBox();
            this.btnTextSpam = new System.Windows.Forms.Button();
            this.btnPokeSpam = new System.Windows.Forms.Button();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.comboBoxTab = new System.Windows.Forms.ComboBox();
            this.timerTextSpam = new System.Windows.Forms.Timer(this.components);
            this.timerPokeSpam = new System.Windows.Forms.Timer(this.components);
            this.lblTab = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.chkBoxSpamNewClients = new System.Windows.Forms.CheckBox();
            this.timerPokeSpamNewClients = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxSpam
            // 
            this.txtBoxSpam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxSpam.Location = new System.Drawing.Point(0, 0);
            this.txtBoxSpam.Multiline = true;
            this.txtBoxSpam.Name = "txtBoxSpam";
            this.txtBoxSpam.Size = new System.Drawing.Size(396, 264);
            this.txtBoxSpam.TabIndex = 0;
            // 
            // btnTextSpam
            // 
            this.btnTextSpam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTextSpam.Enabled = false;
            this.btnTextSpam.Location = new System.Drawing.Point(228, 10);
            this.btnTextSpam.Name = "btnTextSpam";
            this.btnTextSpam.Size = new System.Drawing.Size(75, 23);
            this.btnTextSpam.TabIndex = 1;
            this.btnTextSpam.Text = "Text Spam";
            this.btnTextSpam.UseVisualStyleBackColor = true;
            this.btnTextSpam.Click += new System.EventHandler(this.btnTextSpam_Click);
            // 
            // btnPokeSpam
            // 
            this.btnPokeSpam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPokeSpam.Enabled = false;
            this.btnPokeSpam.Location = new System.Drawing.Point(309, 10);
            this.btnPokeSpam.Name = "btnPokeSpam";
            this.btnPokeSpam.Size = new System.Drawing.Size(75, 23);
            this.btnPokeSpam.TabIndex = 2;
            this.btnPokeSpam.Text = "Poke Spam";
            this.btnPokeSpam.UseVisualStyleBackColor = true;
            this.btnPokeSpam.Click += new System.EventHandler(this.btnPokeSpam_Click);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(54, 12);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(168, 21);
            this.comboBoxUser.TabIndex = 3;
            // 
            // comboBoxTab
            // 
            this.comboBoxTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTab.FormattingEnabled = true;
            this.comboBoxTab.Location = new System.Drawing.Point(54, 47);
            this.comboBoxTab.Name = "comboBoxTab";
            this.comboBoxTab.Size = new System.Drawing.Size(52, 21);
            this.comboBoxTab.TabIndex = 4;
            this.comboBoxTab.SelectedIndexChanged += new System.EventHandler(this.comboBoxTab_SelectedIndexChanged);
            // 
            // timerTextSpam
            // 
            this.timerTextSpam.Interval = 50;
            this.timerTextSpam.Tick += new System.EventHandler(this.timerTextSpam_Tick);
            // 
            // timerPokeSpam
            // 
            this.timerPokeSpam.Interval = 50;
            this.timerPokeSpam.Tick += new System.EventHandler(this.timerPokeSpam_Tick);
            // 
            // lblTab
            // 
            this.lblTab.AutoSize = true;
            this.lblTab.Location = new System.Drawing.Point(12, 50);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(29, 13);
            this.lblTab.TabIndex = 5;
            this.lblTab.Text = "Tab:";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(12, 15);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(36, 13);
            this.lblClient.TabIndex = 6;
            this.lblClient.Text = "Client:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(225, 50);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblSpeed.TabIndex = 7;
            this.lblSpeed.Text = "Speed:";
            // 
            // numSpeed
            // 
            this.numSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSpeed.Location = new System.Drawing.Point(272, 47);
            this.numSpeed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(112, 20);
            this.numSpeed.TabIndex = 8;
            this.numSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.chkBoxSpamNewClients);
            this.pnlControl.Controls.Add(this.lblClient);
            this.pnlControl.Controls.Add(this.numSpeed);
            this.pnlControl.Controls.Add(this.btnTextSpam);
            this.pnlControl.Controls.Add(this.lblSpeed);
            this.pnlControl.Controls.Add(this.btnPokeSpam);
            this.pnlControl.Controls.Add(this.comboBoxUser);
            this.pnlControl.Controls.Add(this.lblTab);
            this.pnlControl.Controls.Add(this.comboBoxTab);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 264);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(396, 79);
            this.pnlControl.TabIndex = 9;
            // 
            // chkBoxSpamNewClients
            // 
            this.chkBoxSpamNewClients.AutoSize = true;
            this.chkBoxSpamNewClients.Location = new System.Drawing.Point(113, 49);
            this.chkBoxSpamNewClients.Name = "chkBoxSpamNewClients";
            this.chkBoxSpamNewClients.Size = new System.Drawing.Size(109, 17);
            this.chkBoxSpamNewClients.TabIndex = 9;
            this.chkBoxSpamNewClients.Text = "Spam new clients";
            this.chkBoxSpamNewClients.UseVisualStyleBackColor = true;
            this.chkBoxSpamNewClients.CheckedChanged += new System.EventHandler(this.chkBoxSpamNewClients_CheckedChanged);
            // 
            // timerPokeSpamNewClients
            // 
            this.timerPokeSpamNewClients.Interval = 10;
            this.timerPokeSpamNewClients.Tick += new System.EventHandler(this.timerPokeSpamNewClients_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 343);
            this.Controls.Add(this.txtBoxSpam);
            this.Controls.Add(this.pnlControl);
            this.Name = "FrmMain";
            this.Text = "TS3SpamBot";
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSpam;
        private System.Windows.Forms.Button btnTextSpam;
        private System.Windows.Forms.Button btnPokeSpam;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.ComboBox comboBoxTab;
        private System.Windows.Forms.Timer timerTextSpam;
        private System.Windows.Forms.Timer timerPokeSpam;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.CheckBox chkBoxSpamNewClients;
        private System.Windows.Forms.Timer timerPokeSpamNewClients;
    }
}

