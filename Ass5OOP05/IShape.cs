using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass5OOP05
{
    internal interface IShape
    {        double Area { get; }
         void DisplayShapeInfo();
        
    }
    internal interface ICircle:IShape
    {        
        
    }
    internal interface IRectangle :IShape
    {     

    }
}
