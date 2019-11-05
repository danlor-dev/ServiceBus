﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Remotely.ScreenCast.Linux.X11Interop
{
    public class LibXtst
    {
        [DllImport("libXtst")]
        public static extern bool XTestQueryExtension(IntPtr display, out int event_base, out int error_base, out int major_version, out int minor_version);
        [DllImport("libXtst")]
        public static extern void XTestFakeKeyEvent(IntPtr display, uint keycode, bool is_press, ulong delay);
        [DllImport("libXtst")]
        public static extern void XTestFakeButtonEvent(IntPtr display, uint button, bool is_press, ulong delay);
        [DllImport("libXtst")]
        public static extern void XTestFakeMotionEvent(IntPtr display, int screen_number, int x, int y, ulong delay);
    }
}
