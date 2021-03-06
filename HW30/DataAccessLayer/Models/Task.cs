﻿using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Task
    {
        public Task()
        {
            Categories = new List<Category>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
