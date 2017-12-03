﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTest11.Domain.Abstract;
using MvcTest11.Domain.DAL;
using MvcTest11.Domain.Entity;

namespace MvcTest11.WebUI.Infrastructure
{
   
        public class NinjectDependencyResolver : IDependencyResolver
        {
            private IKernel kernel;
            public NinjectDependencyResolver(IKernel kernelParam)
            {
                kernel = kernelParam;
                AddBindings();
            }
            public object GetService(Type serviceType)
            {
                return kernel.TryGet(serviceType);
            }
            public IEnumerable<object> GetServices(Type serviceType)
            {
                return kernel.GetAll(serviceType);
            }
            private void AddBindings()
            {
                kernel.Bind<ICustomerRepository>().To<EFCustomerRepository>();
            }
        }
   
}