using Microsoft.EntityFrameworkCore;
using wepapisassiment.Data;
using wepapisassiment.Repo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("myconn")));
builder.Services.AddControllers();
builder.Services.AddScoped<IMoviesRepo, MoviesRepo>();
builder.Services.AddScoped<IDirectorRepo, DirectorsRepo>();
builder.Services.AddScoped<ICatigoryRepo, CatigoryRepo>();
builder.Services.AddScoped<INationaltyRepo, NationaltyRepo>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
