﻿using System;
using System.Collections.Generic;
using System.Text;
using Pelika.Core.DTOs.Order;
using Pelika.DataLayer.Entities.Order;

namespace Pelika.Core.Services.Interfaces
{
    public interface IOrderService
    {
        int AddOrder(string userName, int courseId);
        void UpdatePriceOrder(int orderId);

        Order GetOrderForUserPanel(string userName, int orderId);
        Order GetOrderById( int orderId);


        bool FinalyOrder(string userName, int orderId);
        List<Order> GetUserOrders(string userName);

        void UpdateOrder(Order order);
        bool IsUserInCourse(string userName, int courseId);


        #region Discount

        DiscountUseType UseDiscount(int orderId, string code);
        void AddDiscount(Discount discount);
        List<Discount> GetAllDiscounts();
        Discount GetDiscountById(int discountId);
        void UpdateDiscount(Discount discount);
        bool IsExistCode(string code);


        #endregion



    }
}
