using AutoMapper;
using BusinessLayer.Models;
using DataAccessLayer;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System.Collections.Generic;
using BusinessLayer.IRepository;


namespace BusinessLayer
{
    public class ListManager : IRepositoryDTO
    {
        public readonly Mapper _mapper;

        private readonly DataAccessLayer.Interfaces.IRepository repository;
        public ListManager()
        {
            
            repository = new Repository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Task, TaskDTO>();
                cfg.CreateMap<Category, CategoryDTO>();
                cfg.CreateMap<CompletedTask, CompletedTaskDTO>();
            });
            _mapper = new Mapper(config);
        }

        public void CheckTaskStatus()
        {
            var taskList = repository.GetAllTasks();

            foreach (var task in taskList)
            {
                if (task.Status == "Done")
                {
                    repository.AddTask(task);

                    repository.RemoveTask(task.Id);
                }
            }
        }
        public IList<TaskDTO> GetAllTasksDTO()
        {
            var tasks = repository.GetAllTasks();

            return _mapper.Map<IList<TaskDTO>>(tasks);           
        }

        public void UpdateTaskStatus()
        {
            repository.UpdateTaskStatus();
        }
    }
}
