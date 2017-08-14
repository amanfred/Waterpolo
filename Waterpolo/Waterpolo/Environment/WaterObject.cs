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

        public abstract void Paint(PaintEventArgs e);
        protected abstract void Draw();
        protected abstract void setPosition(int width, int height);
        protected abstract void setSize();

    }
}
