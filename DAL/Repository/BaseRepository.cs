using DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace DAL.Repository
{
    public class BaseRepository<T> : ApiController where T : class, new()
    {
        protected RezervasyonContext context = new RezervasyonContext();

      
        public DbSet<T> Table
        {
            get
            {
                return context.Set<T>();
            }
        }

        [NonAction]
        public List<T> GetList()
        {
            return Table.ToList();
        }

        [NonAction]
        public List<T> GetListSatislar(int id)
        {
            //aşşağıdaki kodu örnek alarak ekleyeceksin. Eager Loading include ile yapılıyor. Lazy Loading Load ile
            //var list = context.MusteriVeTedarikcilers.Include("MusteriVeTedarikciler.Satislar").Where(f => f.Id == id).ToList();
            //var list = context.Satislars.Include("Satislar.MusteriVeTedarikciler").Where(f => f.MusteriTedarikcilerID == id).Include("Satislar.Urunler").Where(f => f.Id == id).ToList();
            
            
            return Table.ToList();
        }

        [NonAction]
        public T GetById(Func<T, bool> metot)
        {
            
              return Table.FirstOrDefault(metot);
            
            
        }
        [NonAction]
        public List<T> GetWhere(Func<T, bool> metot)
        {
            return Table.Where(metot).ToList();
        }
        [NonAction]
        public void Save()
        {
            context.SaveChanges();
        }
        [NonAction]
        public void Add(T model)
        {
            
                

                Table.Add(model);
                Save();

            
            
        }
        [NonAction]
        public void Remove(T model)
        {
            if(model!=null)
            {                
                Table.Remove(model);
                Save();
            }
            
        }
        [NonAction]
        public void Update(T oldModel, T newModel)
        {
            PropertyInfo[] plist = typeof(T).GetProperties();
            foreach (var property in plist)
            {
                if (property.Name != "Id")
                    property.SetValue(oldModel, property.GetValue(newModel));
            }

            Save();
        }
    }
}
