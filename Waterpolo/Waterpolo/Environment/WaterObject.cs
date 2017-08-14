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
    public abstract class WaterObject
    {
        protected Color color;
        protected SolidBrush brush;
        protected Point position = new Point();
        protected Size size = new Size();        
        protected PaintEventArgs paintEventArgs;
        protected int panelPoolHeight;
        protected int panelPoolWidth;
        protected int rowSize;
        protected int columnSize;       
        protected Rectangle rectangle;
        protected double sizeDivider;
        protected Pool logicalPool { get; set; }

        public WaterObject(Pool p, Panel panelPool)
        {
            logicalPool = p;
            panelPoolHeight = panelPool.Height; //panel size
            panelPoolWidth = panelPool.Width;
            //single square on the grid size
            rowSize = panelPool.Height / p.Height;
            columnSize = panelPool.Width / p.Width;
        }

        public virtual void Paint(PaintEventArgs e)
        {
            paintEventArgs = e;
            Draw();
        }
        protected abstract void Draw();
        protected virtual void SetPosition()
        {
            position.X = Convert.ToInt32((position.X * columnSize) + columnSize * sizeDivider);
            position.Y = Convert.ToInt32((position.Y * rowSize) + rowSize * sizeDivider);
        }
        protected virtual void SetSize()
        {            
            size = new Size(Convert.ToInt32(columnSize * sizeDivider), Convert.ToInt32(rowSize * sizeDivider));
        }
        public virtual void GetPosition(string namedObject)
        {
            for (int i = 0; i < logicalPool.Height; i++)
            {
                for (int j = 0; j < logicalPool.Width; j++)
                {
                    if (logicalPool[i, j].Contains(namedObject))
                    {
                        position.X = j;
                        position.Y = i;
                        goto Finish;
                    }
                }
            }
            Finish:;
        }

    }
}
