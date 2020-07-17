using System;
using System.Collections.Generic;
using System.Text;

namespace CMUD
{
    class Object
    {
        protected string _name;
        protected int _hp;
        protected int _mp;
        protected int x;
        protected int y;
        protected int mapNum;
        public Object()
        {

        }
        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Player : Object
    {
        public Player(string _name, int _hp, int _mp)
        {
            this._name = _name;
            this._hp = _hp;
            this._mp = _mp;
            this.x = 0;
            this.y = 0;
            this.mapNum = 0;
        }
    }
    class Monster : Object
    {
        public Monster(string _name, int _hp, int _mp)
        {
            this._name = _name;
            this._hp = _hp;
            this._mp = _mp;
            this.x = 0;
            this.y = 0;
            this.mapNum = 0;
        }
    }
}
