using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingCSharp
{
    public class Group : IShape
    {
        public List<IShape> Members { get; set; }


      

        public byte[] DrawAsBitMap()
        {
            throw new NotImplementedException();
        }

        public void GrowBy(double percent)
        {
            foreach (var member in Members)
            {
                member.GrowBy(10);
            }
        }

        public string Summary()
        {
            throw new NotImplementedException();
        }

        public void AddMember(IShape NewMember)
        {
            Members.Add(NewMember);
        }
    }
}
