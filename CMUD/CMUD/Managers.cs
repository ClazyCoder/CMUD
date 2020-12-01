using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Collections;
using System.Data.SqlClient;

namespace CMUD
{
    class MapManager
    {
        List<Map> mapList;
        int _mapCount;

        private static readonly Lazy<MapManager> _instance = new Lazy<MapManager>(() => new MapManager());
        private MapManager()
        {
            mapList = new List<Map>();
        }
        public static MapManager Instance
        {
            get { return _instance.Value; }
        }
        public void LoadMap(string filename)
        {
            // TODO : 파일로부터 Map 불러오기
        }
        public void LoadMapsFromDB()
        {
            // TODO : DataBase에서 Map 정보 불러오기
        }
    }
    class ObjectManager
    {
        int ObjectCount
        {
            get { return objList.Count; }
        }
        List<Object> objList;
        Random _dice;

        private static readonly Lazy<ObjectManager> _instance = new Lazy<ObjectManager>(() => new ObjectManager());
        private ObjectManager()
        {
            _dice = new Random();
            objList = new List<Object>();
        }
        public static ObjectManager Instance
        {
            get { return _instance.Value; }
        }
        public void AddObject(Object obj)
        {
            this.objList.Add(obj);
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
            // TODO : 오브젝트 찾기(이름으로)
            Object temp = new Object();
            return temp;
        }
        public Object FindObject(int x, int y)
        {
            // TODO : 오브젝트 찾기(특정위치)
            Object temp = new Object();
            return temp;
        }
    }
    public class DatabaseManager
    {
        string ip;          // 디비 아이피
        string port;        // 디비 포트
        string id;          // 디비 아이디
        string pw;          // 디비 비밀번호
        SqlConnection conn; // 디비 커넥션

        private static readonly Lazy<DatabaseManager> _instance = new Lazy<DatabaseManager>(() => new DatabaseManager());
        private DatabaseManager()
        {
            // TODO : DB 연결 및 초기화
            conn = new SqlConnection();
        }
        public static DatabaseManager Instance
        {
            get { return _instance.Value; }
        }
    }
}
