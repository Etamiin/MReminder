
namespace Scheduler
{
    partial class SchedulerElement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulerElement));
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.completeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colorBox.Location = new System.Drawing.Point(0, 0);
            this.colorBox.Margin = new System.Windows.Forms.Padding(0);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(25, 150);
            this.colorBox.TabIndex = 0;
            this.colorBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.titleLabel.Location = new System.Drawing.Point(38, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(147, 28);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Scheduler Title";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoEllipsis = true;
            this.detailsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detailsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.detailsLabel.Location = new System.Drawing.Point(38, 69);
            this.detailsLabel.MaximumSize = new System.Drawing.Size(575, 0);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(568, 0);
            this.detailsLabel.TabIndex = 2;
            this.detailsLabel.Text = resources.GetString("detailsLabel.Text");
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.dateLabel.Location = new System.Drawing.Point(38, 36);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(175, 21);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "25/07/2021 @ 7.30 PM";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(106)))), ((int)(((byte)(103)))));
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteButton.FlatAppearance.BorderSize = 2;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.deleteButton.Location = new System.Drawing.Point(605, 96);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 32);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // completeButton
            // 
            this.completeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(106)))), ((int)(((byte)(103)))));
            this.completeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.completeButton.FlatAppearance.BorderSize = 2;
            this.completeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.completeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.completeButton.Location = new System.Drawing.Point(605, 53);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(95, 32);
            this.completeButton.TabIndex = 5;
            this.completeButton.Text = "Complete";
            this.completeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.completeButton.UseVisualStyleBackColor = false;
            this.completeButton.Visible = false;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // SchedulerElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(140)))));
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.colorBox);
            this.Name = "SchedulerElement";
            this.Size = new System.Drawing.Size(800, 150);
            this.Load += new System.EventHandler(this.SchedulerElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox colorBox;
        public System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.Label detailsLabel;
        public System.Windows.Forms.Label dateLabel;
        public System.Windows.Forms.Button deleteButton;
        public System.Windows.Forms.Button completeButton;
    }
}
