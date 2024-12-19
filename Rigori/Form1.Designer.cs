namespace Rigori
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_Scores = new Label();
            lbl_Missed = new Label();
            left = new PictureBox();
            topLeft = new PictureBox();
            right = new PictureBox();
            topRight = new PictureBox();
            top = new PictureBox();
            goalKeeper = new PictureBox();
            football = new PictureBox();
            KeeperTimer = new System.Windows.Forms.Timer(components);
            BallTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)left).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)right).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)top).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goalKeeper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)football).BeginInit();
            SuspendLayout();
            // 
            // lbl_Scores
            // 
            lbl_Scores.AutoSize = true;
            lbl_Scores.BackColor = Color.Transparent;
            lbl_Scores.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Scores.ForeColor = Color.White;
            lbl_Scores.Location = new Point(14, 10);
            lbl_Scores.Name = "lbl_Scores";
            lbl_Scores.Size = new Size(139, 40);
            lbl_Scores.TabIndex = 0;
            lbl_Scores.Text = "Scores: 0";
            // 
            // lbl_Missed
            // 
            lbl_Missed.AutoSize = true;
            lbl_Missed.BackColor = Color.Transparent;
            lbl_Missed.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Missed.ForeColor = Color.White;
            lbl_Missed.Location = new Point(733, 10);
            lbl_Missed.Name = "lbl_Missed";
            lbl_Missed.Size = new Size(146, 40);
            lbl_Missed.TabIndex = 1;
            lbl_Missed.Text = "Missed: 0";
            // 
            // left
            // 
            left.BackColor = Color.Yellow;
            left.Image = Properties.Resources.target;
            left.Location = new Point(202, 237);
            left.Name = "left";
            left.Size = new Size(40, 40);
            left.SizeMode = PictureBoxSizeMode.StretchImage;
            left.TabIndex = 2;
            left.TabStop = false;
            left.Tag = "left";
            left.Click += SetGoalTargetEvent;
            // 
            // topLeft
            // 
            topLeft.BackColor = Color.Yellow;
            topLeft.Image = Properties.Resources.target;
            topLeft.Location = new Point(202, 79);
            topLeft.Name = "topLeft";
            topLeft.Size = new Size(40, 40);
            topLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            topLeft.TabIndex = 3;
            topLeft.TabStop = false;
            topLeft.Tag = "topLeft";
            topLeft.Click += SetGoalTargetEvent;
            // 
            // right
            // 
            right.BackColor = Color.Yellow;
            right.Image = Properties.Resources.target;
            right.Location = new Point(675, 237);
            right.Name = "right";
            right.Size = new Size(40, 40);
            right.SizeMode = PictureBoxSizeMode.StretchImage;
            right.TabIndex = 4;
            right.TabStop = false;
            right.Tag = "right";
            right.Click += SetGoalTargetEvent;
            // 
            // topRight
            // 
            topRight.BackColor = Color.Yellow;
            topRight.Image = Properties.Resources.target;
            topRight.Location = new Point(675, 79);
            topRight.Name = "topRight";
            topRight.Size = new Size(40, 40);
            topRight.SizeMode = PictureBoxSizeMode.StretchImage;
            topRight.TabIndex = 5;
            topRight.TabStop = false;
            topRight.Tag = "topRight";
            topRight.Click += SetGoalTargetEvent;
            // 
            // top
            // 
            top.BackColor = Color.Yellow;
            top.Image = Properties.Resources.target;
            top.Location = new Point(438, 79);
            top.Name = "top";
            top.Size = new Size(40, 40);
            top.SizeMode = PictureBoxSizeMode.StretchImage;
            top.TabIndex = 6;
            top.TabStop = false;
            top.Tag = "top";
            top.Click += SetGoalTargetEvent;
            // 
            // goalKeeper
            // 
            goalKeeper.BackColor = Color.Transparent;
            goalKeeper.Image = Properties.Resources.stand_small;
            goalKeeper.Location = new Point(418, 169);
            goalKeeper.Name = "goalKeeper";
            goalKeeper.Size = new Size(82, 126);
            goalKeeper.SizeMode = PictureBoxSizeMode.AutoSize;
            goalKeeper.TabIndex = 7;
            goalKeeper.TabStop = false;
            // 
            // football
            // 
            football.BackColor = Color.Transparent;
            football.Image = Properties.Resources.football;
            football.Location = new Point(430, 500);
            football.Name = "football";
            football.Size = new Size(50, 51);
            football.SizeMode = PictureBoxSizeMode.AutoSize;
            football.TabIndex = 8;
            football.TabStop = false;
            // 
            // KeeperTimer
            // 
            KeeperTimer.Interval = 20;
            KeeperTimer.Tick += KeeperTimerEvent;
            // 
            // BallTimer
            // 
            BallTimer.Interval = 20;
            BallTimer.Tick += BallTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(901, 678);
            Controls.Add(football);
            Controls.Add(goalKeeper);
            Controls.Add(top);
            Controls.Add(topRight);
            Controls.Add(right);
            Controls.Add(topLeft);
            Controls.Add(left);
            Controls.Add(lbl_Missed);
            Controls.Add(lbl_Scores);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Rigori di Calcio";
            ((System.ComponentModel.ISupportInitialize)left).EndInit();
            ((System.ComponentModel.ISupportInitialize)topLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)right).EndInit();
            ((System.ComponentModel.ISupportInitialize)topRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)top).EndInit();
            ((System.ComponentModel.ISupportInitialize)goalKeeper).EndInit();
            ((System.ComponentModel.ISupportInitialize)football).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Scores;
        private Label lbl_Missed;
        private PictureBox left;
        private PictureBox topLeft;
        private PictureBox right;
        private PictureBox topRight;
        private PictureBox top;
        private PictureBox goalKeeper;
        private PictureBox football;
        private System.Windows.Forms.Timer KeeperTimer;
        private System.Windows.Forms.Timer BallTimer;
    }
}
