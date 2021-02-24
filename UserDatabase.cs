using System;
using System.Collections.Generic;
using System.Text;

namespace Storage
{
    internal class UserDatabase
    {

        private bool active = false;
        private string name = "Admin";
        private string pass = "123456";
        private int balance = 4000;
        private int spent = 0;

        protected string Name { get { return name; } set { name = value; } }
        protected string Pass { get { return pass; } set { pass = value; } }
        protected int Balance { get { return balance; } set { balance = value; } }
        protected int Spent { get { return spent; } set { spent = value; } }
        protected bool Active { get { return active; } set { active = value; } }
    }
}
