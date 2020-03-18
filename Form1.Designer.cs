namespace PaperScissorsRock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GbxHumanChoice = new System.Windows.Forms.GroupBox();
            this.RbRock = new System.Windows.Forms.RadioButton();
            this.RbScissors = new System.Windows.Forms.RadioButton();
            this.RbPaper = new System.Windows.Forms.RadioButton();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.LblOutcome = new System.Windows.Forms.Label();
            this.PbxHuman = new System.Windows.Forms.PictureBox();
            this.PbxComputer = new System.Windows.Forms.PictureBox();
            this.GbxComputerChoice = new System.Windows.Forms.GroupBox();
            this.RbRockComputer = new System.Windows.Forms.RadioButton();
            this.RbScissorsComputer = new System.Windows.Forms.RadioButton();
            this.RbPaperComputer = new System.Windows.Forms.RadioButton();
            this.GbxHumanChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxHuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxComputer)).BeginInit();
            this.GbxComputerChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxHumanChoice
            // 
            this.GbxHumanChoice.Controls.Add(this.RbRock);
            this.GbxHumanChoice.Controls.Add(this.RbScissors);
            this.GbxHumanChoice.Controls.Add(this.RbPaper);
            this.GbxHumanChoice.Location = new System.Drawing.Point(12, 157);
            this.GbxHumanChoice.Name = "GbxHumanChoice";
            this.GbxHumanChoice.Size = new System.Drawing.Size(128, 91);
            this.GbxHumanChoice.TabIndex = 0;
            this.GbxHumanChoice.TabStop = false;
            this.GbxHumanChoice.Text = "Your Choice:";
            // 
            // RbRock
            // 
            this.RbRock.AutoSize = true;
            this.RbRock.Location = new System.Drawing.Point(6, 65);
            this.RbRock.Name = "RbRock";
            this.RbRock.Size = new System.Drawing.Size(51, 17);
            this.RbRock.TabIndex = 2;
            this.RbRock.TabStop = true;
            this.RbRock.Text = "Rock";
            this.RbRock.UseVisualStyleBackColor = true;
            this.RbRock.CheckedChanged += new System.EventHandler(this.RbAll_CheckedChanged);
            // 
            // RbScissors
            // 
            this.RbScissors.AutoSize = true;
            this.RbScissors.Location = new System.Drawing.Point(6, 42);
            this.RbScissors.Name = "RbScissors";
            this.RbScissors.Size = new System.Drawing.Size(64, 17);
            this.RbScissors.TabIndex = 1;
            this.RbScissors.TabStop = true;
            this.RbScissors.Text = "Scissors";
            this.RbScissors.UseVisualStyleBackColor = true;
            this.RbScissors.CheckedChanged += new System.EventHandler(this.RbAll_CheckedChanged);
            // 
            // RbPaper
            // 
            this.RbPaper.AutoSize = true;
            this.RbPaper.Location = new System.Drawing.Point(6, 19);
            this.RbPaper.Name = "RbPaper";
            this.RbPaper.Size = new System.Drawing.Size(53, 17);
            this.RbPaper.TabIndex = 0;
            this.RbPaper.TabStop = true;
            this.RbPaper.Text = "Paper";
            this.RbPaper.UseVisualStyleBackColor = true;
            this.RbPaper.CheckedChanged += new System.EventHandler(this.RbAll_CheckedChanged);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(12, 254);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(128, 23);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.Text = "Go!";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // LblOutcome
            // 
            this.LblOutcome.Location = new System.Drawing.Point(146, 12);
            this.LblOutcome.Name = "LblOutcome";
            this.LblOutcome.Size = new System.Drawing.Size(152, 128);
            this.LblOutcome.TabIndex = 2;
            // 
            // PbxHuman
            // 
            this.PbxHuman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbxHuman.BackgroundImage")));
            this.PbxHuman.Location = new System.Drawing.Point(12, 12);
            this.PbxHuman.Name = "PbxHuman";
            this.PbxHuman.Size = new System.Drawing.Size(128, 128);
            this.PbxHuman.TabIndex = 3;
            this.PbxHuman.TabStop = false;
            // 
            // PbxComputer
            // 
            this.PbxComputer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbxComputer.BackgroundImage")));
            this.PbxComputer.Location = new System.Drawing.Point(304, 12);
            this.PbxComputer.Name = "PbxComputer";
            this.PbxComputer.Size = new System.Drawing.Size(128, 128);
            this.PbxComputer.TabIndex = 4;
            this.PbxComputer.TabStop = false;
            this.PbxComputer.Click += new System.EventHandler(this.PbxComputer_Click);
            // 
            // GbxComputerChoice
            // 
            this.GbxComputerChoice.Controls.Add(this.RbRockComputer);
            this.GbxComputerChoice.Controls.Add(this.RbScissorsComputer);
            this.GbxComputerChoice.Controls.Add(this.RbPaperComputer);
            this.GbxComputerChoice.Location = new System.Drawing.Point(304, 157);
            this.GbxComputerChoice.Name = "GbxComputerChoice";
            this.GbxComputerChoice.Size = new System.Drawing.Size(128, 91);
            this.GbxComputerChoice.TabIndex = 5;
            this.GbxComputerChoice.TabStop = false;
            this.GbxComputerChoice.Text = "NPC\'s Choice:";
            // 
            // RbRockComputer
            // 
            this.RbRockComputer.AutoSize = true;
            this.RbRockComputer.Location = new System.Drawing.Point(6, 65);
            this.RbRockComputer.Name = "RbRockComputer";
            this.RbRockComputer.Size = new System.Drawing.Size(51, 17);
            this.RbRockComputer.TabIndex = 2;
            this.RbRockComputer.TabStop = true;
            this.RbRockComputer.Text = "Rock";
            this.RbRockComputer.UseVisualStyleBackColor = true;
            // 
            // RbScissorsComputer
            // 
            this.RbScissorsComputer.AutoSize = true;
            this.RbScissorsComputer.Location = new System.Drawing.Point(6, 42);
            this.RbScissorsComputer.Name = "RbScissorsComputer";
            this.RbScissorsComputer.Size = new System.Drawing.Size(64, 17);
            this.RbScissorsComputer.TabIndex = 1;
            this.RbScissorsComputer.TabStop = true;
            this.RbScissorsComputer.Text = "Scissors";
            this.RbScissorsComputer.UseVisualStyleBackColor = true;
            // 
            // RbPaperComputer
            // 
            this.RbPaperComputer.AutoSize = true;
            this.RbPaperComputer.Location = new System.Drawing.Point(6, 19);
            this.RbPaperComputer.Name = "RbPaperComputer";
            this.RbPaperComputer.Size = new System.Drawing.Size(53, 17);
            this.RbPaperComputer.TabIndex = 0;
            this.RbPaperComputer.TabStop = true;
            this.RbPaperComputer.Text = "Paper";
            this.RbPaperComputer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 281);
            this.Controls.Add(this.GbxComputerChoice);
            this.Controls.Add(this.PbxComputer);
            this.Controls.Add(this.PbxHuman);
            this.Controls.Add(this.LblOutcome);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.GbxHumanChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbxHumanChoice.ResumeLayout(false);
            this.GbxHumanChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxHuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxComputer)).EndInit();
            this.GbxComputerChoice.ResumeLayout(false);
            this.GbxComputerChoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxHumanChoice;
        private System.Windows.Forms.RadioButton RbRock;
        private System.Windows.Forms.RadioButton RbScissors;
        private System.Windows.Forms.RadioButton RbPaper;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Label LblOutcome;
        private System.Windows.Forms.PictureBox PbxHuman;
        private System.Windows.Forms.PictureBox PbxComputer;
        private System.Windows.Forms.GroupBox GbxComputerChoice;
        private System.Windows.Forms.RadioButton RbRockComputer;
        private System.Windows.Forms.RadioButton RbScissorsComputer;
        private System.Windows.Forms.RadioButton RbPaperComputer;
    }
}

