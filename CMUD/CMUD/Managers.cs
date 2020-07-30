﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CMUD
{
    class MapManager
    {
        Map[] mapList;
        int _mapCount;
        public MapManager()
        {
            mapList = new Map[10];
        }
        public void LoadMap(string filename)
        {
            int[,] map = new int[100, 100];
            string[] lines = File.ReadAllLines(@filename);
            string mapName = lines[0];
            for(int i=1;i<lines.Length; i++)
            {
                for(int j=0;j<lines.Length; j++)
                {
                    map[i-1, j] = lines[i][j];
                }
            }
            mapList[_mapCount++] = new Map(mapName,map);
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
        public Object FindObject(string name)
        {
            Object temp = new Object();
            return temp;
        }
        public Object FindObject(int x, int y)
        {
            Object temp = new Object();
            return temp;
        }
    }
}
