
        using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using GiveAway.Core.Services;
using GiveAway.Core.ViewModels;

namespace GiveAway.Core
    {
        public class App : MvxApplication
        {
            public App()
            {
                Mvx.RegisterType<IAuthenticateService, AuthenticateService>();
                Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<LogInPageViewModel>());
            }
        }
    }

