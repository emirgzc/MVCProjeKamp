using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repocat = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return repocat.List();
        }
        public void CategoryAddBL(Category p)
        {
            if (p.CategoryName=="" || p.CategoryName.Length <=3 || p.CategoryDescription=="" || p.CategoryName.Length>=51)
            {
                //hata mesajı
            }
            else
            {
                repocat.Insert(p);
            }
        }
    }
}
