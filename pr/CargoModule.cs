using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    public sealed class CargoModule : AbstractModule
    {
        public CargoModule(Coord position, int fuel) : base(position,fuel) { }

        public override void Act()
        {
            Coord newPosition = new Coord(position.X, position.Y - 1);
            SetPosition(newPosition);
            ConsumeFuel(2);
        }

    }
}
