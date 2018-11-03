namespace SnakeTheGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gameScore = new System.Windows.Forms.Label();
            this.endText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.highScoreValue = new System.Windows.Forms.Label();
            this.snakeColorChoice = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.Button();
            this.borderlessModeIndicator = new System.Windows.Forms.CheckBox();
            this.insaneModeIndicator = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.GrayText;
            this.pbCanvas.Location = new System.Drawing.Point(13, 13);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(541, 560);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(608, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // gameScore
            // 
            this.gameScore.AutoSize = true;
            this.gameScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameScore.Location = new System.Drawing.Point(729, 74);
            this.gameScore.Name = "gameScore";
            this.gameScore.Size = new System.Drawing.Size(49, 32);
            this.gameScore.TabIndex = 2;
            this.gameScore.Text = "00";
            // 
            // endText
            // 
            this.endText.AutoSize = true;
            this.endText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.endText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endText.ForeColor = System.Drawing.Color.Yellow;
            this.endText.Location = new System.Drawing.Point(215, 226);
            this.endText.Name = "endText";
            this.endText.Size = new System.Drawing.Size(170, 32);
            this.endText.TabIndex = 3;
            this.endText.Text = "Good Luck!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Snake Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current High Score:";
            // 
            // highScoreValue
            // 
            this.highScoreValue.AutoSize = true;
            this.highScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreValue.Location = new System.Drawing.Point(608, 183);
            this.highScoreValue.Name = "highScoreValue";
            this.highScoreValue.Size = new System.Drawing.Size(49, 32);
            this.highScoreValue.TabIndex = 7;
            this.highScoreValue.Text = "00";
            // 
            // snakeColorChoice
            // 
            this.snakeColorChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snakeColorChoice.FormattingEnabled = true;
            this.snakeColorChoice.Items.AddRange(new object[] {
            "Green",
            "Red",
            "Blue",
            "Yellow",
            "Purple",
            "Orange",
            "Pink",
            "Aqua"});
            this.snakeColorChoice.Location = new System.Drawing.Point(615, 534);
            this.snakeColorChoice.Name = "snakeColorChoice";
            this.snakeColorChoice.Size = new System.Drawing.Size(255, 40);
            this.snakeColorChoice.TabIndex = 8;
            this.snakeColorChoice.Text = "Green";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(651, 262);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(190, 40);
            this.start.TabIndex = 9;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // borderlessModeIndicator
            // 
            this.borderlessModeIndicator.AutoSize = true;
            this.borderlessModeIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderlessModeIndicator.Location = new System.Drawing.Point(614, 460);
            this.borderlessModeIndicator.Name = "borderlessModeIndicator";
            this.borderlessModeIndicator.Size = new System.Drawing.Size(255, 36);
            this.borderlessModeIndicator.TabIndex = 10;
            this.borderlessModeIndicator.Text = "Borderless Mode";
            this.borderlessModeIndicator.UseVisualStyleBackColor = true;
            // 
            // insaneModeIndicator
            // 
            this.insaneModeIndicator.AutoSize = true;
            this.insaneModeIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insaneModeIndicator.Location = new System.Drawing.Point(614, 418);
            this.insaneModeIndicator.Name = "insaneModeIndicator";
            this.insaneModeIndicator.Size = new System.Drawing.Size(204, 36);
            this.insaneModeIndicator.TabIndex = 11;
            this.insaneModeIndicator.TabStop = false;
            this.insaneModeIndicator.Text = "Insane Mode";
            this.insaneModeIndicator.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 614);
            this.Controls.Add(this.insaneModeIndicator);
            this.Controls.Add(this.borderlessModeIndicator);
            this.Controls.Add(this.start);
            this.Controls.Add(this.snakeColorChoice);
            this.Controls.Add(this.highScoreValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endText);
            this.Controls.Add(this.gameScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "SnAYYYke";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gameScore;
        private System.Windows.Forms.Label endText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label highScoreValue;
        private System.Windows.Forms.ComboBox snakeColorChoice;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.CheckBox borderlessModeIndicator;
        private System.Windows.Forms.CheckBox insaneModeIndicator;
    }
}

