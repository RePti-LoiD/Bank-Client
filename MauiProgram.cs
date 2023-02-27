namespace BankApp;

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
				fonts.AddFont("Segoe-UI.ttf", "SegoeUIRegular");
				fonts.AddFont("Segoe-UI-Bold.ttf", "SegoeUIBold");
				fonts.AddFont("ClimateCrisis-Regular-VariableFont_YEAR.ttf", "ClimateCrisis");
			});

		return builder.Build();
	}
}