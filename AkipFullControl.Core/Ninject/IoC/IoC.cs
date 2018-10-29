using Ninject;

namespace AkipFullControl.Core
{
    public static class IoC
    {
        public static IKernel Kernel { get; private set; } = new StandardKernel();

        public static void Setup()
        {
            BindViewModel();
        }

        private static void BindViewModel()
        {
            Kernel.Bind<GlobalCollections>().ToConstant(new GlobalCollections());
        }

        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }
    }
}
