using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Waterpolo.Environment;
using Waterpolo.Game_Logic;
using Waterpolo.Constant;

namespace Waterpolo
{
    public partial class Waterpolo : Form
    {
        public static Pool LogicalPool { get; set; }
        public static Ball LogicalBall { get; set; }
        public static Player LogicalHomePlayer { get; set; }
        public static BallLogic ballLogic { get; set; }
        public static GameLogic GameLogic { get; set; }
        private int _inputHeight = 17;
        private int _inputWidth = 25;
        private PaintEventArgs paintEventArgs;
        public Waterpolo()
        {
            InitializeComponent();
            LogicalPool = new Pool(_inputHeight, _inputWidth);

            Position(LogicalPool.Height / 2, LogicalPool.Width / 2, Constant.Constant.Ball);            
            LogicalBall = new Ball(LogicalPool, pool);

            Position(5, 2, Constant.Constant.HomePlayer);
            LogicalHomePlayer = new Player(LogicalPool, pool);
            ballLogic = new BallLogic();
            
        }
        private void PlayGame()
        {
            
          //  ballLogic.ShowBox();
            GameLogic = new GameLogic(LogicalPool);
            GameLogic.GenerateBallPosition();
            LogicalBall.logicalPool = GameLogic.GetPool();            

        }

        private new void Paint(object sender, PaintEventArgs e)
        {
            paintEventArgs = e;
            LogicalPool.Paint(sender, e, pool);            
            LogicalHomePlayer.Paint(e);
            LogicalBall.Paint(e);
            
        }

        private void Position(int height, int width, string s)
        {
            LogicalPool[height, width] = s;
        }

        private void butttonBallCoordinates_Click(object sender, EventArgs e)
        {
            PlayGame();
        }
    }
}
