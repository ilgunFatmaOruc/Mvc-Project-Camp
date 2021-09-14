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
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            //generic sınıfı içerisindeki tüm metotlar geliyor. repo. dediğimizde authentication işlemleri yapılabilir.
            return repo.List();
        }

        public void CategoryAddBL(Category p)
        {
            if(p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryDescription==""|| p.CategoryName.Length >= 51)
            {
                //hata mesajı
                //hata mesajı için ayrı sınıf oluşturulmalı.
            }
            else
            {
                //Generic teki ekleme metodunu kullandık.
                repo.Insert(p);
            }
        }
    }
}
