using System;

namespace Abstract
{
    class CustomerFactory
    {
        public BaseCustomer GetObject(int choice)
        {
            switch (choice)
            {
                case (int)CustomerOption.Customer:
                    return new Customer();
                case (int)CustomerOption.Visitor:
                    return new Visitor();
            }

            return null;
        }
    }
}
