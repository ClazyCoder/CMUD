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
        public virtual void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual string GetInfo()
        {
            string info = "이름 : " + this._name + "\n";
            info = info + "체력 : " + this._hp + "\n";
            info = info + "마력 : " + this._mp + "\n";
            info = info + "위치 : (" + this.x + ", " + this.y + ")\n";
            return info;
        }
        public virtual void Attack(Object target)
        {
            target._hp -= 1;
        }
    }
    class Player : Object
    {
        int _level;
        public Player(string _name, int _hp, int _mp)
        {
            this._name = _name;
            this._hp = _hp;
            this._mp = _mp;
            this._level = 0;
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
    class NPC : Object
    {
        public NPC(string _name, int _hp, int _mp)
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
