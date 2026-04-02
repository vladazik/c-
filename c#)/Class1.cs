using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__
{
    public struct Figure2D
    {
        private double _x;
        private double _y;

        public Figure2D(double x, double y)
        {

            _x = x;
            _y = y;
        }

        public void Init(double x, double y)
        {
            _x = x;
            _y = y;
            Class2.Asd(this);
        }
    }
        // область видимоти блочная 
}
