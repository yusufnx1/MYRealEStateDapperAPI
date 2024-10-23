using MYRealEStateDapperAPI.Models.DapperContext;
using MYRealEStateDapperAPI.Repositories.BottomGridRepository;
using MYRealEStateDapperAPI.Repositories.CategoryRepository;
using MYRealEStateDapperAPI.Repositories.PopulerLocationRepository;
using MYRealEStateDapperAPI.Repositories.ProductRepository;
using MYRealEStateDapperAPI.Repositories.ServiceRepository;
using MYRealEStateDapperAPI.Repositories.TestimonialRepository;
using MYRealEStateDapperAPI.Repositories.WhoWeAreRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopulerLocationRespository, PopulerLocationRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();

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
