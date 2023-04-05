using Microsoft.EntityFrameworkCore;
using OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserFolder;
using OnionArchitecture.DomainLayer.Entities.DrivedEntities.UserProfileFolder;
using OnionArchitecture.RepositoryLayer.ApplicationDataBaseContexts;
using OnionArchitecture.RepositoryLayer.IRepository;
using OnionArchitecture.RepositoryLayer.Repository;
using OnionArchitecture.ServicesLayer.IServices;
using OnionArchitecture.ServicesLayer.Services;

namespace OnionArchitecture.PresentationLayer
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


            /* Start Custome Services */
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options
                .UseLazyLoadingProxies()
                .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            builder.Services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            builder.Services.AddTransient(typeof(IBaseServices<User>) , typeof(UserServices));
            builder.Services.AddTransient(typeof(IBaseServices<UserProfile>), typeof(UserProfileServices));

            /* End Custome Services */


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
        }
    }
}