using pr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    public class SimulationEngine
    {
        
        public bool TryStep(AbstractModule[][] map, int turnNumber, out int processedCount, ref int totalFuelConsumed)
        {
            processedCount = 0;

            if (map == null)
            {
                return false;
            }

            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] == null) continue;

                for (int j = 0; j < map[i].Length; j++)
                {
                    AbstractModule module = map[i][j];

                    if (module != null)
                    {
                        module.Act();
                        totalFuelConsumed += module.Fuel;
                        processedCount++;
                    }
                }
            }

            return processedCount > 0;
        }

        
        public static void ShiftMapCoords(AbstractModule[][] map, Coord offset)
        {
            if (map == null) return;

            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] == null) continue;

                for (int j = 0; j < map[i].Length; j++)
                {
                    AbstractModule module = map[i][j];

                    if (module != null)
                    {
                        Coord newPos = new Coord(module.Position.X + offset.X, module.Position.Y + offset.Y);
                        module.SetPosition(newPos);
                    }
                }
            }
        }
    }
}
