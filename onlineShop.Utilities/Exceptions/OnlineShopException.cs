using System;
using System.Collections.Generic;
using System.Text;

namespace onlineShop.Utilities.Exceptions
{
   public class OnlineShopException : Exception
    {
        public OnlineShopException()
        {
        }

        public OnlineShopException(string message)
            : base(message)
        {
        }

        public OnlineShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
