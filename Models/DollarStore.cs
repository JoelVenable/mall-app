using System;
using System.Collections.Generic;

namespace MallApp
{
    public class DollarStore : IStore<DollarItem>
    {
        private Dictionary<string, DollarItem> _inventory = new Dictionary<string, DollarItem>();

        public void AddToInventory(string itemName, DollarItem dollarItem)
        {
            _inventory.Add(itemName, dollarItem);
        }
    }
}