using System;
using System.Collections.Generic;
using System.Text;

namespace CMUD
{
    class Map
    {
        string _mapName;
        int[,] _map;
        Map(string _mapName)
        {
            this._mapName = _mapName;
            this._map = new int[100, 100];
        }
    }
}
