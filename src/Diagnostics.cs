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

using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Isojk.Csglfw;

using static API;

public static class Diagnostics {
    // https://devblogs.microsoft.com/dotnet/performance-improvements-in-net-8/#frozen-collections

    internal static readonly FrozenDictionary<int, string> KeyAndButtonActionTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_RELEASE, nameof(GLFW_RELEASE)),
        new KeyValuePair<int, string>(GLFW_PRESS, nameof(GLFW_PRESS)),
        new KeyValuePair<int, string>(GLFW_REPEAT, nameof(GLFW_REPEAT)),
    ]);

    internal static readonly FrozenDictionary<int, string> JoystickHatStateTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_HAT_CENTERED, nameof(GLFW_HAT_CENTERED)),
        new KeyValuePair<int, string>(GLFW_HAT_UP, nameof(GLFW_HAT_UP)),
        new KeyValuePair<int, string>(GLFW_HAT_RIGHT, nameof(GLFW_HAT_RIGHT)),
        new KeyValuePair<int, string>(GLFW_HAT_DOWN, nameof(GLFW_HAT_DOWN)),
        new KeyValuePair<int, string>(GLFW_HAT_LEFT, nameof(GLFW_HAT_LEFT)),
        new KeyValuePair<int, string>(GLFW_HAT_RIGHT_UP, nameof(GLFW_HAT_RIGHT_UP)),
        new KeyValuePair<int, string>(GLFW_HAT_RIGHT_DOWN, nameof(GLFW_HAT_RIGHT_DOWN)),
        new KeyValuePair<int, string>(GLFW_HAT_LEFT_UP, nameof(GLFW_HAT_LEFT_UP)),
        new KeyValuePair<int, string>(GLFW_HAT_LEFT_DOWN, nameof(GLFW_HAT_LEFT_DOWN)),
    ]);

    internal static readonly FrozenDictionary<int, string> KeyboardKeyTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_KEY_SPACE, nameof(GLFW_KEY_SPACE)),
        new KeyValuePair<int, string>(GLFW_KEY_APOSTROPHE, nameof(GLFW_KEY_APOSTROPHE)),
        new KeyValuePair<int, string>(GLFW_KEY_COMMA, nameof(GLFW_KEY_COMMA)),
        new KeyValuePair<int, string>(GLFW_KEY_MINUS, nameof(GLFW_KEY_MINUS)),
        new KeyValuePair<int, string>(GLFW_KEY_PERIOD, nameof(GLFW_KEY_PERIOD)),
        new KeyValuePair<int, string>(GLFW_KEY_SLASH, nameof(GLFW_KEY_SLASH)),
        new KeyValuePair<int, string>(GLFW_KEY_0, nameof(GLFW_KEY_0)),
        new KeyValuePair<int, string>(GLFW_KEY_1, nameof(GLFW_KEY_1)),
        new KeyValuePair<int, string>(GLFW_KEY_2, nameof(GLFW_KEY_2)),
        new KeyValuePair<int, string>(GLFW_KEY_3, nameof(GLFW_KEY_3)),
        new KeyValuePair<int, string>(GLFW_KEY_4, nameof(GLFW_KEY_4)),
        new KeyValuePair<int, string>(GLFW_KEY_5, nameof(GLFW_KEY_5)),
        new KeyValuePair<int, string>(GLFW_KEY_6, nameof(GLFW_KEY_6)),
        new KeyValuePair<int, string>(GLFW_KEY_7, nameof(GLFW_KEY_7)),
        new KeyValuePair<int, string>(GLFW_KEY_8, nameof(GLFW_KEY_8)),
        new KeyValuePair<int, string>(GLFW_KEY_9, nameof(GLFW_KEY_9)),
        new KeyValuePair<int, string>(GLFW_KEY_SEMICOLON, nameof(GLFW_KEY_SEMICOLON)),
        new KeyValuePair<int, string>(GLFW_KEY_EQUAL, nameof(GLFW_KEY_EQUAL)),
        new KeyValuePair<int, string>(GLFW_KEY_A, nameof(GLFW_KEY_A)),
        new KeyValuePair<int, string>(GLFW_KEY_B, nameof(GLFW_KEY_B)),
        new KeyValuePair<int, string>(GLFW_KEY_C, nameof(GLFW_KEY_C)),
        new KeyValuePair<int, string>(GLFW_KEY_D, nameof(GLFW_KEY_D)),
        new KeyValuePair<int, string>(GLFW_KEY_E, nameof(GLFW_KEY_E)),
        new KeyValuePair<int, string>(GLFW_KEY_F, nameof(GLFW_KEY_F)),
        new KeyValuePair<int, string>(GLFW_KEY_G, nameof(GLFW_KEY_G)),
        new KeyValuePair<int, string>(GLFW_KEY_H, nameof(GLFW_KEY_H)),
        new KeyValuePair<int, string>(GLFW_KEY_I, nameof(GLFW_KEY_I)),
        new KeyValuePair<int, string>(GLFW_KEY_J, nameof(GLFW_KEY_J)),
        new KeyValuePair<int, string>(GLFW_KEY_K, nameof(GLFW_KEY_K)),
        new KeyValuePair<int, string>(GLFW_KEY_L, nameof(GLFW_KEY_L)),
        new KeyValuePair<int, string>(GLFW_KEY_M, nameof(GLFW_KEY_M)),
        new KeyValuePair<int, string>(GLFW_KEY_N, nameof(GLFW_KEY_N)),
        new KeyValuePair<int, string>(GLFW_KEY_O, nameof(GLFW_KEY_O)),
        new KeyValuePair<int, string>(GLFW_KEY_P, nameof(GLFW_KEY_P)),
        new KeyValuePair<int, string>(GLFW_KEY_Q, nameof(GLFW_KEY_Q)),
        new KeyValuePair<int, string>(GLFW_KEY_R, nameof(GLFW_KEY_R)),
        new KeyValuePair<int, string>(GLFW_KEY_S, nameof(GLFW_KEY_S)),
        new KeyValuePair<int, string>(GLFW_KEY_T, nameof(GLFW_KEY_T)),
        new KeyValuePair<int, string>(GLFW_KEY_U, nameof(GLFW_KEY_U)),
        new KeyValuePair<int, string>(GLFW_KEY_V, nameof(GLFW_KEY_V)),
        new KeyValuePair<int, string>(GLFW_KEY_W, nameof(GLFW_KEY_W)),
        new KeyValuePair<int, string>(GLFW_KEY_X, nameof(GLFW_KEY_X)),
        new KeyValuePair<int, string>(GLFW_KEY_Y, nameof(GLFW_KEY_Y)),
        new KeyValuePair<int, string>(GLFW_KEY_Z, nameof(GLFW_KEY_Z)),
        new KeyValuePair<int, string>(GLFW_KEY_LEFT_BRACKET, nameof(GLFW_KEY_LEFT_BRACKET)),
        new KeyValuePair<int, string>(GLFW_KEY_BACKSLASH, nameof(GLFW_KEY_BACKSLASH)),
        new KeyValuePair<int, string>(GLFW_KEY_RIGHT_BRACKET, nameof(GLFW_KEY_RIGHT_BRACKET)),
        new KeyValuePair<int, string>(GLFW_KEY_GRAVE_ACCENT, nameof(GLFW_KEY_GRAVE_ACCENT)),
        new KeyValuePair<int, string>(GLFW_KEY_WORLD_1, nameof(GLFW_KEY_WORLD_1)),
        new KeyValuePair<int, string>(GLFW_KEY_WORLD_2, nameof(GLFW_KEY_WORLD_2)),
        new KeyValuePair<int, string>(GLFW_KEY_ESCAPE, nameof(GLFW_KEY_ESCAPE)),
        new KeyValuePair<int, string>(GLFW_KEY_ENTER, nameof(GLFW_KEY_ENTER)),
        new KeyValuePair<int, string>(GLFW_KEY_TAB, nameof(GLFW_KEY_TAB)),
        new KeyValuePair<int, string>(GLFW_KEY_BACKSPACE, nameof(GLFW_KEY_BACKSPACE)),
        new KeyValuePair<int, string>(GLFW_KEY_INSERT, nameof(GLFW_KEY_INSERT)),
        new KeyValuePair<int, string>(GLFW_KEY_DELETE, nameof(GLFW_KEY_DELETE)),
        new KeyValuePair<int, string>(GLFW_KEY_RIGHT, nameof(GLFW_KEY_RIGHT)),
        new KeyValuePair<int, string>(GLFW_KEY_LEFT, nameof(GLFW_KEY_LEFT)),
        new KeyValuePair<int, string>(GLFW_KEY_DOWN, nameof(GLFW_KEY_DOWN)),
        new KeyValuePair<int, string>(GLFW_KEY_UP, nameof(GLFW_KEY_UP)),
        new KeyValuePair<int, string>(GLFW_KEY_PAGE_UP, nameof(GLFW_KEY_PAGE_UP)),
        new KeyValuePair<int, string>(GLFW_KEY_PAGE_DOWN, nameof(GLFW_KEY_PAGE_DOWN)),
        new KeyValuePair<int, string>(GLFW_KEY_HOME, nameof(GLFW_KEY_HOME)),
        new KeyValuePair<int, string>(GLFW_KEY_END, nameof(GLFW_KEY_END)),
        new KeyValuePair<int, string>(GLFW_KEY_CAPS_LOCK, nameof(GLFW_KEY_CAPS_LOCK)),
        new KeyValuePair<int, string>(GLFW_KEY_SCROLL_LOCK, nameof(GLFW_KEY_SCROLL_LOCK)),
        new KeyValuePair<int, string>(GLFW_KEY_NUM_LOCK, nameof(GLFW_KEY_NUM_LOCK)),
        new KeyValuePair<int, string>(GLFW_KEY_PRINT_SCREEN, nameof(GLFW_KEY_PRINT_SCREEN)),
        new KeyValuePair<int, string>(GLFW_KEY_PAUSE, nameof(GLFW_KEY_PAUSE)),
        new KeyValuePair<int, string>(GLFW_KEY_F1, nameof(GLFW_KEY_F1)),
        new KeyValuePair<int, string>(GLFW_KEY_F2, nameof(GLFW_KEY_F2)),
        new KeyValuePair<int, string>(GLFW_KEY_F3, nameof(GLFW_KEY_F3)),
        new KeyValuePair<int, string>(GLFW_KEY_F4, nameof(GLFW_KEY_F4)),
        new KeyValuePair<int, string>(GLFW_KEY_F5, nameof(GLFW_KEY_F5)),
        new KeyValuePair<int, string>(GLFW_KEY_F6, nameof(GLFW_KEY_F6)),
        new KeyValuePair<int, string>(GLFW_KEY_F7, nameof(GLFW_KEY_F7)),
        new KeyValuePair<int, string>(GLFW_KEY_F8, nameof(GLFW_KEY_F8)),
        new KeyValuePair<int, string>(GLFW_KEY_F9, nameof(GLFW_KEY_F9)),
        new KeyValuePair<int, string>(GLFW_KEY_F10, nameof(GLFW_KEY_F10)),
        new KeyValuePair<int, string>(GLFW_KEY_F11, nameof(GLFW_KEY_F11)),
        new KeyValuePair<int, string>(GLFW_KEY_F12, nameof(GLFW_KEY_F12)),
        new KeyValuePair<int, string>(GLFW_KEY_F13, nameof(GLFW_KEY_F13)),
        new KeyValuePair<int, string>(GLFW_KEY_F14, nameof(GLFW_KEY_F14)),
        new KeyValuePair<int, string>(GLFW_KEY_F15, nameof(GLFW_KEY_F15)),
        new KeyValuePair<int, string>(GLFW_KEY_F16, nameof(GLFW_KEY_F16)),
        new KeyValuePair<int, string>(GLFW_KEY_F17, nameof(GLFW_KEY_F17)),
        new KeyValuePair<int, string>(GLFW_KEY_F18, nameof(GLFW_KEY_F18)),
        new KeyValuePair<int, string>(GLFW_KEY_F19, nameof(GLFW_KEY_F19)),
        new KeyValuePair<int, string>(GLFW_KEY_F20, nameof(GLFW_KEY_F20)),
        new KeyValuePair<int, string>(GLFW_KEY_F21, nameof(GLFW_KEY_F21)),
        new KeyValuePair<int, string>(GLFW_KEY_F22, nameof(GLFW_KEY_F22)),
        new KeyValuePair<int, string>(GLFW_KEY_F23, nameof(GLFW_KEY_F23)),
        new KeyValuePair<int, string>(GLFW_KEY_F24, nameof(GLFW_KEY_F24)),
        new KeyValuePair<int, string>(GLFW_KEY_F25, nameof(GLFW_KEY_F25)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_0, nameof(GLFW_KEY_KP_0)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_1, nameof(GLFW_KEY_KP_1)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_2, nameof(GLFW_KEY_KP_2)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_3, nameof(GLFW_KEY_KP_3)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_4, nameof(GLFW_KEY_KP_4)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_5, nameof(GLFW_KEY_KP_5)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_6, nameof(GLFW_KEY_KP_6)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_7, nameof(GLFW_KEY_KP_7)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_8, nameof(GLFW_KEY_KP_8)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_9, nameof(GLFW_KEY_KP_9)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_DECIMAL, nameof(GLFW_KEY_KP_DECIMAL)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_DIVIDE, nameof(GLFW_KEY_KP_DIVIDE)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_MULTIPLY, nameof(GLFW_KEY_KP_MULTIPLY)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_SUBTRACT, nameof(GLFW_KEY_KP_SUBTRACT)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_ADD, nameof(GLFW_KEY_KP_ADD)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_ENTER, nameof(GLFW_KEY_KP_ENTER)),
        new KeyValuePair<int, string>(GLFW_KEY_KP_EQUAL, nameof(GLFW_KEY_KP_EQUAL)),
        new KeyValuePair<int, string>(GLFW_KEY_LEFT_SHIFT, nameof(GLFW_KEY_LEFT_SHIFT)),
        new KeyValuePair<int, string>(GLFW_KEY_LEFT_CONTROL, nameof(GLFW_KEY_LEFT_CONTROL)),
        new KeyValuePair<int, string>(GLFW_KEY_LEFT_ALT, nameof(GLFW_KEY_LEFT_ALT)),
        new KeyValuePair<int, string>(GLFW_KEY_LEFT_SUPER, nameof(GLFW_KEY_LEFT_SUPER)),
        new KeyValuePair<int, string>(GLFW_KEY_RIGHT_SHIFT, nameof(GLFW_KEY_RIGHT_SHIFT)),
        new KeyValuePair<int, string>(GLFW_KEY_RIGHT_CONTROL, nameof(GLFW_KEY_RIGHT_CONTROL)),
        new KeyValuePair<int, string>(GLFW_KEY_RIGHT_ALT, nameof(GLFW_KEY_RIGHT_ALT)),
        new KeyValuePair<int, string>(GLFW_KEY_RIGHT_SUPER, nameof(GLFW_KEY_RIGHT_SUPER)),
        new KeyValuePair<int, string>(GLFW_KEY_MENU, nameof(GLFW_KEY_MENU)),
    ]);

    internal static readonly FrozenDictionary<int, string> ModifierKeyFlagTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_MOD_SHIFT, nameof(GLFW_MOD_SHIFT)),
        new KeyValuePair<int, string>(GLFW_MOD_CONTROL, nameof(GLFW_MOD_CONTROL)),
        new KeyValuePair<int, string>(GLFW_MOD_ALT, nameof(GLFW_MOD_ALT)),
        new KeyValuePair<int, string>(GLFW_MOD_SUPER, nameof(GLFW_MOD_SUPER)),
        new KeyValuePair<int, string>(GLFW_MOD_CAPS_LOCK, nameof(GLFW_MOD_CAPS_LOCK)),
        new KeyValuePair<int, string>(GLFW_MOD_NUM_LOCK, nameof(GLFW_MOD_NUM_LOCK)),
    ]);

    internal static readonly FrozenDictionary<int, string> MouseButtonTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_MOUSE_BUTTON_1, nameof(GLFW_MOUSE_BUTTON_1)),
        new KeyValuePair<int, string>(GLFW_MOUSE_BUTTON_2, nameof(GLFW_MOUSE_BUTTON_2)),
        new KeyValuePair<int, string>(GLFW_MOUSE_BUTTON_3, nameof(GLFW_MOUSE_BUTTON_3)),
        new KeyValuePair<int, string>(GLFW_MOUSE_BUTTON_4, nameof(GLFW_MOUSE_BUTTON_4)),
        new KeyValuePair<int, string>(GLFW_MOUSE_BUTTON_5, nameof(GLFW_MOUSE_BUTTON_5)),
        new KeyValuePair<int, string>(GLFW_MOUSE_BUTTON_6, nameof(GLFW_MOUSE_BUTTON_6)),
        new KeyValuePair<int, string>(GLFW_MOUSE_BUTTON_7, nameof(GLFW_MOUSE_BUTTON_7)),
        new KeyValuePair<int, string>(GLFW_MOUSE_BUTTON_8, nameof(GLFW_MOUSE_BUTTON_8)),
        //new KeyValuePair<int, string>(GLFW_MOUSE_BUTTON_LAST, nameof(GLFW_MOUSE_BUTTON_LAST)),
        //new KeyValuePair<int, string>(GLFW_MOUSE_BUTTON_LEFT, nameof(GLFW_MOUSE_BUTTON_LEFT)),
        //new KeyValuePair<int, string>(GLFW_MOUSE_BUTTON_RIGHT, nameof(GLFW_MOUSE_BUTTON_RIGHT)),
        //new KeyValuePair<int, string>(GLFW_MOUSE_BUTTON_MIDDLE, nameof(GLFW_MOUSE_BUTTON_MIDDLE)),
    ]);

    internal static readonly FrozenDictionary<int, string> JoystickTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_JOYSTICK_1, nameof(GLFW_JOYSTICK_1)),
        new KeyValuePair<int, string>(GLFW_JOYSTICK_2, nameof(GLFW_JOYSTICK_2)),
        new KeyValuePair<int, string>(GLFW_JOYSTICK_3, nameof(GLFW_JOYSTICK_3)),
        new KeyValuePair<int, string>(GLFW_JOYSTICK_4, nameof(GLFW_JOYSTICK_4)),
        new KeyValuePair<int, string>(GLFW_JOYSTICK_5, nameof(GLFW_JOYSTICK_5)),
        new KeyValuePair<int, string>(GLFW_JOYSTICK_6, nameof(GLFW_JOYSTICK_6)),
        new KeyValuePair<int, string>(GLFW_JOYSTICK_7, nameof(GLFW_JOYSTICK_7)),
        new KeyValuePair<int, string>(GLFW_JOYSTICK_8, nameof(GLFW_JOYSTICK_8)),
        new KeyValuePair<int, string>(GLFW_JOYSTICK_9, nameof(GLFW_JOYSTICK_9)),
        new KeyValuePair<int, string>(GLFW_JOYSTICK_10, nameof(GLFW_JOYSTICK_10)),
        new KeyValuePair<int, string>(GLFW_JOYSTICK_11, nameof(GLFW_JOYSTICK_11)),
        new KeyValuePair<int, string>(GLFW_JOYSTICK_12, nameof(GLFW_JOYSTICK_12)),
        new KeyValuePair<int, string>(GLFW_JOYSTICK_13, nameof(GLFW_JOYSTICK_13)),
        new KeyValuePair<int, string>(GLFW_JOYSTICK_14, nameof(GLFW_JOYSTICK_14)),
        new KeyValuePair<int, string>(GLFW_JOYSTICK_15, nameof(GLFW_JOYSTICK_15)),
        new KeyValuePair<int, string>(GLFW_JOYSTICK_16, nameof(GLFW_JOYSTICK_16)),
    ]);

    internal static readonly FrozenDictionary<int, string> GamepadButtonTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_GAMEPAD_BUTTON_A, nameof(GLFW_GAMEPAD_BUTTON_A)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_BUTTON_B, nameof(GLFW_GAMEPAD_BUTTON_B)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_BUTTON_X, nameof(GLFW_GAMEPAD_BUTTON_X)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_BUTTON_Y, nameof(GLFW_GAMEPAD_BUTTON_Y)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_BUTTON_LEFT_BUMPER, nameof(GLFW_GAMEPAD_BUTTON_LEFT_BUMPER)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER, nameof(GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_BUTTON_BACK, nameof(GLFW_GAMEPAD_BUTTON_BACK)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_BUTTON_START, nameof(GLFW_GAMEPAD_BUTTON_START)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_BUTTON_GUIDE, nameof(GLFW_GAMEPAD_BUTTON_GUIDE)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_BUTTON_LEFT_THUMB, nameof(GLFW_GAMEPAD_BUTTON_LEFT_THUMB)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_BUTTON_RIGHT_THUMB, nameof(GLFW_GAMEPAD_BUTTON_RIGHT_THUMB)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_BUTTON_DPAD_UP, nameof(GLFW_GAMEPAD_BUTTON_DPAD_UP)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_BUTTON_DPAD_RIGHT, nameof(GLFW_GAMEPAD_BUTTON_DPAD_RIGHT)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_BUTTON_DPAD_DOWN, nameof(GLFW_GAMEPAD_BUTTON_DPAD_DOWN)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_BUTTON_DPAD_LEFT, nameof(GLFW_GAMEPAD_BUTTON_DPAD_LEFT)),
    ]);

    internal static readonly FrozenDictionary<int, string> GamepadAxisTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_GAMEPAD_AXIS_LEFT_X, nameof(GLFW_GAMEPAD_AXIS_LEFT_X)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_AXIS_LEFT_Y, nameof(GLFW_GAMEPAD_AXIS_LEFT_Y)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_AXIS_RIGHT_X, nameof(GLFW_GAMEPAD_AXIS_RIGHT_X)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_AXIS_RIGHT_Y, nameof(GLFW_GAMEPAD_AXIS_RIGHT_Y)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_AXIS_LEFT_TRIGGER, nameof(GLFW_GAMEPAD_AXIS_LEFT_TRIGGER)),
        new KeyValuePair<int, string>(GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER, nameof(GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER)),
    ]);

    internal static readonly FrozenDictionary<int, string> ErrorCodeTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_NO_ERROR, nameof(GLFW_NO_ERROR)),
        new KeyValuePair<int, string>(GLFW_NOT_INITIALIZED, nameof(GLFW_NOT_INITIALIZED)),
        new KeyValuePair<int, string>(GLFW_NO_CURRENT_CONTEXT, nameof(GLFW_NO_CURRENT_CONTEXT)),
        new KeyValuePair<int, string>(GLFW_INVALID_ENUM, nameof(GLFW_INVALID_ENUM)),
        new KeyValuePair<int, string>(GLFW_INVALID_VALUE, nameof(GLFW_INVALID_VALUE)),
        new KeyValuePair<int, string>(GLFW_OUT_OF_MEMORY, nameof(GLFW_OUT_OF_MEMORY)),
        new KeyValuePair<int, string>(GLFW_API_UNAVAILABLE, nameof(GLFW_API_UNAVAILABLE)),
        new KeyValuePair<int, string>(GLFW_VERSION_UNAVAILABLE, nameof(GLFW_VERSION_UNAVAILABLE)),
        new KeyValuePair<int, string>(GLFW_PLATFORM_ERROR, nameof(GLFW_PLATFORM_ERROR)),
        new KeyValuePair<int, string>(GLFW_FORMAT_UNAVAILABLE, nameof(GLFW_FORMAT_UNAVAILABLE)),
        new KeyValuePair<int, string>(GLFW_NO_WINDOW_CONTEXT, nameof(GLFW_NO_WINDOW_CONTEXT)),
        new KeyValuePair<int, string>(GLFW_CURSOR_UNAVAILABLE, nameof(GLFW_CURSOR_UNAVAILABLE)),
        new KeyValuePair<int, string>(GLFW_FEATURE_UNAVAILABLE, nameof(GLFW_FEATURE_UNAVAILABLE)),
        new KeyValuePair<int, string>(GLFW_FEATURE_UNIMPLEMENTED, nameof(GLFW_FEATURE_UNIMPLEMENTED)),
        new KeyValuePair<int, string>(GLFW_PLATFORM_UNAVAILABLE, nameof(GLFW_PLATFORM_UNAVAILABLE)),
    ]);

    internal static readonly FrozenDictionary<int, string> HintAndAttributeTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_FOCUSED, nameof(GLFW_FOCUSED)),
        new KeyValuePair<int, string>(GLFW_ICONIFIED, nameof(GLFW_ICONIFIED)),
        new KeyValuePair<int, string>(GLFW_RESIZABLE, nameof(GLFW_RESIZABLE)),
        new KeyValuePair<int, string>(GLFW_VISIBLE, nameof(GLFW_VISIBLE)),
        new KeyValuePair<int, string>(GLFW_DECORATED, nameof(GLFW_DECORATED)),
        new KeyValuePair<int, string>(GLFW_AUTO_ICONIFY, nameof(GLFW_AUTO_ICONIFY)),
        new KeyValuePair<int, string>(GLFW_FLOATING, nameof(GLFW_FLOATING)),
        new KeyValuePair<int, string>(GLFW_MAXIMIZED, nameof(GLFW_MAXIMIZED)),
        new KeyValuePair<int, string>(GLFW_CENTER_CURSOR, nameof(GLFW_CENTER_CURSOR)),
        new KeyValuePair<int, string>(GLFW_TRANSPARENT_FRAMEBUFFER, nameof(GLFW_TRANSPARENT_FRAMEBUFFER)),
        new KeyValuePair<int, string>(GLFW_HOVERED, nameof(GLFW_HOVERED)),
        new KeyValuePair<int, string>(GLFW_FOCUS_ON_SHOW, nameof(GLFW_FOCUS_ON_SHOW)),
        new KeyValuePair<int, string>(GLFW_MOUSE_PASSTHROUGH, nameof(GLFW_MOUSE_PASSTHROUGH)),
        new KeyValuePair<int, string>(GLFW_POSITION_X, nameof(GLFW_POSITION_X)),
        new KeyValuePair<int, string>(GLFW_POSITION_Y, nameof(GLFW_POSITION_Y)),
        new KeyValuePair<int, string>(GLFW_RED_BITS, nameof(GLFW_RED_BITS)),
        new KeyValuePair<int, string>(GLFW_GREEN_BITS, nameof(GLFW_GREEN_BITS)),
        new KeyValuePair<int, string>(GLFW_BLUE_BITS, nameof(GLFW_BLUE_BITS)),
        new KeyValuePair<int, string>(GLFW_ALPHA_BITS, nameof(GLFW_ALPHA_BITS)),
        new KeyValuePair<int, string>(GLFW_DEPTH_BITS, nameof(GLFW_DEPTH_BITS)),
        new KeyValuePair<int, string>(GLFW_STENCIL_BITS, nameof(GLFW_STENCIL_BITS)),
        new KeyValuePair<int, string>(GLFW_ACCUM_RED_BITS, nameof(GLFW_ACCUM_RED_BITS)),
        new KeyValuePair<int, string>(GLFW_ACCUM_GREEN_BITS, nameof(GLFW_ACCUM_GREEN_BITS)),
        new KeyValuePair<int, string>(GLFW_ACCUM_BLUE_BITS, nameof(GLFW_ACCUM_BLUE_BITS)),
        new KeyValuePair<int, string>(GLFW_ACCUM_ALPHA_BITS, nameof(GLFW_ACCUM_ALPHA_BITS)),
        new KeyValuePair<int, string>(GLFW_AUX_BUFFERS, nameof(GLFW_AUX_BUFFERS)),
        new KeyValuePair<int, string>(GLFW_STEREO, nameof(GLFW_STEREO)),
        new KeyValuePair<int, string>(GLFW_SAMPLES, nameof(GLFW_SAMPLES)),
        new KeyValuePair<int, string>(GLFW_SRGB_CAPABLE, nameof(GLFW_SRGB_CAPABLE)),
        new KeyValuePair<int, string>(GLFW_REFRESH_RATE, nameof(GLFW_REFRESH_RATE)),
        new KeyValuePair<int, string>(GLFW_DOUBLEBUFFER, nameof(GLFW_DOUBLEBUFFER)),
        new KeyValuePair<int, string>(GLFW_CLIENT_API, nameof(GLFW_CLIENT_API)),
        new KeyValuePair<int, string>(GLFW_CONTEXT_VERSION_MAJOR, nameof(GLFW_CONTEXT_VERSION_MAJOR)),
        new KeyValuePair<int, string>(GLFW_CONTEXT_VERSION_MINOR, nameof(GLFW_CONTEXT_VERSION_MINOR)),
        new KeyValuePair<int, string>(GLFW_CONTEXT_REVISION, nameof(GLFW_CONTEXT_REVISION)),
        new KeyValuePair<int, string>(GLFW_CONTEXT_ROBUSTNESS, nameof(GLFW_CONTEXT_ROBUSTNESS)),
        new KeyValuePair<int, string>(GLFW_OPENGL_FORWARD_COMPAT, nameof(GLFW_OPENGL_FORWARD_COMPAT)),
        new KeyValuePair<int, string>(GLFW_CONTEXT_DEBUG, nameof(GLFW_CONTEXT_DEBUG)),
        new KeyValuePair<int, string>(GLFW_OPENGL_PROFILE, nameof(GLFW_OPENGL_PROFILE)),
        new KeyValuePair<int, string>(GLFW_CONTEXT_RELEASE_BEHAVIOR, nameof(GLFW_CONTEXT_RELEASE_BEHAVIOR)),
        new KeyValuePair<int, string>(GLFW_CONTEXT_NO_ERROR, nameof(GLFW_CONTEXT_NO_ERROR)),
        new KeyValuePair<int, string>(GLFW_CONTEXT_CREATION_API, nameof(GLFW_CONTEXT_CREATION_API)),
        new KeyValuePair<int, string>(GLFW_SCALE_TO_MONITOR, nameof(GLFW_SCALE_TO_MONITOR)),
        new KeyValuePair<int, string>(GLFW_SCALE_FRAMEBUFFER, nameof(GLFW_SCALE_FRAMEBUFFER)),
        new KeyValuePair<int, string>(GLFW_COCOA_RETINA_FRAMEBUFFER, nameof(GLFW_COCOA_RETINA_FRAMEBUFFER)),
        new KeyValuePair<int, string>(GLFW_COCOA_FRAME_NAME, nameof(GLFW_COCOA_FRAME_NAME)),
        new KeyValuePair<int, string>(GLFW_COCOA_GRAPHICS_SWITCHING, nameof(GLFW_COCOA_GRAPHICS_SWITCHING)),
        new KeyValuePair<int, string>(GLFW_X11_CLASS_NAME, nameof(GLFW_X11_CLASS_NAME)),
        new KeyValuePair<int, string>(GLFW_X11_INSTANCE_NAME, nameof(GLFW_X11_INSTANCE_NAME)),
        new KeyValuePair<int, string>(GLFW_WIN32_KEYBOARD_MENU, nameof(GLFW_WIN32_KEYBOARD_MENU)),
        new KeyValuePair<int, string>(GLFW_WIN32_SHOWDEFAULT, nameof(GLFW_WIN32_SHOWDEFAULT)),
        new KeyValuePair<int, string>(GLFW_WAYLAND_APP_ID, nameof(GLFW_WAYLAND_APP_ID)),
    ]);


    internal static readonly FrozenDictionary<int, string> ClientAPIHintTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_NO_API, nameof(GLFW_NO_API)),
        new KeyValuePair<int, string>(GLFW_OPENGL_API, nameof(GLFW_OPENGL_API)),
        new KeyValuePair<int, string>(GLFW_OPENGL_ES_API, nameof(GLFW_OPENGL_ES_API)),
    ]);


    internal static readonly FrozenDictionary<int, string> GLRobustnessHintTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_NO_ROBUSTNESS, nameof(GLFW_NO_ROBUSTNESS)),
        new KeyValuePair<int, string>(GLFW_NO_RESET_NOTIFICATION, nameof(GLFW_NO_RESET_NOTIFICATION)),
        new KeyValuePair<int, string>(GLFW_LOSE_CONTEXT_ON_RESET, nameof(GLFW_LOSE_CONTEXT_ON_RESET)),
    ]);


    internal static readonly FrozenDictionary<int, string> GLProfileHintTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_OPENGL_ANY_PROFILE, nameof(GLFW_OPENGL_ANY_PROFILE)),
        new KeyValuePair<int, string>(GLFW_OPENGL_CORE_PROFILE, nameof(GLFW_OPENGL_CORE_PROFILE)),
        new KeyValuePair<int, string>(GLFW_OPENGL_COMPAT_PROFILE, nameof(GLFW_OPENGL_COMPAT_PROFILE)),
    ]);


    internal static readonly FrozenDictionary<int, string> WindowInputOptionTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_CURSOR, nameof(GLFW_CURSOR)),
        new KeyValuePair<int, string>(GLFW_STICKY_KEYS, nameof(GLFW_STICKY_KEYS)),
        new KeyValuePair<int, string>(GLFW_STICKY_MOUSE_BUTTONS, nameof(GLFW_STICKY_MOUSE_BUTTONS)),
        new KeyValuePair<int, string>(GLFW_LOCK_KEY_MODS, nameof(GLFW_LOCK_KEY_MODS)),
        new KeyValuePair<int, string>(GLFW_RAW_MOUSE_MOTION, nameof(GLFW_RAW_MOUSE_MOTION)),
    ]);


    internal static readonly FrozenDictionary<int, string> CursorModeTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_CURSOR_NORMAL, nameof(GLFW_CURSOR_NORMAL)),
        new KeyValuePair<int, string>(GLFW_CURSOR_HIDDEN, nameof(GLFW_CURSOR_HIDDEN)),
        new KeyValuePair<int, string>(GLFW_CURSOR_DISABLED, nameof(GLFW_CURSOR_DISABLED)),
        new KeyValuePair<int, string>(GLFW_CURSOR_CAPTURED, nameof(GLFW_CURSOR_CAPTURED)),
    ]);


    internal static readonly FrozenDictionary<int, string> ReleaseModeTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_ANY_RELEASE_BEHAVIOR, nameof(GLFW_ANY_RELEASE_BEHAVIOR)),
        new KeyValuePair<int, string>(GLFW_RELEASE_BEHAVIOR_FLUSH, nameof(GLFW_RELEASE_BEHAVIOR_FLUSH)),
        new KeyValuePair<int, string>(GLFW_RELEASE_BEHAVIOR_NONE, nameof(GLFW_RELEASE_BEHAVIOR_NONE)),
    ]);


    internal static readonly FrozenDictionary<int, string> ContextAPIHintTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_NATIVE_CONTEXT_API, nameof(GLFW_NATIVE_CONTEXT_API)),
        new KeyValuePair<int, string>(GLFW_EGL_CONTEXT_API, nameof(GLFW_EGL_CONTEXT_API)),
        new KeyValuePair<int, string>(GLFW_OSMESA_CONTEXT_API, nameof(GLFW_OSMESA_CONTEXT_API)),
    ]);


    internal static readonly FrozenDictionary<int, string> ANGLEPlatformTypeHintTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_ANGLE_PLATFORM_TYPE_NONE, nameof(GLFW_ANGLE_PLATFORM_TYPE_NONE)),
        new KeyValuePair<int, string>(GLFW_ANGLE_PLATFORM_TYPE_OPENGL, nameof(GLFW_ANGLE_PLATFORM_TYPE_OPENGL)),
        new KeyValuePair<int, string>(GLFW_ANGLE_PLATFORM_TYPE_OPENGLES, nameof(GLFW_ANGLE_PLATFORM_TYPE_OPENGLES)),
        new KeyValuePair<int, string>(GLFW_ANGLE_PLATFORM_TYPE_D3D9, nameof(GLFW_ANGLE_PLATFORM_TYPE_D3D9)),
        new KeyValuePair<int, string>(GLFW_ANGLE_PLATFORM_TYPE_D3D11, nameof(GLFW_ANGLE_PLATFORM_TYPE_D3D11)),
        new KeyValuePair<int, string>(GLFW_ANGLE_PLATFORM_TYPE_VULKAN, nameof(GLFW_ANGLE_PLATFORM_TYPE_VULKAN)),
        new KeyValuePair<int, string>(GLFW_ANGLE_PLATFORM_TYPE_METAL, nameof(GLFW_ANGLE_PLATFORM_TYPE_METAL)),
    ]);


    internal static readonly FrozenDictionary<int, string> WaylandLibdecorHintTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_WAYLAND_PREFER_LIBDECOR, nameof(GLFW_WAYLAND_PREFER_LIBDECOR)),
        new KeyValuePair<int, string>(GLFW_WAYLAND_DISABLE_LIBDECOR, nameof(GLFW_WAYLAND_DISABLE_LIBDECOR)),
    ]);


    internal static readonly FrozenDictionary<int, string> StandardCursorShapeTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_ARROW_CURSOR, nameof(GLFW_ARROW_CURSOR)),
        new KeyValuePair<int, string>(GLFW_IBEAM_CURSOR, nameof(GLFW_IBEAM_CURSOR)),
        new KeyValuePair<int, string>(GLFW_CROSSHAIR_CURSOR, nameof(GLFW_CROSSHAIR_CURSOR)),
        new KeyValuePair<int, string>(GLFW_POINTING_HAND_CURSOR, nameof(GLFW_POINTING_HAND_CURSOR)),
        new KeyValuePair<int, string>(GLFW_RESIZE_EW_CURSOR, nameof(GLFW_RESIZE_EW_CURSOR)),
        new KeyValuePair<int, string>(GLFW_RESIZE_NS_CURSOR, nameof(GLFW_RESIZE_NS_CURSOR)),
        new KeyValuePair<int, string>(GLFW_RESIZE_NWSE_CURSOR, nameof(GLFW_RESIZE_NWSE_CURSOR)),
        new KeyValuePair<int, string>(GLFW_RESIZE_NESW_CURSOR, nameof(GLFW_RESIZE_NESW_CURSOR)),
        new KeyValuePair<int, string>(GLFW_RESIZE_ALL_CURSOR, nameof(GLFW_RESIZE_ALL_CURSOR)),
        new KeyValuePair<int, string>(GLFW_NOT_ALLOWED_CURSOR, nameof(GLFW_NOT_ALLOWED_CURSOR)),
    ]);


    internal static readonly FrozenDictionary<int, string> MonitorAndJoystickEventTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_CONNECTED, nameof(GLFW_CONNECTED)),
        new KeyValuePair<int, string>(GLFW_DISCONNECTED, nameof(GLFW_DISCONNECTED)),
    ]);


    internal static readonly FrozenDictionary<int, string> JoystickHatButtonInitTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_JOYSTICK_HAT_BUTTONS, nameof(GLFW_JOYSTICK_HAT_BUTTONS)),
    ]);


    internal static readonly FrozenDictionary<int, string> ANGLERenderingBackendInitHintTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_ANGLE_PLATFORM_TYPE, nameof(GLFW_ANGLE_PLATFORM_TYPE)),
    ]);


    internal static readonly FrozenDictionary<int, string> MacOSSpecificInitHintTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_COCOA_CHDIR_RESOURCES, nameof(GLFW_COCOA_CHDIR_RESOURCES)),
        new KeyValuePair<int, string>(GLFW_COCOA_MENUBAR, nameof(GLFW_COCOA_MENUBAR)),
    ]);


    internal static readonly FrozenDictionary<int, string> X11SpecificHintTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_X11_XCB_VULKAN_SURFACE, nameof(GLFW_X11_XCB_VULKAN_SURFACE)),
    ]);


    internal static readonly FrozenDictionary<int, string> WaylandSpecificHintTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_WAYLAND_LIBDECOR, nameof(GLFW_WAYLAND_LIBDECOR)),
    ]);
    

    internal static readonly FrozenDictionary<int, string> PlatformHintTokens = FrozenDictionary.ToFrozenDictionary([
        new KeyValuePair<int, string>(GLFW_ANY_PLATFORM, nameof(GLFW_ANY_PLATFORM)),
        new KeyValuePair<int, string>(GLFW_PLATFORM_WIN32, nameof(GLFW_PLATFORM_WIN32)),
        new KeyValuePair<int, string>(GLFW_PLATFORM_COCOA, nameof(GLFW_PLATFORM_COCOA)),
        new KeyValuePair<int, string>(GLFW_PLATFORM_WAYLAND, nameof(GLFW_PLATFORM_WAYLAND)),
        new KeyValuePair<int, string>(GLFW_PLATFORM_X11, nameof(GLFW_PLATFORM_X11)),
        new KeyValuePair<int, string>(GLFW_PLATFORM_NULL, nameof(GLFW_PLATFORM_NULL)),
    ]);

    internal static string FormatToken(int value, FrozenDictionary<int, string> dictionary, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string? format = null, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string? formatWithName = null) {
        if (dictionary.TryGetValue(value, out string? name)) {
            return string.Format(formatWithName ?? "{0} ({1})", value, name);
        }

        return string.Format(format ?? "{0}", value);
    }

    internal static string FormatTokenFlags(int value, FrozenDictionary<int, string> dictionary, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string? format = null, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string? formatWithName = null) {
        var names = new List<string>();
        foreach ((int key, string name) in dictionary.Reverse()) {
            if ((value & key) > 0) {
                names.Add(name);
            }
        }

        if (names.Count > 0) {
            return string.Format(formatWithName ?? "{0} ({1})", value, string.Join(" | ", names));
        }

        return string.Format(format ?? "{0}", value);
    }

    internal static string FormatTokenHex4(int value, FrozenDictionary<int, string> dictionary) {
        return FormatToken(value, dictionary, "0x{0:X4}", "0x{0:X4} ({1})");
    }

    internal static string FormatTokenHex4Flags(int value, FrozenDictionary<int, string> dictionary) {
        return FormatTokenFlags(value, dictionary, "0x{0:X4}", "0x{0:X4} ({1})");
    }

    internal static string FormatTokenHex8(int value, FrozenDictionary<int, string> dictionary) {
        return FormatToken(value, dictionary, "0x{0:X8}", "0x{0:X8} ({1})");
    }

    internal static string FormatTokenHex8Flags(int value, FrozenDictionary<int, string> dictionary) {
        return FormatTokenFlags(value, dictionary, "0x{0:X8}", "0x{0:X8} ({1})");
    }

    //
    //

    public static string FormatKeyAction(int value) {
        return FormatToken(value, KeyAndButtonActionTokens);
    }

    public static string FormatButtonAction(int value) {
        return FormatKeyAction(value);
    }

    public static string FormatJoystickHatState(int value) {
        return FormatToken(value, JoystickHatStateTokens);
    }

    public static string FormatKeyboardKey(int value) {
        return FormatToken(value, KeyboardKeyTokens);
    }

    public static string FormatModifierKey(int value) {
        return FormatTokenHex4Flags(value, ModifierKeyFlagTokens);
    }

    public static string FormatMouseButton(int value) {
        return FormatToken(value, MouseButtonTokens);
    }

    public static string FormatJoystick(int value) {
        return FormatToken(value, JoystickTokens);
    }

    public static string FormatGamepadButton(int value) {
        return FormatToken(value, GamepadButtonTokens);
    }

    public static string FormatGamepadAxis(int value) {
        return FormatToken(value, GamepadAxisTokens);
    }

    public static string FormatErrorCode(int value) {
        return FormatTokenHex8(value, ErrorCodeTokens);
    }

    public static string FormatWindowHint(int value) {
        return FormatTokenHex8(value, HintAndAttributeTokens);
    }

    public static string FormatWindowAttribute(int value) {
        return FormatTokenHex8(value, HintAndAttributeTokens);
    }

    public static string FormatClientAPIHint(int value) {
        return FormatTokenHex8(value, ClientAPIHintTokens);
    }

    public static string FormatGLRobustnessHint(int value) {
        return FormatTokenHex8(value, GLRobustnessHintTokens);
    }

    public static string FormatGLProfileHint(int value) {
        return FormatTokenHex8(value, GLProfileHintTokens);
    }

    public static string FormatWindowInputOption(int value) {
        return FormatTokenHex8(value, WindowInputOptionTokens);
    }

    public static string FormatCursorMode(int value) {
        return FormatTokenHex8(value, CursorModeTokens);
    }

    public static string FormatReleaseMode(int value) {
        return FormatTokenHex8(value, ReleaseModeTokens);
    }

    public static string FormatContextAPIHint(int value) {
        return FormatTokenHex8(value, ContextAPIHintTokens);
    }

    public static string FormatANGLEPlatformTypeHint(int value) {
        return FormatTokenHex8(value, ANGLEPlatformTypeHintTokens);
    }

    public static string FormatWaylandLibdecorHint(int value) {
        return FormatTokenHex8(value, WaylandLibdecorHintTokens);
    }

    public static string FormatStandardCursorShape(int value) {
        return FormatTokenHex8(value, StandardCursorShapeTokens);
    }

    public static string FormatMonitorEvent(int value) {
        return FormatTokenHex8(value, MonitorAndJoystickEventTokens);
    }

    public static string FormatJoystickEvent(int value) {
        return FormatTokenHex8(value, MonitorAndJoystickEventTokens);
    }

    public static string FormatJoystickHatButtonInit(int value) {
        return FormatTokenHex8(value, JoystickHatButtonInitTokens);
    }

    public static string FormatANGLERenderingBackendInitHint(int value) {
        return FormatTokenHex8(value, ANGLERenderingBackendInitHintTokens);
    }

    public static string FormatMacOSSpecificInitHint(int value) {
        return FormatTokenHex8(value, MacOSSpecificInitHintTokens);
    }

    public static string FormatX11SpecificHint(int value) {
        return FormatTokenHex8(value, X11SpecificHintTokens);
    }

    public static string FormatWaylandSpecificHint(int value) {
        return FormatTokenHex8(value, WaylandSpecificHintTokens);
    }

    public static string FormatPlatformHint(int value) {
        return FormatTokenHex8(value, PlatformHintTokens);
    }
}
