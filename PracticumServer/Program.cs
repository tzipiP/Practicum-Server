using _2_Repository.Interfaces;
using _2_Services;
using _2_Services.ServiceClasses;
using _3_Repository.Interfaces;
using _3_Repository;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddCors(opt => opt.AddPolicy("PolicyName", policy =>
//{
//    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
//}));
builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins, builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddRepoDependencies();
builder.Services.AddScoped<IUserSer, UserService>();
builder.Services.AddScoped<IChildSer, ChildService>();
builder.Services.AddAutoMapper(typeof(MappingProfile));



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

//app.UseCors("PolicyName");
app.UseCors(MyAllowSpecificOrigins);

app.Run();
