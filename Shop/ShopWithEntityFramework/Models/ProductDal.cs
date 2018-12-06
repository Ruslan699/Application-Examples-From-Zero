using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWithEntityFramework.Models
{
   public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ShopDbContext context = new ShopDbContext())
            {
                return context.Products.ToList();
            }
        }
        //search by Name
        public List<Product> GetByName(string key)
        {
            using (ShopDbContext context = new ShopDbContext())
            {
                return context.Products.Where(j=>j.Name.Contains(key)).ToList();
            }
        }
        //search by Price
        //public List<Product> GetByPrice(decimal price)
        //{
        //    using (ShopDbContext context = new ShopDbContext())
        //    {
        //        return context.Products.Where(j => j.Price>=price).ToList();
        //    }
        //}

        //search between min and max price
        public List<Product> GetByPrice(decimal min, decimal max)
        {
            using (ShopDbContext context = new ShopDbContext())
            {
                return context.Products.Where(j => j.Price>=min && j.Price<=max).ToList();
            }
        }
        //Search by Id
        public Product GetById(int id)
        {
            using (ShopDbContext context = new ShopDbContext())
            {
                var result= context.Products.FirstOrDefault(i=>i.Id==id);

                return result;
            }
        }

        public void Add(Product product)
        {
            using (ShopDbContext context = new ShopDbContext())
            {

                /* also I can Write with add
                context.Products.Add(product);

                */
                //subscribe to context(for product)
                var entity = context.Entry(product);

                //Add
                entity.State = EntityState.Added;

                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ShopDbContext context = new ShopDbContext())
            {
                //subscribe to context(for product)
                var entity = context.Entry(product);

                //update
                entity.State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            DeleteProcess(product);
        }

        private static void DeleteProcess(Product product)
        {
            using (ShopDbContext context = new ShopDbContext())
            {
                //subscribe to context(for product)
                var entity = context.Entry(product);

                //delete
                entity.State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

            ///
            ///

    }
}
