namespace Snoop.Interactive
{
    public class Interactive
    {
        private static MethodInfo CallbackMethod { get; }
            = typeof(Interactive).GetMethod(nameof(OnStart));

        public static void Start(int pid)
        {
            InjectorLauncherManager.Launch(pid, CallbackMethod);
        }

        public static int StartSnoop(string settingsFile)
        {

            return -1;
        }
    }
}
