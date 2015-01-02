using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace ConsoleTools.Ioc
{
    static class OF
    {
        internal static readonly StandardKernel Kernel;

        static OF()
        {
            Kernel = new StandardKernel();
        }

        public static void Register<TInterfaceType, TImplementationType>()
           where TImplementationType : TInterfaceType
        {
            Kernel.Unbind<TInterfaceType>();
            Kernel.Bind<TInterfaceType>().To<TImplementationType>();
        }

        public static void Register(Type interfaceType, Type classType)
        {
            Kernel.Unbind(interfaceType);
            Kernel.Bind(interfaceType).To(classType);
        }

        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }

        public static IEnumerable<TInterfaceType> GetAll<TInterfaceType>()
        {
            return Kernel.GetAll<TInterfaceType>();
        }
    }
}
