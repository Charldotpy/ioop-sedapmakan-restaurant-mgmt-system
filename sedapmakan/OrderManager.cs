using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmembers
{
    public static class OrderManager
    {
        private static Dictionary<int, int> orders = new Dictionary<int, int>();

        public static void Update(int itemId, int quantity)
        {
            if (orders.ContainsKey(itemId))
                orders[itemId] = quantity;
            else
                orders.Add(itemId, quantity);
        }

        public static Dictionary<int, int> GetOrders()
        {
            return new Dictionary<int, int>(orders); // returns a copy
        }

        public static void Clear()
        {
            orders.Clear();
        }
    }

}
