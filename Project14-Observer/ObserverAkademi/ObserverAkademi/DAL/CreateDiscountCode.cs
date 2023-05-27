using ObserverAkademi.ObserverPattern;
using System;

namespace ObserverAkademi.DAL
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountAmount = 50,
                DiscountCode = "SALE50",
                DiscountCodeStatus = true
            });
            context.SaveChanges();
        }
    }
}
