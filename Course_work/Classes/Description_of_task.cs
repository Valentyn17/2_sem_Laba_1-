using System;

namespace Classes
{
    public enum Stage{ Not_doing, InProcess, Done };
    public enum Complexity { Easy, Medium, Hard};
    public enum Prior {low, normal, important};
    public abstract class Description_of_task
    {
        public string Name{ get; set; }
        public Stage stage_of_execution { get; set; }
        public Complexity _complexity { get; set; }
        public int time { get; set; }
        public Prior priority { get; set; }
        public string description { get; set; }
    }
}
