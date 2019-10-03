using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopWithOperation.ItemsRepository;
using CoffeeShopWithOperation.Model;

namespace CoffeeShopWithOperation.ItemsBLL
{
    public class ItemManager
    {
        ItemRepository _ItemRepository = new ItemRepository();
            
        public bool additems(Item item)
        {
               //string name,double price
            return _ItemRepository.additems(item);
        }
        public bool isexitename(string name)
        {
            return _ItemRepository.isexitename(name);
        }
        public DataTable showitems()
        {
           return  _ItemRepository.showitems();
        }
        // public bool update(string name, int price, int id)
        public bool update(Item item)
        {
            return _ItemRepository.update(item);
        }
        // public bool delete(int id)
        public bool delete(Item item)
        {
            return _ItemRepository.delete(item);
        }
        // public DataTable search(string name)
        public DataTable search(Item item)
        {
            return _ItemRepository.search(item);
        }
        public DataTable itemComboBox()
        {
            return _ItemRepository.itemComboBox();
        }
    }
}
