namespace MReminder
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.createButton = new System.Windows.Forms.Button();
            this.reminderContainer = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quitoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyContextStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(103)))), ((int)(((byte)(193)))));
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createButton.Location = new System.Drawing.Point(894, 532);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(118, 32);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "CREATE";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // reminderContainer
            // 
            this.reminderContainer.AutoScroll = true;
            this.reminderContainer.Location = new System.Drawing.Point(0, 0);
            this.reminderContainer.Name = "reminderContainer";
            this.reminderContainer.Size = new System.Drawing.Size(1024, 526);
            this.reminderContainer.TabIndex = 4;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyContextStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MReminder";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // notifyContextStrip
            // 
            this.notifyContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitoolStripMenuItem});
            this.notifyContextStrip.Name = "notifyContextStrip";
            this.notifyContextStrip.Size = new System.Drawing.Size(98, 26);
            // 
            // quitoolStripMenuItem
            // 
            this.quitoolStripMenuItem.Name = "quitoolStripMenuItem";
            this.quitoolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitoolStripMenuItem.Text = "Quit";
            this.quitoolStripMenuItem.Click += new System.EventHandler(this.quitoolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.reminderContainer);
            this.Controls.Add(this.createButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MReminder";
            this.Load += new System.EventHandler(this.Main_Load);
            this.notifyContextStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Panel reminderContainer;
        private ReminderObject reminderObject1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyContextStrip;
        private System.Windows.Forms.ToolStripMenuItem quitoolStripMenuItem;
    }
}

