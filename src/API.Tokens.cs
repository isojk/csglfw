/**
 * Copyright (c) 2025, Jan Kos <isojk@isojk.net>
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of
 * this software and associated documentation files (the “Software”), to deal in
 * the Software without restriction, including without limitation the rights to
 * use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
 * of the Software, and to permit persons to whom the Software is furnished to do
 * so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

namespace Isojk.Csglfw;

public static partial class API {

#region GLFW version macros
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_VERSION_MAJOR = 3;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_VERSION_MINOR = 4;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_VERSION_REVISION = 0;
#endregion

#region Boolean
    public const bool GLFW_TRUE = true;
    public const bool GLFW_FALSE = false;

#endregion

#region Key and button actions
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__input.html"/></summary>
    public const int GLFW_RELEASE = 0;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__input.html"/></summary>
    public const int GLFW_PRESS = 1;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__input.html"/></summary>
    public const int GLFW_REPEAT = 2;
#endregion

#region Joystick hat states
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__hat__state.html"/></summary>
    public const int GLFW_HAT_CENTERED = 0;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__hat__state.html"/></summary>
    public const int GLFW_HAT_UP = 1;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__hat__state.html"/></summary>
    public const int GLFW_HAT_RIGHT = 2;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__hat__state.html"/></summary>
    public const int GLFW_HAT_DOWN = 4;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__hat__state.html"/></summary>
    public const int GLFW_HAT_LEFT = 8;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__hat__state.html"/></summary>
    public const int GLFW_HAT_RIGHT_UP = GLFW_HAT_RIGHT | GLFW_HAT_UP;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__hat__state.html"/></summary>
    public const int GLFW_HAT_RIGHT_DOWN = GLFW_HAT_RIGHT | GLFW_HAT_DOWN;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__hat__state.html"/></summary>
    public const int GLFW_HAT_LEFT_UP = GLFW_HAT_LEFT | GLFW_HAT_UP;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__hat__state.html"/></summary>
    public const int GLFW_HAT_LEFT_DOWN = GLFW_HAT_LEFT | GLFW_HAT_DOWN;
#endregion

#region Keyboard key tokens
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_UNKNOWN = -1;

    // Printable keys
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_SPACE = 32;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_APOSTROPHE = 39;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_COMMA = 44;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_MINUS = 45;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_PERIOD = 46;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_SLASH = 47;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_0 = 48;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_1 = 49;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_2 = 50;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_3 = 51;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_4 = 52;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_5 = 53;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_6 = 54;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_7 = 55;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_8 = 56;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_9 = 57;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_SEMICOLON = 59;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_EQUAL = 61;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_A = 65;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_B = 66;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_C = 67;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_D = 68;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_E = 69;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F = 70;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_G = 71;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_H = 72;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_I = 73;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_J = 74;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_K = 75;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_L = 76;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_M = 77;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_N = 78;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_O = 79;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_P = 80;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_Q = 81;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_R = 82;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_S = 83;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_T = 84;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_U = 85;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_V = 86;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_W = 87;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_X = 88;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_Y = 89;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_Z = 90;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_LEFT_BRACKET = 91;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_BACKSLASH = 92;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_RIGHT_BRACKET = 93;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_GRAVE_ACCENT = 96;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_WORLD_1 = 161;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_WORLD_2 = 162;

    // Function keys
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_ESCAPE = 256;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_ENTER = 257;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_TAB = 258;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_BACKSPACE = 259;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_INSERT = 260;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_DELETE = 261;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_RIGHT = 262;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_LEFT = 263;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_DOWN = 264;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_UP = 265;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_PAGE_UP = 266;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_PAGE_DOWN = 267;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_HOME = 268;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_END = 269;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_CAPS_LOCK = 280;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_SCROLL_LOCK = 281;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_NUM_LOCK = 282;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_PRINT_SCREEN = 283;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_PAUSE = 284;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F1 = 290;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F2 = 291;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F3 = 292;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F4 = 293;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F5 = 294;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F6 = 295;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F7 = 296;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F8 = 297;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F9 = 298;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F10 = 299;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F11 = 300;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F12 = 301;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F13 = 302;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F14 = 303;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F15 = 304;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F16 = 305;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F17 = 306;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F18 = 307;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F19 = 308;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F20 = 309;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F21 = 310;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F22 = 311;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F23 = 312;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F24 = 313;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_F25 = 314;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_0 = 320;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_1 = 321;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_2 = 322;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_3 = 323;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_4 = 324;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_5 = 325;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_6 = 326;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_7 = 327;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_8 = 328;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_9 = 329;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_DECIMAL = 330;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_DIVIDE = 331;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_MULTIPLY = 332;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_SUBTRACT = 333;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_ADD = 334;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_ENTER = 335;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_KP_EQUAL = 336;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_LEFT_SHIFT = 340;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_LEFT_CONTROL = 341;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_LEFT_ALT = 342;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_LEFT_SUPER = 343;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_RIGHT_SHIFT = 344;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_RIGHT_CONTROL = 345;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_RIGHT_ALT = 346;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_RIGHT_SUPER = 347;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_MENU = 348;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__keys.html"/></summary>
    public const int GLFW_KEY_LAST = GLFW_KEY_MENU;
#endregion

#region Modifier key flags
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__mods.html"/></summary>
    public const int GLFW_MOD_SHIFT = 0x0001;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__mods.html"/></summary>
    public const int GLFW_MOD_CONTROL = 0x0002;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__mods.html"/></summary>
    public const int GLFW_MOD_ALT = 0x0004;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__mods.html"/></summary>
    public const int GLFW_MOD_SUPER = 0x0008;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__mods.html"/></summary>
    public const int GLFW_MOD_CAPS_LOCK = 0x0010;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__mods.html"/></summary>
    public const int GLFW_MOD_NUM_LOCK = 0x0020;
#endregion

#region Mouse buttons
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__buttons.html"/></summary>
    public const int GLFW_MOUSE_BUTTON_1 = 0;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__buttons.html"/></summary>
    public const int GLFW_MOUSE_BUTTON_2 = 1;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__buttons.html"/></summary>
    public const int GLFW_MOUSE_BUTTON_3 = 2;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__buttons.html"/></summary>
    public const int GLFW_MOUSE_BUTTON_4 = 3;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__buttons.html"/></summary>
    public const int GLFW_MOUSE_BUTTON_5 = 4;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__buttons.html"/></summary>
    public const int GLFW_MOUSE_BUTTON_6 = 5;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__buttons.html"/></summary>
    public const int GLFW_MOUSE_BUTTON_7 = 6;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__buttons.html"/></summary>
    public const int GLFW_MOUSE_BUTTON_8 = 7;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__buttons.html"/></summary>
    public const int GLFW_MOUSE_BUTTON_LAST = GLFW_MOUSE_BUTTON_8;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__buttons.html"/></summary>
    public const int GLFW_MOUSE_BUTTON_LEFT = GLFW_MOUSE_BUTTON_1;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__buttons.html"/></summary>
    public const int GLFW_MOUSE_BUTTON_RIGHT = GLFW_MOUSE_BUTTON_2;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__buttons.html"/></summary>
    public const int GLFW_MOUSE_BUTTON_MIDDLE = GLFW_MOUSE_BUTTON_3;
#endregion

#region Joystick IDs
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_1 = 0;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_2 = 1;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_3 = 2;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_4 = 3;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_5 = 4;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_6 = 5;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_7 = 6;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_8 = 7;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_9 = 8;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_10 = 9;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_11 = 10;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_12 = 11;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_13 = 12;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_14 = 13;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_15 = 14;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_16 = 15;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__joysticks.html"/></summary>
    public const int GLFW_JOYSTICK_LAST = GLFW_JOYSTICK_16;
#endregion

#region Gamepad buttons
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_A = 0;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_B = 1;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_X = 2;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_Y = 3;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_LEFT_BUMPER = 4;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER = 5;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_BACK = 6;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_START = 7;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_GUIDE = 8;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_LEFT_THUMB = 9;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_RIGHT_THUMB = 10;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_DPAD_UP = 11;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_DPAD_RIGHT = 12;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_DPAD_DOWN = 13;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_DPAD_LEFT = 14;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_LAST = GLFW_GAMEPAD_BUTTON_DPAD_LEFT;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_CROSS = GLFW_GAMEPAD_BUTTON_A;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_CIRCLE = GLFW_GAMEPAD_BUTTON_B;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_SQUARE = GLFW_GAMEPAD_BUTTON_X;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__buttons.html"/></summary>
    public const int GLFW_GAMEPAD_BUTTON_TRIANGLE = GLFW_GAMEPAD_BUTTON_Y;
#endregion

#region Gamepad axes
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__axes.html"/></summary>
    public const int GLFW_GAMEPAD_AXIS_LEFT_X = 0;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__axes.html"/></summary>
    public const int GLFW_GAMEPAD_AXIS_LEFT_Y = 1;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__axes.html"/></summary>
    public const int GLFW_GAMEPAD_AXIS_RIGHT_X = 2;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__axes.html"/></summary>
    public const int GLFW_GAMEPAD_AXIS_RIGHT_Y = 3;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__axes.html"/></summary>
    public const int GLFW_GAMEPAD_AXIS_LEFT_TRIGGER = 4;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__axes.html"/></summary>
    public const int GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER = 5;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__gamepad__axes.html"/></summary>
    public const int GLFW_GAMEPAD_AXIS_LAST = GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER;
#endregion

#region Error codes
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__errors.html"/></summary>
    public const int GLFW_NO_ERROR = 0;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__errors.html"/></summary>
    public const int GLFW_NOT_INITIALIZED = 0x00010001;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__errors.html"/></summary>
    public const int GLFW_NO_CURRENT_CONTEXT = 0x00010002;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__errors.html"/></summary>
    public const int GLFW_INVALID_ENUM = 0x00010003;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__errors.html"/></summary>
    public const int GLFW_INVALID_VALUE = 0x00010004;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__errors.html"/></summary>
    public const int GLFW_OUT_OF_MEMORY = 0x00010005;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__errors.html"/></summary>
    public const int GLFW_API_UNAVAILABLE = 0x00010006;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__errors.html"/></summary>
    public const int GLFW_VERSION_UNAVAILABLE = 0x00010007;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__errors.html"/></summary>
    public const int GLFW_PLATFORM_ERROR = 0x00010008;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__errors.html"/></summary>
    public const int GLFW_FORMAT_UNAVAILABLE = 0x00010009;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__errors.html"/></summary>
    public const int GLFW_NO_WINDOW_CONTEXT = 0x0001000A;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__errors.html"/></summary>
    public const int GLFW_CURSOR_UNAVAILABLE = 0x0001000B;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__errors.html"/></summary>
    public const int GLFW_FEATURE_UNAVAILABLE = 0x0001000C;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__errors.html"/></summary>
    public const int GLFW_FEATURE_UNIMPLEMENTED = 0x0001000D;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__errors.html"/></summary>
    public const int GLFW_PLATFORM_UNAVAILABLE = 0x0001000E;
#endregion

#region Window hints and attributes
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_FOCUSED = 0x00020001;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_ICONIFIED = 0x00020002;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_RESIZABLE = 0x00020003;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_VISIBLE = 0x00020004;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_DECORATED = 0x00020005;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_AUTO_ICONIFY = 0x00020006;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_FLOATING = 0x00020007;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_MAXIMIZED = 0x00020008;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_CENTER_CURSOR = 0x00020009;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_TRANSPARENT_FRAMEBUFFER = 0x0002000A;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_HOVERED = 0x0002000B;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_FOCUS_ON_SHOW = 0x0002000C;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_MOUSE_PASSTHROUGH = 0x0002000D;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_POSITION_X = 0x0002000E;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_POSITION_Y = 0x0002000F;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_RED_BITS = 0x00021001;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_GREEN_BITS = 0x00021002;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_BLUE_BITS = 0x00021003;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_ALPHA_BITS = 0x00021004;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_DEPTH_BITS = 0x00021005;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_STENCIL_BITS = 0x00021006;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_ACCUM_RED_BITS = 0x00021007;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_ACCUM_GREEN_BITS = 0x00021008;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_ACCUM_BLUE_BITS = 0x00021009;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_ACCUM_ALPHA_BITS = 0x0002100A;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_AUX_BUFFERS = 0x0002100B;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_STEREO = 0x0002100C;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_SAMPLES = 0x0002100D;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_SRGB_CAPABLE = 0x0002100E;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_REFRESH_RATE = 0x0002100F;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_DOUBLEBUFFER = 0x00021010;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_CLIENT_API = 0x00022001;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_CONTEXT_VERSION_MAJOR = 0x00022002;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_CONTEXT_VERSION_MINOR = 0x00022003;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_CONTEXT_REVISION = 0x00022004;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_CONTEXT_ROBUSTNESS = 0x00022005;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_OPENGL_FORWARD_COMPAT = 0x00022006;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_CONTEXT_DEBUG = 0x00022007;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_OPENGL_DEBUG_CONTEXT = GLFW_CONTEXT_DEBUG;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_OPENGL_PROFILE = 0x00022008;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_CONTEXT_RELEASE_BEHAVIOR = 0x00022009;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_CONTEXT_NO_ERROR = 0x0002200A;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_CONTEXT_CREATION_API = 0x0002200B;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_SCALE_TO_MONITOR = 0x0002200C;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_SCALE_FRAMEBUFFER = 0x0002200D;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_COCOA_RETINA_FRAMEBUFFER = 0x00023001;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_COCOA_FRAME_NAME = 0x00023002;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_COCOA_GRAPHICS_SWITCHING = 0x00023003;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_X11_CLASS_NAME = 0x00024001;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_X11_INSTANCE_NAME = 0x00024002;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_WIN32_KEYBOARD_MENU = 0x00025001;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_WIN32_SHOWDEFAULT = 0x00025002;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_WAYLAND_APP_ID = 0x00026001;
#endregion

#region Context related hints
    /// <summary><see href="https://www.glfw.org/docs/3.4/window_guide.html"/></summary>
    public const int GLFW_NO_API = 0;

    /// <summary><see href="https://www.glfw.org/docs/3.4/window_guide.html"/></summary>
    public const int GLFW_OPENGL_API = 0x00030001;

    /// <summary><see href="https://www.glfw.org/docs/3.4/window_guide.html"/></summary>
    public const int GLFW_OPENGL_ES_API = 0x00030002;

    /// <summary><see href="https://www.glfw.org/docs/3.4/window_guide.html"/></summary>
    public const int GLFW_NO_ROBUSTNESS = 0;

    /// <summary><see href="https://www.glfw.org/docs/3.4/window_guide.html"/></summary>
    public const int GLFW_NO_RESET_NOTIFICATION = 0x00031001;

    /// <summary><see href="https://www.glfw.org/docs/3.4/window_guide.html"/></summary>
    public const int GLFW_LOSE_CONTEXT_ON_RESET = 0x00031002;

    /// <summary><see href="https://www.glfw.org/docs/3.4/window_guide.html"/></summary>
    public const int GLFW_OPENGL_ANY_PROFILE = 0;

    /// <summary><see href="https://www.glfw.org/docs/3.4/window_guide.html"/></summary>
    public const int GLFW_OPENGL_CORE_PROFILE = 0x00032001;

    /// <summary><see href="https://www.glfw.org/docs/3.4/window_guide.html"/></summary>
    public const int GLFW_OPENGL_COMPAT_PROFILE = 0x00032002;
#endregion

#region Input options
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__input.html"/></summary>
    public const int GLFW_CURSOR = 0x00033001;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__input.html"/></summary>
    public const int GLFW_STICKY_KEYS = 0x00033002;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__input.html"/></summary>
    public const int GLFW_STICKY_MOUSE_BUTTONS = 0x00033003;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__input.html"/></summary>
    public const int GLFW_LOCK_KEY_MODS = 0x00033004;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__input.html"/></summary>
    public const int GLFW_RAW_MOUSE_MOTION = 0x00033005;
#endregion

#region Cursor modes
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__input.html"/></summary>
    public const int GLFW_CURSOR_NORMAL = 0x00034001;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__input.html"/></summary>
    public const int GLFW_CURSOR_HIDDEN = 0x00034002;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__input.html"/></summary>
    public const int GLFW_CURSOR_DISABLED = 0x00034003;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__input.html"/></summary>
    public const int GLFW_CURSOR_CAPTURED = 0x00034004;
#endregion

#region Context release behavior
    /// <summary><see href="https://www.glfw.org/docs/3.4/window_guide.html"/></summary>
    public const int GLFW_ANY_RELEASE_BEHAVIOR = 0;

    /// <summary><see href="https://www.glfw.org/docs/3.4/window_guide.html"/></summary>
    public const int GLFW_RELEASE_BEHAVIOR_FLUSH = 0x00035001;

    /// <summary><see href="https://www.glfw.org/docs/3.4/window_guide.html"/></summary>
    public const int GLFW_RELEASE_BEHAVIOR_NONE = 0x00035002;
#endregion

#region Context creation API
    /// <summary><see href="https://www.glfw.org/docs/3.4/window_guide.html"/></summary>
    public const int GLFW_NATIVE_CONTEXT_API = 0x00036001;

    /// <summary><see href="https://www.glfw.org/docs/3.4/window_guide.html"/></summary>
    public const int GLFW_EGL_CONTEXT_API = 0x00036002;

    /// <summary><see href="https://www.glfw.org/docs/3.4/window_guide.html"/></summary>
    public const int GLFW_OSMESA_CONTEXT_API = 0x00036003;
#endregion

#region ANGLE platform type
    /// <summary><see href="https://www.glfw.org/docs/3.4/intro_guide.html"/></summary>
    public const int GLFW_ANGLE_PLATFORM_TYPE_NONE = 0x00037001;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/intro_guide.html"/></summary>
    public const int GLFW_ANGLE_PLATFORM_TYPE_OPENGL = 0x00037002;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/intro_guide.html"/></summary>
    public const int GLFW_ANGLE_PLATFORM_TYPE_OPENGLES = 0x00037003;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/intro_guide.html"/></summary>
    public const int GLFW_ANGLE_PLATFORM_TYPE_D3D9 = 0x00037004;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/intro_guide.html"/></summary>
    public const int GLFW_ANGLE_PLATFORM_TYPE_D3D11 = 0x00037005;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/intro_guide.html"/></summary>
    public const int GLFW_ANGLE_PLATFORM_TYPE_VULKAN = 0x00037007;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/intro_guide.html"/></summary>
    public const int GLFW_ANGLE_PLATFORM_TYPE_METAL = 0x00037008;
#endregion

#region Wayland specific init hints
    /// <summary><see href="https://www.glfw.org/docs/3.4/intro_guide.html"/></summary>
    public const int GLFW_WAYLAND_PREFER_LIBDECOR = 0x00038001;

    /// <summary><see href="https://www.glfw.org/docs/3.4/intro_guide.html"/></summary>
    public const int GLFW_WAYLAND_DISABLE_LIBDECOR = 0x00038002;
#endregion

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__window.html"/></summary>
    public const int GLFW_ANY_POSITION = unchecked((int)0x80000000);

#region Standard cursor shapes
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__shapes.html"/></summary>
    public const int GLFW_ARROW_CURSOR = 0x00036001;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__shapes.html"/></summary>
    public const int GLFW_IBEAM_CURSOR = 0x00036002;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__shapes.html"/></summary>
    public const int GLFW_CROSSHAIR_CURSOR = 0x00036003;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__shapes.html"/></summary>
    public const int GLFW_POINTING_HAND_CURSOR = 0x00036004;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__shapes.html"/></summary>
    public const int GLFW_RESIZE_EW_CURSOR = 0x00036005;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__shapes.html"/></summary>
    public const int GLFW_RESIZE_NS_CURSOR = 0x00036006;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__shapes.html"/></summary>
    public const int GLFW_RESIZE_NWSE_CURSOR = 0x00036007;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__shapes.html"/></summary>
    public const int GLFW_RESIZE_NESW_CURSOR = 0x00036008;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__shapes.html"/></summary>
    public const int GLFW_RESIZE_ALL_CURSOR = 0x00036009;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__shapes.html"/></summary>
    public const int GLFW_NOT_ALLOWED_CURSOR = 0x0003600A;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__shapes.html"/></summary>
    public const int GLFW_HRESIZE_CURSOR = GLFW_RESIZE_EW_CURSOR;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__shapes.html"/></summary>
    public const int GLFW_VRESIZE_CURSOR = GLFW_RESIZE_NS_CURSOR;
    
    /// <summary><see href="https://www.glfw.org/docs/3.4/group__shapes.html"/></summary>
    public const int GLFW_HAND_CURSOR = GLFW_POINTING_HAND_CURSOR;
#endregion

#region Monitor and joystick events
    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/monitor_guide.html"/><br/>
    /// <see href="https://www.glfw.org/docs/3.4/input_guide.html"/>
    /// </summary>
    public const int GLFW_CONNECTED = 0x00040001;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/monitor_guide.html"/><br/>
    /// <see href="https://www.glfw.org/docs/3.4/input_guide.html"/>
    /// </summary>
    public const int GLFW_DISCONNECTED = 0x00040002;
#endregion

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_JOYSTICK_HAT_BUTTONS = 0x00050001;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_ANGLE_PLATFORM_TYPE = 0x00050002;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_PLATFORM = 0x00050003;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_COCOA_CHDIR_RESOURCES = 0x00051001;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_COCOA_MENUBAR = 0x00051002;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_X11_XCB_VULKAN_SURFACE = 0x00052001;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_WAYLAND_LIBDECOR = 0x00053001;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_ANY_PLATFORM = 0x00060000;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_PLATFORM_WIN32 = 0x00060001;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_PLATFORM_COCOA = 0x00060002;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_PLATFORM_WAYLAND = 0x00060003;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_PLATFORM_X11 = 0x00060004;

    /// <summary><see href="https://www.glfw.org/docs/3.4/group__init.html"/></summary>
    public const int GLFW_PLATFORM_NULL = 0x00060005;

    public const int GLFW_DONT_CARE = -1;
}
