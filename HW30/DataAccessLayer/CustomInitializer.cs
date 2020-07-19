using DataAccessLayer.Models;
using System.Collections.Generic;
using System.Data.Entity;


namespace DataAccessLayer
{
    public class CustomInitializer: DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            var category1 = new Category() { Name = "Category_1" };
            var category2 = new Category() { Name = "Category_2" };            

            var listOfCategories1 = new List<Category>();
            listOfCategories1.Add(category1);
            listOfCategories1.Add(category2);
            
            var listOfCategories2 = new List<Category>();
            listOfCategories1.Add(category1);            

            var task1 = new Task() { Name = "Play football", Status = "Processing", Categories = listOfCategories1 };
            var task2 = new Task() { Name = "Make dinner", Status = "Done", Categories = listOfCategories2 };            

            context.Categories.AddRange(listOfCategories1);

            context.Tasks.Add(task1);
            context.Tasks.Add(task2);           

            context.SaveChanges();
        }
    }
}
