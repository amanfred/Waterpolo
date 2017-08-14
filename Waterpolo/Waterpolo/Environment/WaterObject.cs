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
        protected Color color { get; set; }  
        protected SolidBrush brush { get; set; }
        protected Point coordinates = new Point();
        protected Size size { get; set; }
        protected Pool logicalPool { get; set; }
        protected PaintEventArgs paintEventArgs { get; set; }
        protected int panelPoolHeight { get; set; }
        protected int panelPoolWidth { get; set; }
        protected int rowSize { get; set; }
        protected int columnSize { get; set; }
        protected Rectangle rectangle { get; set; }

        public abstract void Paint(PaintEventArgs e);
        protected abstract void Draw();
               
        
        
    }
}
