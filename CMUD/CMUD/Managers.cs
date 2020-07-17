using System;
using System.Collections.Generic;
using System.Text;

namespace CMUD
{
    class MapManager
    {
        Map[] mapList;
        public MapManager()
        {
            mapList = new Map[10];
        }
    }
    class ObjectManager
    {
        Object[] objList;
        public ObjectManager()
        {
            objList = new Object[100];
        }
    }
}
