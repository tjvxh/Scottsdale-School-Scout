using Microsoft.Extensions.Logging;

namespace ScottsdaleSchoolScout
{
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
					fonts.AddFont("SourceSans3-Regular.ttf", "SourceSans3Regular");
					fonts.AddFont("SourceSans3-Bold.ttf", "SourceSans3Bold");
					fonts.AddFont("SourceSans3-Medium.ttf", "SourceSans3Medium");
					fonts.AddFont("SourceSans3-Light.ttf", "SourceSans3Light");
					fonts.AddFont("SourceSans3-ExtraLight.ttf", "SourceSans3ExtraLight");
				});

#if DEBUG
		builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}