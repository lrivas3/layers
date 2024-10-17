using Layers.WebApi.configs;

var builder = WebApplication.CreateBuilder(args);


ConfigurationManager configuration = builder.Configuration;
builder.Services.Configure<AppSettings>(configuration.GetSection(nameof(AppSettings)));
AppSettings appSettings = new();
configuration.GetSection(nameof(AppSettings)).Bind(appSettings);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddPersistance(appSettings.DatabaseConnection);
builder.Services.AddServicesConfig();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler("/error");

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

