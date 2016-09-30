using Ninject;

namespace Toci.HornetsTraining.Training2.HomeWork.Common_Michal.Infrastructure
{
    public static class Factory
    {
        private static IKernel kernel;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IKernel GetInstance()
        {
            if (kernel == null)
            {
                kernel = new StandardKernel();
                kernel.Load(new Container());
            }
            return kernel;
        }
    }
}