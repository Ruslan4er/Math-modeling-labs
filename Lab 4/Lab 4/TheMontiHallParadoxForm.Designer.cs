namespace Lab_4
{
    partial class TheMontiHallParadoxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClearButton = new System.Windows.Forms.Button();
            this.firstDoorNumberLabel = new System.Windows.Forms.Label();
            this.secondDoorNumberLabel = new System.Windows.Forms.Label();
            this.thirdDoorNumberLabel = new System.Windows.Forms.Label();
            this.firstDoorPictureBox = new System.Windows.Forms.PictureBox();
            this.secondDoorPictureBox = new System.Windows.Forms.PictureBox();
            this.thirdDoorPictureBox = new System.Windows.Forms.PictureBox();
            this.OpenStatisticFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firstDoorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondDoorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdDoorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(185, 275);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(91, 44);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Повторить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // firstDoorNumberLabel
            // 
            this.firstDoorNumberLabel.AutoSize = true;
            this.firstDoorNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstDoorNumberLabel.Location = new System.Drawing.Point(41, 24);
            this.firstDoorNumberLabel.Name = "firstDoorNumberLabel";
            this.firstDoorNumberLabel.Size = new System.Drawing.Size(84, 16);
            this.firstDoorNumberLabel.TabIndex = 1;
            this.firstDoorNumberLabel.Text = "Дверь № 1";
            // 
            // secondDoorNumberLabel
            // 
            this.secondDoorNumberLabel.AutoSize = true;
            this.secondDoorNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondDoorNumberLabel.Location = new System.Drawing.Point(192, 24);
            this.secondDoorNumberLabel.Name = "secondDoorNumberLabel";
            this.secondDoorNumberLabel.Size = new System.Drawing.Size(84, 16);
            this.secondDoorNumberLabel.TabIndex = 2;
            this.secondDoorNumberLabel.Text = "Дверь № 2";
            // 
            // thirdDoorNumberLabel
            // 
            this.thirdDoorNumberLabel.AutoSize = true;
            this.thirdDoorNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdDoorNumberLabel.Location = new System.Drawing.Point(331, 24);
            this.thirdDoorNumberLabel.Name = "thirdDoorNumberLabel";
            this.thirdDoorNumberLabel.Size = new System.Drawing.Size(84, 16);
            this.thirdDoorNumberLabel.TabIndex = 3;
            this.thirdDoorNumberLabel.Text = "Дверь № 3";
            // 
            // firstDoorPictureBox
            // 
            this.firstDoorPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstDoorPictureBox.Image = global::Lab_4.Properties.Resources.Door;
            this.firstDoorPictureBox.Location = new System.Drawing.Point(27, 43);
            this.firstDoorPictureBox.Name = "firstDoorPictureBox";
            this.firstDoorPictureBox.Size = new System.Drawing.Size(123, 214);
            this.firstDoorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.firstDoorPictureBox.TabIndex = 5;
            this.firstDoorPictureBox.TabStop = false;
            this.firstDoorPictureBox.Click += new System.EventHandler(this.firstDoorPictureBox_Click);
            // 
            // secondDoorPictureBox
            // 
            this.secondDoorPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secondDoorPictureBox.Image = global::Lab_4.Properties.Resources.Door;
            this.secondDoorPictureBox.Location = new System.Drawing.Point(171, 43);
            this.secondDoorPictureBox.Name = "secondDoorPictureBox";
            this.secondDoorPictureBox.Size = new System.Drawing.Size(123, 214);
            this.secondDoorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.secondDoorPictureBox.TabIndex = 6;
            this.secondDoorPictureBox.TabStop = false;
            this.secondDoorPictureBox.Click += new System.EventHandler(this.secondDoorPictureBox_Click);
            // 
            // thirdDoorPictureBox
            // 
            this.thirdDoorPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thirdDoorPictureBox.Image = global::Lab_4.Properties.Resources.Door;
            this.thirdDoorPictureBox.Location = new System.Drawing.Point(316, 43);
            this.thirdDoorPictureBox.Name = "thirdDoorPictureBox";
            this.thirdDoorPictureBox.Size = new System.Drawing.Size(123, 214);
            this.thirdDoorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.thirdDoorPictureBox.TabIndex = 7;
            this.thirdDoorPictureBox.TabStop = false;
            this.thirdDoorPictureBox.Click += new System.EventHandler(this.thirdDoorPictureBox_Click);
            // 
            // OpenStatisticFormButton
            // 
            this.OpenStatisticFormButton.Location = new System.Drawing.Point(343, 281);
            this.OpenStatisticFormButton.Name = "OpenStatisticFormButton";
            this.OpenStatisticFormButton.Size = new System.Drawing.Size(85, 32);
            this.OpenStatisticFormButton.TabIndex = 8;
            this.OpenStatisticFormButton.Text = "Статистика";
            this.OpenStatisticFormButton.UseVisualStyleBackColor = true;
            this.OpenStatisticFormButton.Click += new System.EventHandler(this.OpenStatisticFormButton_Click);
            // 
            // TheMontiHallParadoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 335);
            this.Controls.Add(this.OpenStatisticFormButton);
            this.Controls.Add(this.thirdDoorPictureBox);
            this.Controls.Add(this.secondDoorPictureBox);
            this.Controls.Add(this.firstDoorPictureBox);
            this.Controls.Add(this.thirdDoorNumberLabel);
            this.Controls.Add(this.secondDoorNumberLabel);
            this.Controls.Add(this.firstDoorNumberLabel);
            this.Controls.Add(this.ClearButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TheMontiHallParadoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Monti Hall Paradox";
            ((System.ComponentModel.ISupportInitialize)(this.firstDoorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondDoorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdDoorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label firstDoorNumberLabel;
        private System.Windows.Forms.Label secondDoorNumberLabel;
        private System.Windows.Forms.Label thirdDoorNumberLabel;
        private System.Windows.Forms.PictureBox firstDoorPictureBox;
        private System.Windows.Forms.PictureBox secondDoorPictureBox;
        private System.Windows.Forms.PictureBox thirdDoorPictureBox;
        private System.Windows.Forms.Button OpenStatisticFormButton;
    }
}

