using Microsoft.EntityFrameworkCore;
using RuTravel.Application.Interfaces;
using RuTravel.Persistence;
using RuTravel.WebApi.Mapping;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("RuTravelDB");

builder.Services.AddDbContext<RuTravelDBContext>(opt => opt.UseSqlServer(connection, builder => builder.MigrationsAssembly("RuTravel.WebApi")));

builder.Services.AddAutoMapper(typeof(RuTravelProfile));

builder.Services.AddTransient<ICafesRepo, CafesRepo>();
builder.Services.AddTransient<ICommentsRepo, CommentsRepo>();
builder.Services.AddTransient<IFlatsRepo, FlatsRepo>();
builder.Services.AddTransient<IPhotosRepo, PhotosRepo>();
builder.Services.AddTransient<IPostsRepo, PostsRepo>();
builder.Services.AddTransient<ISightsRepo, SightsRepo>();
builder.Services.AddTransient<ITownsRepo, TownsRepo>();
builder.Services.AddTransient<IUsersRepo, UsersRepo>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
