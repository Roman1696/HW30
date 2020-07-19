using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace DataAccessLayer
{
    public class Repository:IRepository
    {
        public List<Task> GetAllTasks()
        {
            using (var context = new Context())
            {
                return context.Tasks.Include(task => task.Categories).ToList();
            }
        }
        public void AddTask(Task task)
        {
            using (var context = new Context())
            {
                var newCompletedTask = new CompletedTask() { Name = task.Name, Status = task.Status };

                context.CompletedTasks.Add(newCompletedTask);

                context.SaveChanges();
            }
        }
        public void UpdateTaskStatus()
        {
            using (var context = new Context())
            {
                var tasks = context.Tasks.ToList();
                tasks[1].Status = "Done";

                context.SaveChanges();
            }
        }

        public void RemoveTask(int id)
        {
            using (var context = new Context())
            {
                var task = context.Tasks.Where(a => a.Id == id).FirstOrDefault();

                context.Tasks.Remove(task);

                context.SaveChanges();
            }
        }       
    }
}
