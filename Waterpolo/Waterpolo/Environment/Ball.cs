using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Waterpolo.Environment
{
    public class Ball : WaterObject
    {        
        public Ball (Pool p, Panel panelPool) : base (p, panelPool)
        {
            sizeDivider = 0.33;
            GetPosition(Constant.Constant.Ball);
            SetPosition();
            SetSize();
            color = Color.Yellow;
            rectangle = new Rectangle(position, size);            
        }
        

        protected override void Draw()
        {            
            paintEventArgs.Graphics.FillEllipse(new SolidBrush(color), rectangle);
        } 
    }
}
