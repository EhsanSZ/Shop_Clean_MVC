using Application.Dtos;
using Application.Interfaces.Contexts;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Application.Discounts
{
    public interface IDiscountService
    {
        List<CatlogItemDto> GetCatalogItems(string searchKey);
        bool ApplyDiscountInBasket(string CoponCode, int BasketId);
        bool RemoveDiscountFromBasket(int BasketId);
        BaseDto IsDiscountValid(string couponCode, User user);

    }

    public class DiscountService : IDiscountService
    {

        private readonly IDataBaseContext context;

        public DiscountService(IDataBaseContext context)
        {
            this.context = context;
        }

        public bool ApplyDiscountInBasket(string CoponCode, int BasketId)
        {

           var basket = context.Baskets
                .Include(p => p.Items)
                .Include(p => p.AppliedDiscount)
                .FirstOrDefault(p => p.Id == BasketId);


            var discount = context.Discount.Where(p => p.CouponCode.Equals(CoponCode)).FirstOrDefault();

            basket.ApplyDiscountCode(discount);
            context.SaveChanges();
            return true;

        }

        public List<CatlogItemDto> GetCatalogItems(string searchKey)
        {
            if (!string.IsNullOrEmpty(searchKey))
            {
                var data = context.CatalogItems
                    .Where(p => p.Name.Contains(searchKey))
                    .Select(p => new CatlogItemDto
                    {
                        Id = p.Id,
                        Name = p.Name
                    }).ToList();
                return data;
            }
            else
            {
                var data = context.CatalogItems
                    .OrderByDescending(p=> p.Id)
                    .Take(10)
                    .Select(p => new CatlogItemDto
                    {
                        Id = p.Id,
                        Name = p.Name
                    }).ToList();
                return data;
            }

        }

        public BaseDto IsDiscountValid(string couponCode, User user)
        {
            throw new NotImplementedException();
        }

        public bool RemoveDiscountFromBasket(int BasketId)
        {
            var basket = context.Baskets.Find(BasketId);

            basket.RemoveDescount();
            context.SaveChanges();
            return true;
        }
    }

    public class CatlogItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
