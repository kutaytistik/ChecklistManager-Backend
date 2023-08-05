
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DataAccess.Concrete.EntityFramework;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System.Configuration;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IChecklistService, ChecklistManager>();
builder.Services.AddScoped<IChecklistDal, EfChecklistDal>();

builder.Services.AddScoped<IChecklistItemService, ChecklistItemManager>();
builder.Services.AddScoped<IChecklistItemDal, EfChecklistItemDal>();

builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IUserDal, EfUserDal>();

builder.Services.AddScoped<ITemplateService, TemplateManager>();
builder.Services.AddScoped<ITemplateDal, EfTemplateDal>();

builder.Services.AddDbContext<ChecklistManagerContext>(options =>
options.UseSqlServer(
                    builder.Configuration.GetConnectionString("ChecklistManagerContext"),
                    x => x.MigrationsAssembly("DataAccess.Concrete.EntityFramework")));

builder.Services.AddControllers();
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
