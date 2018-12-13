using MvvmCross;
using MvvmCross.Logging;

namespace TasksDrop.Core
{
    public static class Logs
    {
        public static IMvxLog Instance { get; } = Mvx.Resolve<IMvxLogProvider>().GetLogFor("StarWarsSample");
    }
}
