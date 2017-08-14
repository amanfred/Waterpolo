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
        public Ball(Pool p, Panel pool)
        {
            logicalPool = p;            
            
            panelPoolHeight = pool.Height; //panel size
            panelPoolWidth = pool.Width;
            //single square on the grid size
            rowSize = pool.Height / p.Height;
            columnSize = pool.Width / p.Width;
            coordinates.X = (p.Width / 2) * columnSize;
            coordinates.Y = (p.Height / 2) * rowSize;
            //color = Color.Yellow;
            color = Color.Yellow;
            size = new Size(columnSize /2, rowSize/2);            
            rectangle = new Rectangle(coordinates, size);      

        }

        public override void Paint(PaintEventArgs e)
        {
            paintEventArgs = e;
            Draw();
        }

        protected override void Draw()
        {
          //  coordinates.X = 12*50;
          //  coordinates.Y = 8*40;
            rectangle = new Rectangle(coordinates, size);


            paintEventArgs.Graphics.FillEllipse(new SolidBrush(color), rectangle);
        }
    }
}
