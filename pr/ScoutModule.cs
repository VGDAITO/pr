using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    public sealed class ScoutModule : AbstractModule
    {
        public ScoutModule(Coord position, int fuel) : base(position, fuel)
        {
        }
        public override void Act()
        {
            Coord newPosition = new Coord(position.X + 1, position.Y);
            SetPosition(newPosition);
            ConsumeFuel(1);


        }
    }
}
