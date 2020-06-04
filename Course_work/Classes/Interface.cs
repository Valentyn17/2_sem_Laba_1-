using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public interface Interface
    {

        void AddTask(Task task);
        void DeleteTask(int number);
        void DeleteWorker(int number);
        void AddWorker(Worker _worker);
        void Give_task(int number1,int number2);
    }
}
