using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public delegate void MyDel ();  
    public class Project : Interface
    {
        
        
        
        private string name;
        public List<Task> tasks;
        public List<Worker> team;
        public Project(string name)
        {
            this.name = name;
            tasks = new List<Task>();
            team = new List<Worker>();
        }
        public string Name
        {
            get { return name; }
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
            
        }
        public void DeleteTask(int number)
        {
            if (tasks.Count >= number && tasks.Count > 0 && number > 0)
            {
                if (tasks[number - 1].worker != null)
                {
                    int i = find_worker_in_team(tasks[number - 1].worker);
                    team[i].with_task = false;
                    tasks.RemoveAt(number - 1);
                    Console.WriteLine("Task was  deleting!");
                }
                else
                    tasks.RemoveAt(number - 1);
            }
            else throw new Exception("We can't find task with this number");
        }
        public void DeleteWorker(int number)
        {
            if (team[number - 1].with_task == true)
                if (team.Count >= number && team.Count > 0 && number > 0)
                {
                    if (team[number - 1].with_task == true)
                    {
                        int i = find_task_with_worker(team[number - 1]);
                        tasks[i].worker = null;
                        tasks[i].stage_of_execution = (Stage)0;
                        team.RemoveAt(number - 1);
                    }
                    else
                    {
                        team.RemoveAt(number - 1);
                        
                    }
                }
                else throw new Exception("we can't find worker with this number");
            else
                team.RemoveAt(number - 1);
        }
        public void AddWorker(Worker worker)
        {
            team.Add(worker);
            
        }

        public void Give_task(int number_of_task, int number_of_worker)
        {
            if (number_of_worker <= team.Count && number_of_worker > 0)
            {
                if (number_of_task <= tasks.Count && number_of_task > 0)
                {
                    team[number_of_worker - 1].with_task = true;
                    tasks[number_of_task - 1].worker = team[number_of_worker - 1];
                    tasks[number_of_task - 1].stage_of_execution = (Stage)1;
                }
                else throw new Exception("Invalid value of number");
            }
            else throw new Exception("Invalid value of number");
        }

        private int find_worker_in_team(Worker worker)
        {
            int i = -1;
            bool temp = false;
            while (temp != true && i < team.Count - 1)
            {
                i++;
                temp = worker.Equals(team[i]);
            }
            return i;
        }

        private int find_task_with_worker(Worker worker)
        {
            int i = -1;
            bool temp = false;
            while (temp != true && i < tasks.Count - 1)
            {
                i++;
                temp = worker.Equals(tasks[i].worker);
            }

            return i;
        }
        
        public void output_tasks()
        {
            int i = 0;
            foreach (var element in tasks)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Task № {0}  \nName of task: {1}\nPriority:  {2} \nComplexity:  {3}", i + 1, element.Name, element.priority, element._complexity);
                Console.WriteLine("Stage of execution:   {0} \nDays for doing:  {1}", element.stage_of_execution, element.time);
                Console.WriteLine("Short description:   {0}", element.description);
                Console.WriteLine("Needed specialist:   {0}", element.position_for_task);
                Console.WriteLine();
                i++;
            }
        }
      
        public void output_free_tasks()
        {
            int i = 0;
            foreach (var element in tasks)
            {
                if (element.stage_of_execution == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Task № {0}  \nName of task: {1}\nPriority:  {2} \nComplexity:  {3}", i + 1, element.Name, element.priority, element._complexity);
                    Console.WriteLine("Stage of execution:   {0} \nDays for doing:  {1}", element.stage_of_execution, element.time);
                    Console.WriteLine("Short description:   {0}", element.description);
                    Console.WriteLine("Needed specialist:   {0}", element.position_for_task);
                    Console.WriteLine();
                }
                i++;
            }
        }
        public void output_workers()
        {
            int j = 0;
            foreach (var element in team)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Worker № {0}     Name: {1} \nAge: {2}", j + 1, element.Name, element.Age);
                Console.WriteLine("Position:   {0} \nWith task: {1}", element.Position, element.with_task);
                j++;
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public int output_free_workers(string spec)
        {
            int j = 0;
            int counter = 0;
            foreach (var element in team)
            {
                if (element.Position == spec)
                {
                    if (!element.with_task)

                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Worker № {0}     Name: {1} \nAge: {2}", j + 1, element.Name, element.Age);
                        Console.WriteLine("Position:   {0} \nWith task: {1}", element.Position, element.with_task);
                        counter++;
                    }
                }
                j++;
            }
            if (counter == 0)
            {
                Console.WriteLine("There are no free workers with such speciality");
                return -1;
            }

            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Input number of worker for this task:  ");

                int choice_worker = Convert.ToInt32(Console.ReadLine());
                return choice_worker;
            }

        }
    }
}
