using System;
using System.Collections.Generic;
using Classes;
namespace Course_work
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Project> projects = new List<Project>();
            Project project1 = new Project("Auto");
            Task task1 = new Task("Do wheel", 1, 1, 3, "Do four wheels and install them", "mechanic");
            Worker worker1 = new Worker("Yuriy Kovalenko", 18, "mechanic");
            Task task2 = new Task("Do engine", 2, 2, 6, "Do Engine with 4 cylindres", "engineer");
            Worker worker2 = new Worker("Arthur Ladchenko", 27, "engineer");
            Task task3 = new Task("Creating design", 2, 2, 6, "Create a design of auto, draw a maket", "designer");
            Worker worker3 = new Worker("Ivan Petrov", 23, "designer");
            Worker worker4 = new Worker("Petro Denysov",21,"mechanic");
            Worker worker5 = new Worker("Denys Koval",32,"engineer");
            Task task4 = new Task("Do pistons", 3, 3, 4, "Do 8 pistons for engine(Mark A-13)", "engineer");
            Task task5 = new Task("Check the engine", 1, 2, 4, "Check all pistons and the spark  plugs", "mechanic");
            
            projects.Add(project1);
            projects[0].AddTask(task1);
            projects[0].AddWorker(worker1);
            projects[0].AddTask(task2);
            projects[0].AddWorker(worker2);
            projects[0].AddTask(task3);
            projects[0].AddWorker(worker3);
            projects[0].Give_task(2, 2);
            projects[0].AddWorker(worker4);
            projects[0].AddTask(task4);
            projects[0].AddWorker(worker5);
            projects[0].AddTask(task5);
            projects[0].Give_task(1, 4);


            bool alive = true;
            while (alive)
            {
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkGreen; // выводим список команд зеленым цветом
                Console.WriteLine("1. Show projects \t 2. Add project  \t 3. Exit");
                Console.WriteLine("Input number:");
                Console.ForegroundColor = color;
                try
                {
                    int command = Convert.ToInt32(Console.ReadLine());

                    switch (command)
                    {
                        case 1:
                            ShowProjects(projects);
                            break;
                        case 2:
                            AddProject(projects);
                            break;
                        case 3:
                            alive = false;
                            continue;
                    }

                }
                catch (Exception ex)
                {
                    // выводим сообщение об ошибке красным цветом
                    color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = color;
                }
            }

        }




        static void ShowProjects(List<Project> projects)
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor =ConsoleColor.Blue;
            if (projects.Count != 0)
            {
                int i = 0;
                foreach (var element in projects)
                {
                    i++;
                    
                    Console.WriteLine("Project № {0}  Name:  {1}", i, element.Name);
                }
            }
            
            else throw new Exception("There not available projects");
            Console.ForegroundColor = color;
            Console.WriteLine("Please choose a number of project");
            int command = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("№ {0}  Name:  {1}", command, projects[command - 1].Name);
            Console.ForegroundColor = color;
            bool alive = true;
            
            while (alive)
            {
                
                Console.ForegroundColor = ConsoleColor.DarkGreen; // выводим список команд зеленым цветом
                Console.WriteLine("1.Show tasks \t 2. Show workers  \t 3. Add task \t 4.Add worker");
                Console.WriteLine("5. Delete task \t 6. Delete worker \t 7. Find worker for not doing tasks\t 8. Go to main menu");
                Console.WriteLine("Input number:");
                Console.ForegroundColor = color;

                try
                {
                    int command1 = Convert.ToInt32(Console.ReadLine());
                    MyDel output = new MyDel(projects[command - 1].output_tasks);
                    switch (command1)
                    {
                        
                        case 1:
                             output();
                            Console.ForegroundColor = color;
                            break;

                        case 2:
                           projects[command - 1].output_workers();
                            Console.ForegroundColor = color;
                            break;


                        case 3:
                            Console.WriteLine("Adding task");

                            Console.Write("Input name:   ");
                            string name = Console.ReadLine();

                            Console.Write("Input number of priority(1-low,2-normal,3-important):  ");
                            int pr = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Input number of complexity (1-Easy,2-Medium,3-Hard)  :   ");
                            int compl = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Input time for doing:  ");
                            int time = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Write short description:  ");
                            string descript = Console.ReadLine();
                            Console.Write("Write position of needed worker: ");
                            string pos = Console.ReadLine();
                            Task task1 = new Task(name, pr, compl, time, descript, pos);
                            projects[command - 1].AddTask(task1);
                            
                            
                            break;

                        case 4:
                            
                            Console.Write("Input name of worker:  ");
                            string name1 = Console.ReadLine();
                            Console.Write("Input age of worker:  ");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Input speciality of worker:  ");
                            string spec = Console.ReadLine();
                            Worker worker1 = new Worker(name1, age, spec);
                            projects[command - 1].AddWorker(worker1);
                            
                            break;
                        case 5:
                            
                            output();
                            Console.ForegroundColor = color;
                            Console.Write("Input number of task that you want to delete:  ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            
                            projects[command - 1].DeleteTask(num);
                            Console.WriteLine("Task was deleted!");
                            
                            break;
                        case 6:
                            projects[command - 1].output_workers();
                            
                            Console.ForegroundColor = color;
                            Console.Write("Input number of worker that you want to dismiss:  ");
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            projects[command - 1].DeleteWorker(num1);
                            Console.WriteLine("Worker was dismissed!");
                            
                             break;

                        case 7:
                            Console.WriteLine("Free tasks");
                            projects[command - 1].output_free_tasks();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("Choose number of task:");
                            int choice=Convert.ToInt32(Console.ReadLine());
                            if (projects[command - 1].tasks[choice - 1].stage_of_execution == 0)
                            {
                                string speciality = projects[command - 1].tasks[choice - 1].position_for_task;
                                Console.WriteLine("Free workers:");
                                int c = projects[command - 1].output_free_workers(speciality);
                                Console.ForegroundColor = color;
                                if (c < 0)
                                {
                                    break;
                                }
                                else
                                {
                                    projects[command - 1].Give_task(choice, c);
                                    Console.WriteLine("Task was given to worker");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Incorrect value!");
                                break;
                            }
                        case 8:
                            alive = false;
                            continue;
                        default:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Try again please, incorrect value!");
                                Console.ForegroundColor = color;
                                break;
                            }

                    }
                }
                catch (Exception ex)
                {
                    // выводим сообщение об ошибке красным цветом
                    color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = color;
                }
            }
        }


    static void AddProject(List<Project> projects)
    {
        Console.WriteLine("Input name of project:");
        string name = Console.ReadLine();
        Project project = new Project(name);
        projects.Add(project);
    }
    }
}

