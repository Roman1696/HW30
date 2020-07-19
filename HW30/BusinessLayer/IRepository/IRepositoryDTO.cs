using BusinessLayer.Models;
using System.Collections.Generic;


namespace BusinessLayer.IRepository
{
    public interface IRepositoryDTO
    {
        void CheckTaskStatus();

        IList<TaskDTO> GetAllTasksDTO();
    }
}
