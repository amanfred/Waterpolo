using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Waterpolo.Environment
{
    public class Player : WaterObject
    {
        public string _player = Constant.Constant.HomePlayer;
        public Player(Pool p, Panel panelPool) : base (p, panelPool)
        {            
            GetPosition(_player);
            SetPosition();
            SetSize();
            color = Color.DarkBlue;
            rectangle = new Rectangle(position, size);
        }

        protected override void Draw()
        {
            paintEventArgs.Graphics.FillEllipse(new SolidBrush(color), rectangle);
        }
        protected override void SetSize()
        {
            size = new Size(Convert.ToInt32(columnSize), Convert.ToInt32(rowSize));
        }
    }
}
