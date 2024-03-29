using Microsoft.EntityFrameworkCore;
using daw_proiect.ContextModels;
using daw_proiect.Repositories;
using daw_proiect.Services;
using daw_proiect.Authorization;
using daw_proiect.Helpers;

var AllowSpecificOrigin = "_allowSpecificOrigin";

var builder = WebApplication.CreateBuilder(args);

//var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.
builder.Services.AddCors(options =>
{
    /*    options.AddPolicy(name: "_myAllowSpecificOrigins",
                          policy =>
                          {
                              policy.WithOrigins("localhost:4200").AllowAnyHeader().AllowAnyMethod();
                          });*/
    options.AddPolicy(name: AllowSpecificOrigin,
        policy =>
        {
            policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
        });
    /*    options.AddPolicy("CorsPolicy", builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });*/
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// configure strongly typed settings object
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

// configure DI for application services
builder.Services.AddScoped<IJwtUtils, JwtUtils>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Cofetarie")));

builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IClientService, ClientService>();

builder.Services.AddScoped<ILocatieRepository, LocatieRepository>();
builder.Services.AddScoped<ILocatieService, LocatieService>();

builder.Services.AddScoped<IRecenzieRepository, RecenzieRepository>();
builder.Services.AddScoped<IRecenzieService, RecenzieService>();

builder.Services.AddScoped<IProdusRepository, ProdusRepository>();
builder.Services.AddScoped<IProdusService, ProdusService>();

builder.Services.AddScoped<IComandaRepository, ComandaRepository>();
builder.Services.AddScoped<IComandaService, ComandaService>();

builder.Services.AddScoped<IRetetaRepository, RetetaRepository>();
builder.Services.AddScoped<IRetetaService, RetetaService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(AllowSpecificOrigin);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
