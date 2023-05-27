using ObserverAkademi.DAL;

namespace ObserverAkademi.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
