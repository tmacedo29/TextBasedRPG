using Microsoft.Extensions.Logging;

namespace TextBasedRPG;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf",   "OpenSansRegular" );
				fonts.AddFont("OpenSans-Semibold.ttf",  "OpenSansSemibold");
        fonts.AddFont("CachetStdRegular.otf",   "CachetStd"       );
        fonts.AddFont("CachetStdMedium.otf",    "CachetStdMedium" );
        fonts.AddFont("CachetStdBold.otf",      "CachetStdBold"   );
        fonts.AddFont("Papyrus.ttf",            "Papyrus"         );
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
