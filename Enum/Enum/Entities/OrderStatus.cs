using System;
using System.Collections.Generic;
using System.Text;

namespace Enum.Entities
{
    //An enum is a special "class" that represents a group of constants (unchangeable/read-only
    //variables).
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
