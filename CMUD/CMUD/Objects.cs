using System;
using System.Collections;
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
        protected string lore;
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
            // 공격 추가
        }
        public override void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
            // 추가 행동
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
            // 랜덤으로 행동 수행
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
    }
    class Item
    {
        string name;
        double durability;
        string lore;
    }
}
