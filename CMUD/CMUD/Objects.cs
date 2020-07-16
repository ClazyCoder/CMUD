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
        public Object()
        {

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
        }
    }
}
