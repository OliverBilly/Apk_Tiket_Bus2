using Aplikasi_Pemesanan_Tiket_Bus;
using System;
using System.Windows.Forms;

namespace Apk_Tiket_Bus2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1()); // ✅ ini bakal jalan
        }
    }
}
