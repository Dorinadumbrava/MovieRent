using MovieRental.Repositories;
using MovieRental.RepositoryInterfaces;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MovieRental
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            var userContainer = new UnityContainer();

            userContainer.RegisterType<IUserRepository, UserRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(userContainer));
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}