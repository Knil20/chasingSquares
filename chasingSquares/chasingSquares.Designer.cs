namespace chasingSquares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.p1ScoreLabel = new System.Windows.Forms.Label();
            this.p2ScoreLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timeslowTimer = new System.Windows.Forms.Timer(this.components);
            this.tSLabel1 = new System.Windows.Forms.Label();
            this.tSLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p1ScoreLabel
            // 
            this.p1ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p1ScoreLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.p1ScoreLabel.Location = new System.Drawing.Point(1, 9);
            this.p1ScoreLabel.Name = "p1ScoreLabel";
            this.p1ScoreLabel.Size = new System.Drawing.Size(242, 66);
            this.p1ScoreLabel.TabIndex = 0;
            this.p1ScoreLabel.Tag = "0";
            this.p1ScoreLabel.Text = "Player 1 Score = 0";
            this.p1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2ScoreLabel
            // 
            this.p2ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p2ScoreLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.p2ScoreLabel.Location = new System.Drawing.Point(249, 9);
            this.p2ScoreLabel.Name = "p2ScoreLabel";
            this.p2ScoreLabel.Size = new System.Drawing.Size(242, 66);
            this.p2ScoreLabel.TabIndex = 1;
            this.p2ScoreLabel.Tag = "0";
            this.p2ScoreLabel.Text = "Player 2 Score =  0";
            this.p2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(12, 395);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(476, 60);
            this.winLabel.TabIndex = 2;
            this.winLabel.Tag = "0";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // timeslowTimer
            // 
            this.timeslowTimer.Interval = 20;
            this.timeslowTimer.Tick += new System.EventHandler(this.timeslowTimer_Tick);
            // 
            // tSLabel1
            // 
            this.tSLabel1.BackColor = System.Drawing.Color.Transparent;
            this.tSLabel1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSLabel1.ForeColor = System.Drawing.Color.White;
            this.tSLabel1.Location = new System.Drawing.Point(12, 75);
            this.tSLabel1.Name = "tSLabel1";
            this.tSLabel1.Size = new System.Drawing.Size(219, 43);
            this.tSLabel1.TabIndex = 3;
            this.tSLabel1.Tag = "0";
            this.tSLabel1.Text = "Time Slow Count P1 = 0 \r\nPress E\r\n";
            this.tSLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tSLabel2
            // 
            this.tSLabel2.BackColor = System.Drawing.Color.Transparent;
            this.tSLabel2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSLabel2.ForeColor = System.Drawing.Color.White;
            this.tSLabel2.Location = new System.Drawing.Point(264, 75);
            this.tSLabel2.Name = "tSLabel2";
            this.tSLabel2.Size = new System.Drawing.Size(224, 43);
            this.tSLabel2.TabIndex = 4;
            this.tSLabel2.Tag = "0";
            this.tSLabel2.Text = "Time Slow Count P2 = 0\r\nPress L\r\n";
            this.tSLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.tSLabel2);
            this.Controls.Add(this.tSLabel1);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.p2ScoreLabel);
            this.Controls.Add(this.p1ScoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chasingSquares";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label p1ScoreLabel;
        private System.Windows.Forms.Label p2ScoreLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer timeslowTimer;
        private System.Windows.Forms.Label tSLabel1;
        private System.Windows.Forms.Label tSLabel2;
    }
}

