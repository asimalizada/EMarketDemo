﻿using Ninject;

namespace EMarketDemo.Business.DependencyResolvers.Ninject
{
    public static class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
