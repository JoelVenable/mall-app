using System;
using System.Collections.Generic;

namespace MallApp
{
    public class DollarStore : IStore<DollarItem>
    {
        private Dictionary<string, DollarItem> _inventory = new Dictionary<string, DollarItem>();

        public void AddToInventory(string name, DollarItem item)
        {
            _inventory.Add(name, item);
        }
    }
}