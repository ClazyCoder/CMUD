using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CMUD
{
    class Map
    {
        string _mapName;
        int[] _map;
        public Map(string _mapName)
        {
            this._mapName = _mapName;
            this._map = new int[10];
        }
        public Map(string _mapName, int[] _map)
        {
            this._mapName = _mapName;
            this._map = (int[])_map.Clone();
        }
    }
}
