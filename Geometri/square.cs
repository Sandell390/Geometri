using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class square
    {

        private int side;

        public int Side 
        {
            set 
            {
                this.side = value;
            }
            get 
            {
                return this.side;
            }
        }

        public square(int _side) 
        {
            side = _side;
        }

        public int omkreds() 
        {
            int omkreds = side * 4;


            return omkreds;
        }

        public int areal() 
        {
            int areal = side * side;

            return areal;
        }

    }
}
