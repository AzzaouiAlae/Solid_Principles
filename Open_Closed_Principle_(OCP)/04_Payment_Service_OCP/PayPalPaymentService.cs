﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Payment_Service_OCP
{
    public class PayPalPaymentService : IPaymentService
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"you pay {amount.ToString()} with paypal");
        }
    }
}
