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
        int cpuScorx = 0;

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
            //
        }
    }
}
