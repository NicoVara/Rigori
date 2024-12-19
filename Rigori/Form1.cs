namespace Rigori
{
    public partial class Form1 : Form
    {
        //DoubleBuffered = true, sul form per fare andare la palla più veloce
        List<string> KeeperPosition = new List<string> {"left", "right", "top", "topLeft", "topRight"};
        List<PictureBox> goalTarget;
        int ballX = 0;
        int ballY = 0;
        int goal = 0;
        int miss = 0;
        string state;
        string playerTarget;
        bool aimSet = false;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            goalTarget = new List<PictureBox> { left, right, top, topLeft, topRight};
        }

        private void SetGoalTargetEvent(object sender, EventArgs e)
        {
            if(aimSet == true)
            { 
                return;
            }
            BallTimer.Start();
            KeeperTimer.Start();
            ChangeGoalKeeperImage();

            var senderObject = (PictureBox)sender;
            senderObject.BackColor = Color.Beige;

            if(senderObject.Tag.ToString() == "topRight")
            {
                ballX = -7;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }

            if (senderObject.Tag.ToString() == "right")
            {
                ballX = -11;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }

            if (senderObject.Tag.ToString() == "top")
            {
                ballX = 0;
                ballY = 20;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }

            if (senderObject.Tag.ToString() == "topLeft")
            {
                ballX = 8;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }

            if (senderObject.Tag.ToString() == "left")
            {
                ballX = 7;
                ballY = 8;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }

            CheckScore();
        }

        private void KeeperTimerEvent(object sender, EventArgs e)
        {
            switch(state)
            {

            }
        }

        private void BallTimerEvent(object sender, EventArgs e)
        {
            football.Left -= ballX;
            football.Top -= ballY;

            foreach(PictureBox x in goalTarget)
            {
                if(football.Bounds.IntersectsWith(x.Bounds))
                {
                    football.Location = new Point(430, 500);
                    ballX = 0;
                    ballY = 0;
                    aimSet = false;
                    BallTimer.Stop();
                }
            }
        }

        private void CheckScore()
        {

        }

        private void ChangeGoalKeeperImage()
        {

        }
    }
}
