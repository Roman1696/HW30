using BusinessLayer;
using System;


namespace HW30
{
    class Program
    {
        static void Main(string[] args)
        {
            var todoListManager = new ListManager();

            var tasks = todoListManager.GetAllTasksDTO();

            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Name} - {task.Status}");

                foreach (var ctg in task.Categories)
                {
                    Console.WriteLine($"{ctg.Name}");
                }
                Console.ReadKey();
            }

            todoListManager.CheckTaskStatus();

            todoListManager.UpdateTaskStatus();
        }
    }
}
