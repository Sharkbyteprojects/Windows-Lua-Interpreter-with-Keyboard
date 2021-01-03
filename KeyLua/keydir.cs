using System;
using System.Collections.Generic;
using System.Text;
using WindowsInput.Native;

namespace KeyDir
{
    class keydir
    {
        Dictionary<string, VirtualKeyCode> keystrokes =
            new Dictionary<string, VirtualKeyCode> {
            { "CTRL", VirtualKeyCode.CONTROL },
            { " ", VirtualKeyCode.SPACE },
            { "RCTRL", VirtualKeyCode.RCONTROL },
            { "LCTRL", VirtualKeyCode.LCONTROL },
            { "RSHIFT", VirtualKeyCode.RSHIFT },
            { "LSHIFT", VirtualKeyCode.LSHIFT },
            { "SHIFT", VirtualKeyCode.SHIFT },
            { "RETURN", VirtualKeyCode.RETURN },
            { "A", VirtualKeyCode.VK_A },
            { "B", VirtualKeyCode.VK_B },
            { "C", VirtualKeyCode.VK_C },
            { "D", VirtualKeyCode.VK_D },
            { "E", VirtualKeyCode.VK_E },
            { "F", VirtualKeyCode.VK_F },
            { "G", VirtualKeyCode.VK_G },
            { "H", VirtualKeyCode.VK_H },
            { "I", VirtualKeyCode.VK_I },
            { "J", VirtualKeyCode.VK_J },
            { "K", VirtualKeyCode.VK_K },
            { "L", VirtualKeyCode.VK_L },
            { "M", VirtualKeyCode.VK_M },
            { "N", VirtualKeyCode.VK_N },
            { "O", VirtualKeyCode.VK_O },
            { "P", VirtualKeyCode.VK_P },
            { "Q", VirtualKeyCode.VK_Q },
            { "R", VirtualKeyCode.VK_R },
            { "S", VirtualKeyCode.VK_S },
            { "T", VirtualKeyCode.VK_T },
            { "U", VirtualKeyCode.VK_U },
            { "V", VirtualKeyCode.VK_V },
            { "W", VirtualKeyCode.VK_W },
            { "X", VirtualKeyCode.VK_X },
            { "Y", VirtualKeyCode.VK_Y },
            { "Z", VirtualKeyCode.VK_Z },
            { "1", VirtualKeyCode.VK_1 },
            { "2", VirtualKeyCode.VK_2 },
            { "3", VirtualKeyCode.VK_3 },
            { "4", VirtualKeyCode.VK_4 },
            { "5", VirtualKeyCode.VK_5 },
            { "6", VirtualKeyCode.VK_6 },
            { "7", VirtualKeyCode.VK_7 },
            { "8", VirtualKeyCode.VK_8 },
            { "9", VirtualKeyCode.VK_9 },
            { "0", VirtualKeyCode.VK_0 },
            { "VOLUME_UP", VirtualKeyCode.VOLUME_UP },
            { "VOLUME_DOWN", VirtualKeyCode.VOLUME_DOWN },
            { "VOLUME_MUTE", VirtualKeyCode.VOLUME_MUTE },
            { "LWIN", VirtualKeyCode.LWIN },
            { "RWIN", VirtualKeyCode.RWIN },
            { "PRINT", VirtualKeyCode.PRINT },
            { "BACKSPACE", VirtualKeyCode.BACK },
            { "SPACE", VirtualKeyCode.SPACE },
            { "TAB", VirtualKeyCode.TAB },
            { "SNAPSHOT", VirtualKeyCode.SNAPSHOT }
        };
        public VirtualKeyCode getKeycode(string name)
        {
            return keystrokes[name.ToUpper()];
        }
    }
}
