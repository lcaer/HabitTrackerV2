using AutoMapper;
using HabitTracker.Domain.Bases;
using HabitTracker.Domain.Entities;
using HabitTracker.Repository.Context;
using HabitTracker.Repository.Repository;
using HabitTracker.Service.Services;
using HabitTracker.App.Models;
using HabitTracker.App.Others;
using HabitTracker.App.Registers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using HabitTracker.App.Bases;

namespace HabitTracker.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static IServiceProvider? ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            #region database
            var strCon = File.ReadAllText("C:/Users/Marinr/Downloads/IFSP/POEV/ProjetoFinal/" +
                                        "HabitTracker/HabitTracker.App/Config/ConfigBanco.txt");

            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure();
                });
            });
            #endregion

            #region Repositories
            Services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            Services.AddScoped<IBaseRepository<Habit>, BaseRepository<Habit>>();
            Services.AddScoped<IBaseRepository<Schedule>, BaseRepository<Schedule>>();
            #endregion

            #region Services
            Services.AddScoped<IBaseService<User>, BaseService<User>>();
            Services.AddScoped<IBaseService<Habit>, BaseService<Habit>>();
            Services.AddScoped<IBaseService<Schedule>, BaseService<Schedule>>();
            #endregion

            #region Forms
            Services.AddTransient<Login, Login>();
            Services.AddTransient<UserRegister, UserRegister>();
            Services.AddTransient<HabitRegister, HabitRegister>();
            Services.AddTransient<BasePanelHabit, BasePanelHabit>();
            #endregion

            #region Mappings
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<User, UserModel>();
                config.CreateMap<Habit, HabitModel>()
                    .ForMember(d => d.IdUser, d => d.MapFrom(x => x.User!.Id))
                    .ForMember(d => d.User, d => d.MapFrom(x => x.User!.Name))
                    .ForMember(d => d.IdSchedule, d => d.MapFrom(x => x.Schedule!.Id));
                config.CreateMap<Schedule, ScheduleModel>();
            }, NullLoggerFactory.Instance).CreateMapper());

            #endregion
            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}