using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Task : Description_of_task
    {
        public Worker worker;
        public string position_for_task;
        public Task(string name_of_task, int prior, int complexity, int time, string short_description,string position_of_worker)
        {
            worker = null;
            if (name_of_task != null && short_description != null)
            {
                Name = name_of_task;
                description = short_description;
            }
            else throw new NullReferenceException();

            stage_of_execution = (Stage)0;

            if (complexity < 4 && complexity > 0)
                _complexity = (Complexity)(complexity-1);
            else throw new Exception("Incorrect number for complexity!");

            priority = (Prior)(prior-1);
            if (time > 0)
                this.time = time;
            else throw new Exception("Incorrect  value of time!");
            position_for_task = position_of_worker;
        }
    }
}
