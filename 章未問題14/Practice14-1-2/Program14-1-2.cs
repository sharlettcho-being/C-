using System;
using System.Diagnostics;
using System.Reflection;

namespace Practice14_1_2 {
    internal class Program {
        static void Main(string[] args) {
            var wFileLocation = Assembly.GetExecutingAssembly().Location;
            var wFileVersion = FileVersionInfo.GetVersionInfo(wFileLocation);
            Console.WriteLine($"ファイルバージョンは　　{wFileVersion.FileMajorPart}.{wFileVersion.FileMinorPart}." +
                $"{wFileVersion.FileBuildPart}.{wFileVersion.FilePrivatePart}");

            var wAssembly = Assembly.GetExecutingAssembly();
            var wAsmVersion = wAssembly.GetName().Version;
            Console.WriteLine($"アセンブリバージョンは　　{wAsmVersion.Major}.{wAsmVersion.Minor}.{wAsmVersion.Build}.{wAsmVersion.Revision}");
        }
    }
}
