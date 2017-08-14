using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Waterpolo.Constant;

namespace Waterpolo.Environment
{
    public class Ball : WaterObject
    {
        private double _ballSizeDivider = 3;
        public Ball (Pool p, Panel panelPool) : base (p, panelPool)
        {
            //setPosition(logicalPool.Width / 2, logicalPool.Height / 2);
            GetPosition();
            setSize();
            color = Color.Yellow;
            rectangle = new Rectangle(position, size);            
        }

        public override void Paint(PaintEventArgs e)
        {
            paintEventArgs = e;            
            Draw();
        }

        protected override void Draw()
        {            
            paintEventArgs.Graphics.FillEllipse(new SolidBrush(color), rectangle);
        }        

        protected override void setPosition(int width, int height)
        {
            position.X = Convert.ToInt32((width * columnSize) + columnSize / _ballSizeDivider);
            position.Y = Convert.ToInt32((height * rowSize) + rowSize / _ballSizeDivider);
        }

        protected override void setSize()
        {
            size = new Size(Convert.ToInt32(rowSize / _ballSizeDivider), Convert.ToInt32(rowSize / _ballSizeDivider));
        }

        private void GetPosition()
        {
           for (int i = 0; i < logicalPool.Height; i++)
            {
                for(int j = 0; j < logicalPool.Width; i++)
                {
                    if (logicalPool[i,j].Contains(Constant.Constant.Ball))
                    {
                        setPosition(i, j);
                        goto Finish;
                    }
                }
            }
            Finish:;
        }
    }
}
