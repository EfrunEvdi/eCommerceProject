﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        //Eğer bir interface generic yapıldıysa, implement edilmesi gerekir 
        //Bu repositoryde ekleme silme güncelleme listeleme için entity kodları yazıldı
        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id); //id'ye göre istenilen değeri veritabanında bulmayı sağlar
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public List<T> GetList(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }

        

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();

        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();

        }
    }
}
