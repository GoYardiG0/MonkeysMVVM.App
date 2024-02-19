using Microsoft.Extensions.Logging;
using MonkeysMVVM.Services;
using MonkeysMVVM.ViewModels;
using MonkeysMVVM.Views;

namespace MonkeysMVVM;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
    public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
    {
        //--------singleton Pages
        builder.Services.AddSingleton<ShowMonkeysByLocationView>();

        //--------Transient pages

        builder.Services.AddTransient<ShowMonkeyView>();

        return builder;
    }

    public static MauiAppBuilder RegisterDataServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<MonkeysService>();
        return builder;
    }
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<ShowMonkeysByLocationViewModel>();

        //--------Transient ViewModels
        builder.Services.AddTransient<ShowMonkeyViewModel>();

        return builder;
    }
}
