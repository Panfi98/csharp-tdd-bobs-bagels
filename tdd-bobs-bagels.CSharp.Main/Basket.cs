using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
   
    public class Basket
    {
        private List<string> _items = new List<string>();
        private int _capacity = 5;
        private int _amount = 0;

        public Basket() 
        {
            
        }

        public List<string> items { get => _items; set => _items = value; }

        public void add(string bagelName)
        {
           
            _items.Add(bagelName);
            
           
        }
        public void remove(string bagelName)
        {
            _items.Remove(bagelName);
        }


    }

}
