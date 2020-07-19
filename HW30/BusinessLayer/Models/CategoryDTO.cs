using System.Collections.Generic;


namespace BusinessLayer.Models
{
    public class CategoryDTO
    {
        public CategoryDTO()
        {
            Tasks = new List<TaskDTO>();
            CompletedTasks = new List<CompletedTaskDTO>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TaskDTO> Tasks { get; set; }
        public ICollection<CompletedTaskDTO> CompletedTasks { get; set; }
    }
}
