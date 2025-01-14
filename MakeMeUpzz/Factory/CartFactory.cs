﻿using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class CartFactory
    {
        public static Cart Create(int CartID, int UserID, int MakeupID, int Quantity)
        {
            Cart cart = new Cart();

            cart.CartID = CartID;
            cart.UserID = UserID;
            cart.MakeupID = MakeupID;
            cart.Quantity = Quantity;

            return cart;
        }
    }
}