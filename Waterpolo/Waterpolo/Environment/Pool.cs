using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waterpolo.Constant;
using System.Drawing;
using System.Windows.Forms;

namespace Waterpolo.Environment
{

    public class Pool
    {
        public int Height { get; set; }
        public int Width { get; set; }   
        private int _poolHeight, _poolWidth;
        private string[,] _grid;
        private int _rowSize;
        private int _columnSize;
        public Color GridColor { get; set; }
        public Color WaterColor { get; set; }
        public Pen Pen { get; set; }
        private PaintEventArgs _paintEventArgs;        

        public Pool(int height, int width)
        {
            Height = height;
            Width = width;
            _grid = new string[height, width];
            //set default colors
            GridColor = Color.Black;
            WaterColor = Color.LightBlue;
            Pen = new Pen(new SolidBrush(GridColor));
            InitializeGrid();
        }

        public string this[int i, int j]
        {
            get { return _grid[i, j]; }
            set
            {
                _grid[i, j] = System.String.Format("{0}", value);
            }
        }

        private void InitializeGrid()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    _grid[i, j] = Constant.Constant.Water;
                }
            }
        }
        public void Paint(object sender, PaintEventArgs e, Panel pool)
        {
            _poolHeight = pool.Height; //panel size
            _poolWidth = pool.Width;          
            //single square on the grid size
            _rowSize = pool.Height / Height;
            _columnSize = pool.Width / Width;
            _paintEventArgs = e;
            // pool.BackColor = WaterColor;
             
            DrawWater();
            Draw();
        }

        private void Draw()
        {
            //Draw grid
            for (int i = 0; i <= Width; i++)            
                _paintEventArgs.Graphics.DrawLine(Pen, i * _columnSize, 0, i * _columnSize, _poolHeight);   

            for (int i = 0; i <= Height; i++)            
                _paintEventArgs.Graphics.DrawLine(Pen, 0, i * _rowSize, _poolWidth, i * _rowSize);
        }

        

        private void DrawWater()
        {
            Size size = new Size(_columnSize, _rowSize);
            Point coordinates = new Point(0, 0);
            Rectangle rectangle = new Rectangle(coordinates, size);
            _paintEventArgs.Graphics.FillRectangle(new SolidBrush(Color.LightBlue), rectangle);              
                   for (int i = 0; i < Height; i++)
                   {
                       for (int j = 0; j < Width; j++)
                       {
                           //Size size = new Size(_rowSize, _columnSize);
                           //Rectangle rectangle = new Rectangle(coordinates, size);
                           rectangle.Y = i * _rowSize;
                           rectangle.X = j * _columnSize;
                           _paintEventArgs.Graphics.FillRectangle(new SolidBrush(Color.LightBlue), rectangle);
                       }
                   }
        }
    }
}
