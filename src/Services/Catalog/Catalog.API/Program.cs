var builder = WebApplication.CreateBuilder(args);

//Register Services to DI container
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
    {
        config.RegisterServicesFromAssembly(typeof(Program).Assembly);
    }
);

var app = builder.Build();

//Add Middlewares like Uses
app.MapCarter();

app.Run();
