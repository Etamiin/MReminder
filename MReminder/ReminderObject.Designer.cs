namespace MReminder
{
    partial class ReminderObject
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.timeLabel = new System.Windows.Forms.Label();
            this.repeatCheck = new System.Windows.Forms.CheckBox();
            this.mondayButton = new System.Windows.Forms.Button();
            this.tuesdayButton = new System.Windows.Forms.Button();
            this.wednesdayButton = new System.Windows.Forms.Button();
            this.thursdayButton = new System.Windows.Forms.Button();
            this.fridayButton = new System.Windows.Forms.Button();
            this.saturdayButton = new System.Windows.Forms.Button();
            this.sundayButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.hourBox = new System.Windows.Forms.TextBox();
            this.hourLabel = new System.Windows.Forms.Label();
            this.minBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorButton = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.timeLabel.Location = new System.Drawing.Point(16, 50);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(46, 21);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Time";
            // 
            // repeatCheck
            // 
            this.repeatCheck.AutoSize = true;
            this.repeatCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.repeatCheck.Checked = true;
            this.repeatCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.repeatCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.repeatCheck.Location = new System.Drawing.Point(15, 85);
            this.repeatCheck.Name = "repeatCheck";
            this.repeatCheck.Size = new System.Drawing.Size(81, 25);
            this.repeatCheck.TabIndex = 3;
            this.repeatCheck.Text = "Repeat";
            this.repeatCheck.UseVisualStyleBackColor = true;
            this.repeatCheck.CheckedChanged += new System.EventHandler(this.repeatCheck_CheckedChanged);
            // 
            // mondayButton
            // 
            this.mondayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(125)))), ((int)(((byte)(167)))));
            this.mondayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mondayButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mondayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.mondayButton.Location = new System.Drawing.Point(8, 156);
            this.mondayButton.Name = "mondayButton";
            this.mondayButton.Size = new System.Drawing.Size(100, 33);
            this.mondayButton.TabIndex = 4;
            this.mondayButton.Text = "Monday";
            this.mondayButton.UseVisualStyleBackColor = false;
            this.mondayButton.Click += new System.EventHandler(this.mondayButton_Click);
            // 
            // tuesdayButton
            // 
            this.tuesdayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(125)))), ((int)(((byte)(167)))));
            this.tuesdayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tuesdayButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesdayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.tuesdayButton.Location = new System.Drawing.Point(115, 156);
            this.tuesdayButton.Name = "tuesdayButton";
            this.tuesdayButton.Size = new System.Drawing.Size(100, 33);
            this.tuesdayButton.TabIndex = 5;
            this.tuesdayButton.Text = "Tuesday";
            this.tuesdayButton.UseVisualStyleBackColor = false;
            this.tuesdayButton.Click += new System.EventHandler(this.tuesdayButton_Click);
            // 
            // wednesdayButton
            // 
            this.wednesdayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(125)))), ((int)(((byte)(167)))));
            this.wednesdayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wednesdayButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesdayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.wednesdayButton.Location = new System.Drawing.Point(225, 156);
            this.wednesdayButton.Name = "wednesdayButton";
            this.wednesdayButton.Size = new System.Drawing.Size(100, 33);
            this.wednesdayButton.TabIndex = 6;
            this.wednesdayButton.Text = "Wednesday";
            this.wednesdayButton.UseVisualStyleBackColor = false;
            this.wednesdayButton.Click += new System.EventHandler(this.wednesdayButton_Click);
            // 
            // thursdayButton
            // 
            this.thursdayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(125)))), ((int)(((byte)(167)))));
            this.thursdayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thursdayButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursdayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.thursdayButton.Location = new System.Drawing.Point(335, 156);
            this.thursdayButton.Name = "thursdayButton";
            this.thursdayButton.Size = new System.Drawing.Size(100, 33);
            this.thursdayButton.TabIndex = 7;
            this.thursdayButton.Text = "Thursday";
            this.thursdayButton.UseVisualStyleBackColor = false;
            this.thursdayButton.Click += new System.EventHandler(this.thursdayButton_Click);
            // 
            // fridayButton
            // 
            this.fridayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(125)))), ((int)(((byte)(167)))));
            this.fridayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fridayButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fridayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.fridayButton.Location = new System.Drawing.Point(445, 156);
            this.fridayButton.Name = "fridayButton";
            this.fridayButton.Size = new System.Drawing.Size(100, 33);
            this.fridayButton.TabIndex = 8;
            this.fridayButton.Text = "Friday";
            this.fridayButton.UseVisualStyleBackColor = false;
            this.fridayButton.Click += new System.EventHandler(this.fridayButton_Click);
            // 
            // saturdayButton
            // 
            this.saturdayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(125)))), ((int)(((byte)(167)))));
            this.saturdayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saturdayButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturdayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.saturdayButton.Location = new System.Drawing.Point(555, 156);
            this.saturdayButton.Name = "saturdayButton";
            this.saturdayButton.Size = new System.Drawing.Size(100, 33);
            this.saturdayButton.TabIndex = 9;
            this.saturdayButton.Text = "Saturday";
            this.saturdayButton.UseVisualStyleBackColor = false;
            this.saturdayButton.Click += new System.EventHandler(this.saturdayButton_Click);
            // 
            // sundayButton
            // 
            this.sundayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(125)))), ((int)(((byte)(167)))));
            this.sundayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sundayButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.sundayButton.Location = new System.Drawing.Point(665, 156);
            this.sundayButton.Name = "sundayButton";
            this.sundayButton.Size = new System.Drawing.Size(100, 33);
            this.sundayButton.TabIndex = 10;
            this.sundayButton.Text = "Sunday";
            this.sundayButton.UseVisualStyleBackColor = false;
            this.sundayButton.Click += new System.EventHandler(this.sundayButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.deleteButton.Location = new System.Drawing.Point(892, 156);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 33);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(116)))), ((int)(((byte)(86)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.updateButton.Location = new System.Drawing.Point(774, 156);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(105, 33);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // hourBox
            // 
            this.hourBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.hourBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hourBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.hourBox.Location = new System.Drawing.Point(72, 50);
            this.hourBox.MaxLength = 2;
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(53, 22);
            this.hourBox.TabIndex = 13;
            this.hourBox.Text = "00";
            this.hourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hourBox.TextChanged += new System.EventHandler(this.hourBox_TextChanged);
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.hourLabel.Location = new System.Drawing.Point(131, 50);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(22, 21);
            this.hourLabel.TabIndex = 14;
            this.hourLabel.Text = "H";
            // 
            // minBox
            // 
            this.minBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.minBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.minBox.Location = new System.Drawing.Point(159, 50);
            this.minBox.MaxLength = 2;
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(53, 22);
            this.minBox.TabIndex = 15;
            this.minBox.Text = "00";
            this.minBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minBox.TextChanged += new System.EventHandler(this.minBox_TextChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.minLabel.Location = new System.Drawing.Point(218, 50);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(25, 21);
            this.minLabel.TabIndex = 16;
            this.minLabel.Text = "M";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.label1.Location = new System.Drawing.Point(16, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Description";
            // 
            // descriptionBox
            // 
            this.descriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.descriptionBox.Location = new System.Drawing.Point(135, 122);
            this.descriptionBox.MaxLength = 111;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(862, 22);
            this.descriptionBox.TabIndex = 18;
            this.descriptionBox.Text = "Description";
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.colorLabel.Location = new System.Drawing.Point(131, 86);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(50, 21);
            this.colorLabel.TabIndex = 19;
            this.colorLabel.Text = "Color";
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(64)))));
            this.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.colorButton.Location = new System.Drawing.Point(187, 85);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(108, 31);
            this.colorButton.TabIndex = 20;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.titleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(211)))));
            this.titleBox.Location = new System.Drawing.Point(0, 0);
            this.titleBox.MaxLength = 59;
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(1000, 26);
            this.titleBox.TabIndex = 21;
            this.titleBox.Text = "Title";
            this.titleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // ReminderObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.sundayButton);
            this.Controls.Add(this.saturdayButton);
            this.Controls.Add(this.fridayButton);
            this.Controls.Add(this.thursdayButton);
            this.Controls.Add(this.wednesdayButton);
            this.Controls.Add(this.tuesdayButton);
            this.Controls.Add(this.mondayButton);
            this.Controls.Add(this.repeatCheck);
            this.Controls.Add(this.timeLabel);
            this.Name = "ReminderObject";
            this.Size = new System.Drawing.Size(1000, 200);
            this.Load += new System.EventHandler(this.ReminderObject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button mondayButton;
        private System.Windows.Forms.Button tuesdayButton;
        private System.Windows.Forms.Button wednesdayButton;
        private System.Windows.Forms.Button thursdayButton;
        private System.Windows.Forms.Button fridayButton;
        private System.Windows.Forms.Button saturdayButton;
        private System.Windows.Forms.Button sundayButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox hourBox;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.CheckBox repeatCheck;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.TextBox titleBox;
    }
}
