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

namespace Waterpolo
{
    public partial class Waterpolo : Form
    {
        public static Pool LogicalPool { get; set; }
        public static Ball LogicalBall { get; set; }       
        private int _inputHeight = 17;
        private int _inputWidth = 25;
        public Waterpolo()
        {
            InitializeComponent();
            LogicalPool = new Pool(_inputHeight, _inputWidth);
            BallPosition(LogicalPool.Height / 2, LogicalPool.Width / 2);
            LogicalBall = new Ball(LogicalPool, pool);
        }

        private new void Paint(object sender, PaintEventArgs e)
        {
            LogicalPool.Paint(sender, e, pool);
            LogicalBall.Paint(e);
        }

        private void BallPosition(int height, int width)
        {
            LogicalPool[height, width] = Constant.Constant.Ball;
        }
    }
}
