using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MathNet.Symbolics;

namespace DosCalculator.FormControls
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class ColoredRichTextBox : RichTextBox
    {
        private const int WmNcpaint = 0x85;
        private const uint RdwInvalidate = 0x1;
        private const uint RdwIupdatenow = 0x100;
        private const uint RdwFrame = 0x400;
        private Color _borderColor = Color.Blue;

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                    RdwFrame | RdwIupdatenow | RdwInvalidate);
            }
        }

        public bool HasValidExpression()
        {
            return Text.Any() && Infix.Parse(Text).IsOk;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32.dll")]
        private static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, uint flags);

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WmNcpaint && BorderColor != Color.Transparent &&
                BorderStyle == BorderStyle.Fixed3D)
            {
                var hdc = GetWindowDC(Handle);
                using (var g = Graphics.FromHdcInternal(hdc))
                using (var p = new Pen(BorderColor))
                    g.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1));
                _ = ReleaseDC(Handle, hdc);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                RdwFrame | RdwIupdatenow | RdwInvalidate);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            BorderColor = HasValidExpression() ? Color.Blue : Color.Red;
        }
    }
}