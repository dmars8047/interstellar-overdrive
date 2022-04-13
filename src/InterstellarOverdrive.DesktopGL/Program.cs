using System;

namespace InterstellarOverdrive.DesktopGL
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new InterstellarOverdriveGame())
                game.Run();
        }
    }
}
