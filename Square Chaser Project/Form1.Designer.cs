namespace Square_Chaser_Project
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel1 = new System.Windows.Forms.Label();
            this.scoreLabel2 = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scoreLabel1
            // 
            this.scoreLabel1.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel1.ForeColor = System.Drawing.Color.White;
            this.scoreLabel1.Location = new System.Drawing.Point(60, 14);
            this.scoreLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel1.Name = "scoreLabel1";
            this.scoreLabel1.Size = new System.Drawing.Size(150, 35);
            this.scoreLabel1.TabIndex = 0;
            // 
            // scoreLabel2
            // 
            this.scoreLabel2.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel2.ForeColor = System.Drawing.Color.White;
            this.scoreLabel2.Location = new System.Drawing.Point(280, 14);
            this.scoreLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel2.Name = "scoreLabel2";
            this.scoreLabel2.Size = new System.Drawing.Size(150, 35);
            this.scoreLabel2.TabIndex = 1;
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Stencil", 20.25F);
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(18, 205);
            this.winLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(508, 35);
            this.winLabel.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Stencil", 10F);
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(0, 467);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(316, 24);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "1. Yellow orps = Boost              ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stencil", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "3. Red Square = Losing Points               ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Stencil", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "4. Blue Orb = extra point or extra speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "First to 5 Points Win";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Stencil", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(270, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "2. White Square = Points";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 655);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.scoreLabel2);
            this.Controls.Add(this.scoreLabel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreLabel1;
        private System.Windows.Forms.Label scoreLabel2;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}

