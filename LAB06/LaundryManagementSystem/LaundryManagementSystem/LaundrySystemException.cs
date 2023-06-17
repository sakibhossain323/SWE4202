using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    class LaundrySystemException : Exception
    {
        public LaundrySystemException(string msg) : base(msg)
        {

        }
    }

    class UserNotFoundException : LaundrySystemException
    {
        public UserNotFoundException() : base("User not found!")
        {

        }
    }

    class UserAlreadyExistsException : LaundrySystemException
    {
        public UserAlreadyExistsException() : base("User ID already exists!")
        {

        }
    }

    class OrderNotFoundException : LaundrySystemException
    {
        public OrderNotFoundException() : base("Order not found!")
        {

        }
    }

    class InvalidOrderItemsException : LaundrySystemException
    {
        public InvalidOrderItemsException() : base("Invalid order items!")
        {

        }
    }

    class InvalidOrderStatusException : LaundrySystemException
    {
        public InvalidOrderStatusException() : base("Invalid order status!")
        {

        }
    }
}
