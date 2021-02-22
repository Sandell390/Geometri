using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class square
    {

        private int side; //længde af side

        public int Side 
        {
            set 
            {
                side = value;
            }
            get 
            {
                return side;
            }
        }

        //Sætter side
        public square(int _side) 
        {
            side = _side;
        }

        //Udregner omkreds 
        public int omkreds() 
        {
            int omkreds = side * 4;


            return omkreds;
        }

        //Udregner areal
        public int areal() 
        {
            int areal = side * side;

            return areal;
        }

    }
}
