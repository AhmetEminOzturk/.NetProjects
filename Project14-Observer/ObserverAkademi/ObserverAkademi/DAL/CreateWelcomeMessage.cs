using ObserverAkademi.ObserverPattern;
using System;

namespace ObserverAkademi.DAL
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();
        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "Dergimize abone olduğunuz için teşekkür ederiz, hoşgeldiniz."
            });
            context.SaveChanges();
        }


    }
}
