using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BProduct
    {
        public List<Product> GetByName(string Name)
        {

            DataAccess data = new DataAccess();
            var products = data.Get();

            var result = products.Where(x => x.Name.Contains(Name)).ToList();

            return result;
        }

        public Product GetById(int Id)
        {

            DataAccess data = new   ();
            var products = data.Get();

            var result = products.FirstOrDefault(x => x.Product_id == Id);

            return result;
        }

        public bool InsertProduct(Product product)
        {
            DataAccess data = new DataAccess();
            return data.Insert(product);
        }

        public bool DeleteProduct(int productId)
        {
            DataAccess data = new DataAccess();

            bool deleteSuccess = data.Delete(productId);

            return deleteSuccess;
        }

        public bool UpdateProduct(Product product)
        {
            DataAccess data = new DataAccess();
            return data.Update(product);
        }

    }
}
