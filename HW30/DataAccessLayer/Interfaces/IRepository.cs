using DataAccessLayer.Models;
using System.Collections.Generic;



namespace DataAccessLayer.Interfaces
{
    public interface IRepository
    {
        List<Task> GetAllTasks();
        void AddTask(Task task);
        void RemoveTask(int id);        
        void UpdateTaskStatus();
    }
}
