
using HotelRez.BusinessLayer.Abstract;
using HotelRez.BusinessLayer.Concrete;
using HotelRez.DataAccessLayer.Abstract;
using HotelRez.DataAccessLayer.Concrete;
using HotelRez.DataAccessLayer.EntityFramework;
using System.Reflection;

namespace HotelRez.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<Context>();

            builder.Services.AddScoped<IStaffDal, EfStaffDal>();
            builder.Services.AddScoped<IStaffService,StaffManager>();

            builder.Services.AddScoped<IServiceDal, EfServiceDal>();
            builder.Services.AddScoped<IServiceService, ServiceManager>();

            builder.Services.AddScoped<IRoomDal, EfRoomDal>();
            builder.Services.AddScoped<IRoomService, RoomManager>();

            builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>();
            builder.Services.AddScoped<ISubscribeService, SubscribeManager>();

            builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            builder.Services.AddScoped<ITestimonialService, TestimonialManagere>();

            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
                   
            //builder.Services.AddScoped<>

            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy("HotelApiCors", opts=> 
                {
                    opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("HotelApiCors");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
