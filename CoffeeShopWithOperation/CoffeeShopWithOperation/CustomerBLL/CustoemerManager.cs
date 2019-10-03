using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopWithOperation.CustomerRepository;
using CoffeeShopWithOperation.Model;

namespace CoffeeShopWithOperation.CustomerBLL
{
   public class CustoemerManager
    {
        CustomersRepository _CustomersRepository = new CustomersRepository();
        // public bool addcustomer(string name, string address,string contract)
        public bool addcustomer(Customer customer)
        {
            //return _CustomersRepository.additems(name, address,contract);
            return _CustomersRepository.additems(customer);
        }
        public bool isexitename(string name)
        {
            return _CustomersRepository.isexitename(name);
        }
        public DataTable show()
        {
            return _CustomersRepository.show();
        }
        // public bool update(string name, string address, string contract,int id)
        public bool update(Customer customer)
        {
            //name, address, contract,id)
            return _CustomersRepository.update(customer);
        }
        // public bool delete(int id)
        public bool delete(Customer customer)
        {
            return _CustomersRepository.delete(customer);
        }
        // public DataTable search(string name)
        public DataTable search(Customer customer)
        {
            return _CustomersRepository.search(customer);
        }
    }
}
