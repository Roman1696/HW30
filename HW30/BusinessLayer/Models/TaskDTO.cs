using System.Collections.Generic;


namespace BusinessLayer.Models
{
    public class TaskDTO
    {
        public TaskDTO()
        {
            Categories = new List<CategoryDTO>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public ICollection<CategoryDTO> Categories { get; set; }
    }
   
}
