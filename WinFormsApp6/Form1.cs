namespace PongGameIT
{
    public partial class Form1 : Form
    {
        // True or false for controls
        bool MoveUp1, MoveDown1;
        bool MoveUp2, MoveDown2;

        // Variables for Player Y positioning
        private int P1Y = 171;
        private int P2Y = 171;

        // Variables for Player scores
        private int Player1Score = 0;
        private int Player2Score = 0;

        // Variables for Ball movement
        private int x = 394;
        private int y = 221;
        private int Xmovement = 20;
        private int Ymovement = 0;

        // New random class for random ball movement
        Random RNG = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Player 1 Controls
        private void P1UpButton_MouseDown(object sender, MouseEventArgs e)
        {
            MoveUp1 = true;
        }
        private void P1UpButton_MouseUp(object sender, MouseEventArgs e)
        {
            MoveUp1 = false;
        }
        private void P1DownButton_MouseDown(object sender, MouseEventArgs e)
        {
            MoveDown1 = true;
        }
        private void P1DownButton_MouseUp(object sender, MouseEventArgs e)
        {
            MoveDown1 = false;
        }

        //Player 2 Controls
        private void P2UpButton_MouseDown(object sender, MouseEventArgs e)
        {
            MoveUp2 = true;
        }
        private void P2UpButton_MouseUp(object sender, MouseEventArgs e)
        {
            MoveUp2 = false;
        }
        private void P2DownButton_MouseDown(object sender, MouseEventArgs e)
        {
            MoveDown2 = true;
        }
        private void P2DownButton_MouseUp(object sender, MouseEventArgs e)
        {
            MoveDown2 = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Updating players' locations
            Player1.Location = new Point(33, P1Y);
            Player2.Location = new Point(729, P2Y);

            // Player 1 movement
            if(MoveUp1 == true && Player1.Top > 10)
            {
                P1Y += -25;
            }
            if(MoveDown1 == true && Player1.Bottom < 445)
            {
                P1Y += 25;
            }

            // Player 2 movement
            if (MoveUp2 == true && Player2.Top > 10)
            {
                P2Y += -25;
            }
            if (MoveDown2 == true && Player2.Bottom < 445)
            {
                P2Y += 25;
            }

            // Updating ball movement
            x += Xmovement;
            y += Ymovement;
            PongBall.Location = new Point(x, y);

            // Ball collision with players
            // Redirects ball in other direction
            if(PongBall.Bounds.IntersectsWith(Player1.Bounds))
            {
                Xmovement = Xmovement * -1;
                Xmovement += 2; // Ball gets faster with every player rebound (buggy)
                Ymovement += RNG.Next(-15, 15);
            }
            if(PongBall.Bounds.IntersectsWith(Player2.Bounds))
            {
                Xmovement = Xmovement * -1;
                Xmovement += -2; // Ball gets faster with every player rebound (buggy)
                Ymovement += RNG.Next(-15, 15);
            }

            // Ball collision with ceiling and floor
            // Redirects ball in other direction
            if(PongBall.Bounds.IntersectsWith(TopBorder.Bounds))
            {
                Ymovement = Ymovement * -1;
            }
            if (PongBall.Bounds.IntersectsWith(BottomBorder.Bounds))
            {
                Ymovement = Ymovement * -1;
            }

            // Ball collision with the goals
            // Updates score and resets the positions and movement
            if (PongBall.Bounds.IntersectsWith(P1Goal.Bounds))
            {
                x = 394;
                y = 231; // Ball reset
                Player2Score += 1; // Player score +1
                P2Score.Text = Convert.ToString(Player2Score);
                P1Y = 171;
                P2Y = 171; // Players reset
                Thread.Sleep(500); // Small wait time
                Xmovement = -20; // Movement reset, x direction towards respective player
                Ymovement = 0;
            }
            if (PongBall.Bounds.IntersectsWith(P2Goal.Bounds))
            {
                x = 394;
                y = 231;
                Player1Score += 1;
                P1Score.Text = Convert.ToString(Player1Score);
                P1Y = 171;
                P2Y = 171;
                Thread.Sleep(500);
                Xmovement = 20;
                Ymovement = 0;
            }

            label1.Text = Convert.ToString(PongBall.Location);
            Invalidate();   

        }
    }
}