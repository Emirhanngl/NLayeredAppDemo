using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entiites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            this._categoryDal = categoryDal;
        }
        List<Category> ICategoryService.GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
