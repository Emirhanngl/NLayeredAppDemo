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
    public class OrderManager : IOrdersService
    {
        readonly IOrderDal _ordersDal;
        public OrderManager(IOrderDal ordersDal)
        {
            this._ordersDal = ordersDal;
        }
        public List<Order> GetAll()
        {
            return _ordersDal.GetAll();
        }
    }
}
