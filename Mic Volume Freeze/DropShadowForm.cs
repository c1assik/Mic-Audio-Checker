using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Mic_Audio_Checker
{
    public class DropShadowForm : Form
    {
        private bool aeroEnabled;
        private const int CS_DROPSHADOW = 131072;

        [DllImport("dwmapi.dll")]
        private static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        private static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major < 6)
                return false;

            int pfEnabled = 0;
            DwmIsCompositionEnabled(ref pfEnabled);

            return pfEnabled == 1;
        }

        private struct MARGINS
        {
            public int LeftWidth;
            public int RightWidth;
            public int TopHeight;
            public int BottomHeight;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                aeroEnabled = CheckAeroEnabled();

                if (!aeroEnabled) cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, Height - 1, Width, 1));

            if (!aeroEnabled) return;

            int attrValue = 2;
            DwmSetWindowAttribute(Handle, 2, ref attrValue, 4);
            MARGINS pMarInset = new MARGINS
            {
                LeftWidth = 0,
                RightWidth = 0,
                TopHeight = 1,
                BottomHeight = 0,
            };
            DwmExtendFrameIntoClientArea(Handle, ref pMarInset);
        }
    }
}
