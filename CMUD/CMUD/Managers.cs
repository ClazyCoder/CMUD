using System;
using System.Collections.Generic;
using System.IO;
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
        public void LoadMaps(string filename)
        {
            // TODO : 파일 열기(형식구상)
        }
    }
    class ObjectManager
    {
        int objCount;
        Object[] objList;
        public ObjectManager()
        {
            objCount = 0;
            objList = new Object[100];
        }
        public void addObject(Object obj)
        {
            this.objList[objCount++] = obj;
        }
    }
}
