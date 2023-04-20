namespace csharp_pingpong
{
    public partial class Pong : Form
    {
        // Location variables
        int cpuDirection = 5;
        int ballXCoordinate = 5;
        int ballYCoordinate = 5;

        // Score variables

        int playerScore = 0;
        int cpuScore = 0;

        // Size variables

        int bottomBoundry;
        int centerPoint;
        int xMidpoint;
        int yMidpoint;

        // Detection variables
        bool playerDetectedUp;
        bool playerDetectedDown;

        // Special keys
        int spaceBarClicked = 0;

        public Pong()
        {
            InitializeComponent();
            bottomBoundry = ClientSize.Height - player1.Height;
            xMidpoint = ClientSize.Width / 2;
            yMidpoint = ClientSize.Height / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void pongTimer_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);
            // Adjust where the ball is
            pongBall.Top -= ballYCoordinate;
            pongBall.Left -= ballXCoordinate;

            //Make CPU move
            cpuPlayer.Top += cpuDirection;

            // check if CPU has reached top or bottom
            if (cpuPlayer.Top < 0 || cpuPlayer.Top > bottomBoundry)
            {
                cpuDirection = -cpuDirection;
            }
            // Check if ball has exited left side of the screen
            if (pongBall.Left < 0)
            {
                pongBall.Left = xMidpoint;
                pongBall.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                cpuScore++;
                cpuScoreLabel.Text = cpuScore.ToString();
            }

            // check if ball has exited right side of the screen
            if (pongBall.Left + pongBall.Width > ClientSize.Width)
            {
                pongBall.Left = xMidpoint;
                pongBall.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                playerScore++;
                playerScoreLabel.Text = playerScore.ToString();
            }

            // Ensure the ball is within the boundries of the screen
            if (pongBall.Top < 0 || pongBall.Top + Height > ClientSize.Height)
            {
                ballYCoordinate = -ballYCoordinate;
            }

            // Check if the ball hits the player or the cpu paddle
            if (
                pongBall.Bounds.IntersectsWith(player1.Bounds)
                || pongBall.Bounds.IntersectsWith(cpuPlayer.Bounds)
            )
            {
                ballXCoordinate -= ballXCoordinate;
            }

            // Move player up
            if (playerDetectedUp == true && player1.Top > 0)
            {
                player1.Top -= 10;
            }

            // Move player down
            if (playerDetectedDown == true && player1.Top < bottomBoundry)
            {
                player1.Top += 10;
            }

            // Check for winner
            if (playerScore >= 10)
            {
                pongTimer.Stop();
            }
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            // If player presses the up arrow, move paddle upwards
            if (player1)
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            //
        }
    }
}
