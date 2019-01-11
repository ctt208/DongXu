using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DongXu.WebApi.App_Start
{
    using Autofac;
    using Autofac.Integration.Mvc;
    using Autofac.Integration.WebApi;
    using System.Reflection;
    using System.Web.Http;
    using System.Web.Mvc;
    using DongXu.Services;
    using DongXu.IServices;
    public class AutofacConfig
    {
        /// <summary>
        /// 项目初始化，实例化IOC容器
        /// </summary>
        public static void Register()
        {
            var builder = new ContainerBuilder();
            SetupResolveRules(builder);

            //注册所有的ApiControllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            var container = builder.Build();

            //注册api容器需要使用HttpConfiguration对象
            HttpConfiguration config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        /// <summary>
        /// 将实现类与接口注入到IOC容器中
        /// </summary>
        /// <param name="builder"></param>
        public static void SetupResolveRules(ContainerBuilder container)
        {
            //container.RegisterType<StudentRespository>().As<IStudentRespository>();
            container.RegisterType<EmployeeServices>().As<IEmployeeServices>();
            container.RegisterType<PerMissionServices>().As<IPerMission>();
            container.RegisterType<RoleService>().As<IRoleService>();
            container.RegisterType<BlocServices>().As<IBlocServices>();
            container.RegisterType<RolePermission>().As<IRolePermisson>();
        }
    }
}