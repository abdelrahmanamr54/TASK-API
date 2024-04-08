using Api_Task.DTOs;

namespace Api_Task.IRepositery
{
    public interface I_ProductRepositery
    {
        public void edit(Models.Product productVm);


        public void delete(int id);
       




        public void Create(ProductDTO product);

        public List<Models.Product> Read();

        public Models.Product GetById(int id);
      
    }
}
