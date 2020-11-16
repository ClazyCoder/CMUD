using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CMUD
{
    class Object
    {
        protected string _name;
        protected double _hp;
        protected double _mp;
        protected int x;
        protected int y;
        protected int mapNum;
        protected string lore;
        public Object()
        {
            _name = "";
            _hp = 0.0;
            _mp = 0.0;
            x = 0;
            y = 0;
            mapNum = 0;
            lore = "";
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
        public double HP
        {
            get { return _hp; }
            set { _hp = value; }
        }
        public double MP
        {
            get { return _mp; }
            set { _mp = value; }
        }
    }
    class Player : Object
    {
        int _level;
        double Damage;
        Inventory _inven;
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
        public override void Attack(Object target)
        {
            target.HP -= Damage;
        }
    }
    class Monster : Object
    {
        Random _dice;
        Inventory _inven;
        public Monster(string _name, int _hp, int _mp)
        {
            this._name = _name;
            this._hp = _hp;
            this._mp = _mp;
            this.x = 0;
            this.y = 0;
            this.mapNum = 0;
            this._dice = new Random();
        }
        public override void Attack(Object target)
        {
            
        }
        public override void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
            // TODO : 추가 행동
        }
        public void Decision()
        {
            int act = _dice.Next(0, 100);
            if(act > 50)
            {

            }
            else
            {

            }
            // TODO : 랜덤으로 행동 수행
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
    class Inventory
    {
        List<Item> slot;
        public Inventory()
        {
            slot = new List<Item>();
        }
        public void AddItem(Item item)
        {
            slot.Add(item);
        }
        public void DelItem(Item item)
        {
            slot.Remove(item);
        }
        public void DelItem(int index)
        {
            slot.RemoveAt(index);
        }
        public bool findItem(string itemName)
        {
            foreach(Item i in slot)
            {
                if (i.Name == itemName)
                    return true;
            }
            return false;
        }
    }
    class Item
    {
        string name;
        double durability;
        string lore;
        public Item()
        {
            name = "";
            durability = 1.0;
            lore = "";
        }
        public Item(string name, double durability, string lore)
        {
            this.name = name;
            this.durability = durability;
            this.lore = lore;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
