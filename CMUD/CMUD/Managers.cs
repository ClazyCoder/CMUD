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
        public void LoadMapsFromDB()
        {
            // TODO : DataBase에서 map 정보 불러오기
        }
    }
    class ObjectManager
    {
        int objCount;
        Object[] objList;
        Random _dice;
        public ObjectManager()
        {
            _dice = new Random();
            objCount = 0;
            objList = new Object[100];
        }
        public void AddObject(Object obj)
        {
            this.objList[objCount++] = obj;
        }
        public void DoRandomEvents()
        {
            // TODO : 플레이어 제외한 오브젝트들 이벤트 랜덤으로 수행시키기
            int act = _dice.Next(0, 100);
            if(act < 10)
            {

            }
            else if(act < 20)
            {

            }
            else
            {

            }
        }
        public void LoadObjects(string filename)
        {
            // TODO : 파일에서 저장된 오브젝트들 불러오기
        }
    }
}
