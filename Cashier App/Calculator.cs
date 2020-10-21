using System;
using System.Collections.Generic;
using System.Text;

namespace Cashier_App
{
    class Calculator
    {
        private List<Item> listItem;
        private double total = 0;
        private double subtotal = 0;

        public Calculator()
        {
            this.listItem = new List<Item>();
        }

        public void AddItem(Item item)
        {
            this.listItem.Add(item);
            this.total += item.getSubtotal();
        }

        public double getTotal() { return total; }
        public List<Item> getListItem() { return listItem; }
    }
}
