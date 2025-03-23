using PocketStack.Server;

var app = WebApplication.CreateBuilder(args).ConfigureServices().ConfigureApplication();

app.Run();