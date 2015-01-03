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
            Kernel.Bind<TInterfaceType>().To<TImplementationType>();
        }

        public static IEnumerable<TInterfaceType> GetAll<TInterfaceType>()
        {
            return Kernel.GetAll<TInterfaceType>();
        }
    }
}
