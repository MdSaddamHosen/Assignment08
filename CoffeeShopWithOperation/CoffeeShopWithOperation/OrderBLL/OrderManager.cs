using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopWithOperation.OrderRepository;
using CoffeeShopWithOperation.Model;

namespace CoffeeShopWithOperation.OrderBLL
{
   public class OrderManager
    {
        OrdersRepository _OrdersRepository = new OrdersRepository();
        // public bool addorder(string name, string item, int quantity,int totalprice)

        public bool addorder(OrderCustomer orderCustomer)
        {
            //return _OrdersRepository.addorder(name, item, quantity,totalprice);
            return _OrdersRepository.addorder(orderCustomer);
        }
        public bool isexitename(string name)
        {
            return _OrdersRepository.isexitename(name);
        }
        public DataTable show()
        {
            return _OrdersRepository.show();
        }
        // public bool update(string name, string iteam, int quantity,int totalprice, int id)
        public bool update(OrderCustomer orderCustomer)
        {
            //return _OrdersRepository.update(name, iteam, quantity,totalprice, id);
            return _OrdersRepository.update(orderCustomer);
        }
        public bool delete(OrderCustomer orderCustomer)
        {
            return _OrdersRepository.delete(orderCustomer);
        }
        //   public DataTable search(string name)
        public DataTable search(OrderCustomer orderCustomer)
        {
            return _OrdersRepository.search(orderCustomer);
        }
    }
}
