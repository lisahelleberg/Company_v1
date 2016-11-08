using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class Worker : Employee
    {
        public string skill;

        public Worker(string name, int salaryPerMonth, string skill) : base(name, salaryPerMonth)
        {
            this.skill = skill;      
        }

        public virtual void SetSkill(string newSkill)
        {
            this.skill = newSkill;
        }

    }
}
