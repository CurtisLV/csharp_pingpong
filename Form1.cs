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

            //// Calculate predicted position of the ball
            //float time = (cpuPlayer.Top - pongBall.Top) / (float)ballYCoordinate;
            //float predictedBallPosition = pongBall.Left + ballXCoordinate * time;

            //// Move CPU paddle towards predicted position
            //float k = 0.1f;
            //int predictedPaddlePosition = (int)(predictedBallPosition - cpuPlayer.Width / 2);
            //cpuPlayer.Top = (int)((1 - k) * cpuPlayer.Top + k * predictedPaddlePosition);

            //// Clamp CPU paddle position within screen boundaries
            //cpuPlayer.Top = Math.Max(cpuPlayer.Top, 0);
            //cpuPlayer.Top = Math.Min(cpuPlayer.Top, bottomBoundry - cpuPlayer.Height);

            Random rnd = new Random();
            int randomNumber = rnd.Next(25, 160);

            // Move CPU paddle towards predicted position
            float k = 0.1f;
            float predictedBallPosition =
                pongBall.Top
                + (pongBall.Top - cpuPlayer.Top)
                    * (pongBall.Left - cpuPlayer.Right)
                    / (randomNumber * -1f);
            float distanceToPredictedBall = predictedBallPosition - cpuPlayer.Top - randomNumber;

            if (Math.Abs(distanceToPredictedBall) < cpuPlayer.Height / 2)
            {
                cpuPlayer.Top = (int)(cpuPlayer.Top + distanceToPredictedBall * k);
            }
            else
            {
                cpuPlayer.Top = (int)(
                    cpuPlayer.Top + Math.Sign(distanceToPredictedBall) * cpuPlayer.Height / 2 * k
                );
            }

            // Clamp CPU paddle position within screen boundaries
            cpuPlayer.Top = Math.Max(cpuPlayer.Top, 0);
            cpuPlayer.Top = Math.Min(cpuPlayer.Top, bottomBoundry);

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
            if (pongBall.Top < 0 || pongBall.Top + pongBall.Height > ClientSize.Height)
            {
                ballYCoordinate = -ballYCoordinate;
            }

            // Check if the ball hits the player or the cpu paddle
            if (
                pongBall.Bounds.IntersectsWith(player1.Bounds)
                || pongBall.Bounds.IntersectsWith(cpuPlayer.Bounds)
            )
            {
                //ballXCoordinate = -ballXCoordinate;
                bool ballGoingLeft = ballXCoordinate < 0;
                ballXCoordinate = -ballXCoordinate;

                // Check if paddle is moving in the opposite direction
                if ((playerDetectedUp && ballGoingLeft) || (playerDetectedDown && !ballGoingLeft))
                {
                    ballYCoordinate = -ballYCoordinate;
                }
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
            if (e.KeyCode == Keys.Up)
            {
                playerDetectedUp = true;
            }

            // If player presses the down arrow, move paddle down
            if (e.KeyCode == Keys.Down)
            {
                playerDetectedDown = true;
            }

            // C - for selecting character
            if (e.KeyCode == Keys.C)
            {
                Form character = new CharacterForm();
                character.Owner = this;
                pongTimer.Stop();
                character.Show();
            }

            // Pause function on spacebar
            if (e.KeyCode == Keys.Space)
            {
                if (spaceBarClicked % 2 == 0)
                {
                    pongTimer.Stop();
                }
                else
                {
                    pongTimer.Start();
                }
                spaceBarClicked++;
            }
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                playerDetectedUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                playerDetectedDown = false;
            }
        }
    }
}
