using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingCSharp
{
    public class House : IShape
    {
        public Rectangle walls { get; set; }
        public Rectangle doors { get; set; }
        public EquilateralTraingle roof { get; set; }

        double height = 0;
        double width = 0;

        public House(double h, double w)
        {
            width = w;
            height = h;

            walls = new Rectangle(h, w);
            doors = new Rectangle(h * 0.4, w * 0.2);
        }

        public byte[] DrawAsBitMap()
        {
            throw new NotImplementedException();
        }

        public string Summary()
        {
            return "House, H: " + height + " W: " + width ;
        }

        public void GrowBy(double percent)
        {
           walls.GrowBy(10);
           doors.GrowBy(10);
           roof.GrowBy(10);
        }
    }
}
