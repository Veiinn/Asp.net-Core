using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepositories : ICategoryDal
    {
        AppDbContext AppDbContext = new AppDbContext();
        public void AddCategory(Category category)
        {
            AppDbContext.Add(category);
            AppDbContext.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            AppDbContext.Remove(category);
            AppDbContext.SaveChanges();
        }

        public Category GetById(int id)
        {
            return AppDbContext.Categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            return AppDbContext.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            AppDbContext.Update(category);
            AppDbContext.SaveChanges();
        }
    }
}
