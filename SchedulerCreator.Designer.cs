
namespace Scheduler
{
    partial class SchedulerCreator
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
            this.createButton = new System.Windows.Forms.Button();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.detailsInput = new System.Windows.Forms.TextBox();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.pickColorButton = new System.Windows.Forms.Button();
            this.dPicker = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(140)))));
            this.createButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.createButton.FlatAppearance.BorderSize = 2;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.createButton.Location = new System.Drawing.Point(628, 462);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(131, 34);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "Create";
            this.createButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lengthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.lengthLabel.Location = new System.Drawing.Point(708, 235);
            this.lengthLabel.MaximumSize = new System.Drawing.Size(575, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(52, 21);
            this.lengthLabel.TabIndex = 7;
            this.lengthLabel.Text = "0/128";
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colorBox.Location = new System.Drawing.Point(0, 0);
            this.colorBox.Margin = new System.Windows.Forms.Padding(0);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(20, 527);
            this.colorBox.TabIndex = 5;
            this.colorBox.TabStop = false;
            // 
            // titleInput
            // 
            this.titleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(140)))));
            this.titleInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleInput.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.titleInput.Location = new System.Drawing.Point(60, 20);
            this.titleInput.Margin = new System.Windows.Forms.Padding(0);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(700, 34);
            this.titleInput.TabIndex = 10;
            this.titleInput.Text = "Title";
            this.titleInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // detailsInput
            // 
            this.detailsInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(140)))));
            this.detailsInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detailsInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.detailsInput.Location = new System.Drawing.Point(60, 77);
            this.detailsInput.Margin = new System.Windows.Forms.Padding(25);
            this.detailsInput.MaxLength = 128;
            this.detailsInput.Multiline = true;
            this.detailsInput.Name = "detailsInput";
            this.detailsInput.Size = new System.Drawing.Size(700, 152);
            this.detailsInput.TabIndex = 12;
            this.detailsInput.Text = "Details";
            this.detailsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorPicker
            // 
            this.colorPicker.Color = System.Drawing.SystemColors.MenuHighlight;
            this.colorPicker.FullOpen = true;
            // 
            // pickColorButton
            // 
            this.pickColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(140)))));
            this.pickColorButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.pickColorButton.FlatAppearance.BorderSize = 2;
            this.pickColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickColorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pickColorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.pickColorButton.Location = new System.Drawing.Point(61, 282);
            this.pickColorButton.Name = "pickColorButton";
            this.pickColorButton.Size = new System.Drawing.Size(699, 34);
            this.pickColorButton.TabIndex = 13;
            this.pickColorButton.Text = "Pick Color";
            this.pickColorButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pickColorButton.UseVisualStyleBackColor = false;
            this.pickColorButton.Click += new System.EventHandler(this.pickColorButton_Click);
            // 
            // dPicker
            // 
            this.dPicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.dPicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(106)))), ((int)(((byte)(103)))));
            this.dPicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.dPicker.CustomFormat = "   dd/MM/yyyy";
            this.dPicker.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dPicker.Location = new System.Drawing.Point(60, 352);
            this.dPicker.Name = "dPicker";
            this.dPicker.Size = new System.Drawing.Size(288, 30);
            this.dPicker.TabIndex = 11;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(140)))));
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.cancelButton.FlatAppearance.BorderSize = 2;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.cancelButton.Location = new System.Drawing.Point(477, 462);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(131, 34);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tPicker
            // 
            this.tPicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.tPicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(106)))), ((int)(((byte)(103)))));
            this.tPicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.tPicker.CustomFormat = "  h:mm tt";
            this.tPicker.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tPicker.Location = new System.Drawing.Point(354, 352);
            this.tPicker.Name = "tPicker";
            this.tPicker.ShowUpDown = true;
            this.tPicker.Size = new System.Drawing.Size(119, 30);
            this.tPicker.TabIndex = 16;
            this.tPicker.Value = new System.DateTime(2021, 7, 8, 5, 15, 0, 0);
            // 
            // SchedulerCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(106)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.tPicker);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pickColorButton);
            this.Controls.Add(this.detailsInput);
            this.Controls.Add(this.dPicker);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.colorBox);
            this.Name = "SchedulerCreator";
            this.Size = new System.Drawing.Size(800, 527);
            this.Load += new System.EventHandler(this.SchedulerCreator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.TextBox detailsInput;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button pickColorButton;
        private System.Windows.Forms.DateTimePicker dPicker;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DateTimePicker tPicker;
    }
}
