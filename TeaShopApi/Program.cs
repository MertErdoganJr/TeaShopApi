using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.BusinessLayer.Concrete;
using TeaShopApi.DataAccessLayer.Abstract;
using TeaShopApi.DataAccessLayer.Context;
using TeaShopApi.DataAccessLayer.EntityFramework;
using TeaShopApi.EntityLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IDrinkDal, EfDrinkDal>();
builder.Services.AddScoped<IDrinkService, DrinkManager>();

builder.Services.AddScoped<IQuestionDal, EfQuestionDal>();
builder.Services.AddScoped<IQuestionService, QuestionManager>();

builder.Services.AddScoped<IAboutUsDal, EfAboutUsDal>();
builder.Services.AddScoped<IAboutUsService, AboutUsManager>();

builder.Services.AddScoped<IProductDal, EfProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IContactService, ContactManager>();

builder.Services.AddScoped<IStatisticsDal, EfStatisticsDal>();
builder.Services.AddScoped<IStatisticsService, IstatisticsManager>();

builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

builder.Services.AddDbContext<TeaContext>();

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
