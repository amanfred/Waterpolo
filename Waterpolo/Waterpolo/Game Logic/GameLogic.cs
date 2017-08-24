using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Waterpolo.Environment;
using Waterpolo.Constant;

namespace Waterpolo.Game_Logic
{
    public class GameLogic
    {        
        private Random randomNumber = new Random();
        private Pool _pool;
        public GameLogic(Pool p)
        {
            _pool = p;
        }

        public void GenerateBallPosition()
        {
            ConvertTile(Constant.Constant.Ball, Constant.Constant.Water);
            BallSetup();
            
        }

        public void BallSetup()
        {
            Point ballPoint = GenerateRandomPoint();
            while(!CheckWater(ballPoint))
            {
                ballPoint = GenerateRandomPoint();
            }           
        }

        public void ConvertTile(string tile, string convertTo)
        {
            for (int i = 0; i < _pool.Height; i++)
            {
                for (int j = 0; j < _pool.Width; j++)
                {
                   if (_pool[i, j].Contains(tile))
                    {
                        _pool[i, j] = convertTo;
                    }
                }
            }
        }
        
        //let's say ball can only be put into the water for now
        public bool CheckWater(Point p)
        {
            if (_pool.Grid[p.Y, p.X] == Constant.Constant.Water) return true;
            return false;
        }

        public void SetBallPosition()
        {

        }

        

        public Point GenerateRandomPoint()
        {
            Point p = new Point(-1,-1);
            p.X = randomNumber.Next(0, _pool.Width);
            p.Y = randomNumber.Next(0, _pool.Height);
            return p;            
        }

        public Pool GetPool()
        {
            return _pool;
        }

        public string[,] GetGrid()
        {
            return _pool.Grid;
        }
    }
}
