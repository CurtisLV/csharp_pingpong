namespace csharp_pingpong
{
    public partial class Pong : Form
    {
        public Pong()
        {
            InitializeComponent();
        }

        // Location variables
        int cpuDirection = 5;
        int ballXCoordinate = 5;
        int ballYCoordinate = 5;

        // Score variable

        int playerScore = 0;
        int cpuScorx = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
