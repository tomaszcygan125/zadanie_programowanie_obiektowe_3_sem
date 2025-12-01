using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public  abstract class Shape
    {
        public double X ; 
        public double Y;
        public double Width ;
        public double Height ;
        public virtual void Draw()
        {
            throw new NotImplementedException();
        }

    }
}
