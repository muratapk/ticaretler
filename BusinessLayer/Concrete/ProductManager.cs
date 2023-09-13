using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void TAdd(Product entity)
        {
            _productDal.Add(entity);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }

        public void TRemove(Product entity)
        {
            _productDal.Delete(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
