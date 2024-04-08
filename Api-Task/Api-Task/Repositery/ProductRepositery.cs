using Api_Task.DTOs;
using Api_Task.IRepositery;
using Demo_api.Data;
using Microsoft.AspNetCore.Mvc;

namespace Api_Task.Repositery
{
    public class ProductRepositery :I_ProductRepositery
    {

        ApplicationDbContext context = new ApplicationDbContext();
        //public ProductRepositery(ApplicationDbContext context)
        //{
        //    this.context = context;

        //}


        public void edit(Models.Product productVm)
        {
            var selectedtask = context.products.Find(productVm.Id);
            if (selectedtask is not null)

            {
                selectedtask.Name = productVm.Name;

                selectedtask.Description = productVm.Description;
                selectedtask.Price = productVm.Price;
                context.SaveChanges();
            }


        }

        public void delete(int id)
        {
            var selectedproduct = context.products.Find(id);
            if (selectedproduct is not null)

            {
                context.products.Remove(selectedproduct);
                context.SaveChanges();
            }
        }

        public void Create(ProductDTO product)
        {



            context.products.Add(new Models.Product
            {
                Name=product.Name ,Description=product.Description,Price=product.Price
            });
            context.SaveChanges();

        }
        public List<Models.Product> Read()
        {

            var products = context.products.ToList();

            return products;


        }
        public Models.Product GetById(int id)
        {

            var empolyee = context.products.Find(id);
         
            

                return empolyee;
            

        }
    }
}
