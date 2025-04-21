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

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Isojk.Csglfw;

using LibraryCallConv = CallConvCdecl;

using unsafe GLFWerrorfun_ptr = delegate* unmanaged[Cdecl]<int, byte*, void>;
using unsafe GLFWwindowposfun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, int, int, void>;
using unsafe GLFWwindowsizefun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, int, int, void>;
using unsafe GLFWwindowclosefun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, void>;
using unsafe GLFWwindowrefreshfun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, void>;
using unsafe GLFWwindowfocusfun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, bool, void>;
using unsafe GLFWwindowiconifyfun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, bool, void>;
using unsafe GLFWwindowmaximizefun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, bool, void>;
using unsafe GLFWframebuffersizefun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, int, int, void>;
using unsafe GLFWwindowcontentscalefun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, float, float, void>;
using unsafe GLFWmousebuttonfun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, int, int, int, void>;
using unsafe GLFWcursorposfun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, double, double, void>;
using unsafe GLFWcursorenterfun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, bool, void>;
using unsafe GLFWscrollfun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, double, double, void>;
using unsafe GLFWkeyfun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, int, int, int, int, void>;
using unsafe GLFWcharfun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, uint, void>;
using unsafe GLFWcharmodsfun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, uint, int, void>;
using unsafe GLFWdropfun_ptr = delegate* unmanaged[Cdecl]<API.GLFWwindow, int, byte**, void>;
using unsafe GLFWmonitorfun_ptr = delegate* unmanaged[Cdecl]<API.GLFWmonitor, int, void>;
using unsafe GLFWjoystickfun_ptr = delegate* unmanaged[Cdecl]<int, int, void>;

public static partial class API {
    public static partial class Unsafe {
        static Unsafe() {
            RuntimeHelpers.RunClassConstructor(typeof(API).TypeHandle); 
        }

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__init.html#ga9dde93e9891fa7dd17e4194c9f3ae7c6"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial void glfwInitAllocator(in GLFWallocator allocator);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__init.html#ga026abd003c8e6501981ab1662062f1c0"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial byte* glfwGetVersionString();

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__init.html#ga944986b4ec0b928d488141f92982aa18"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial int glfwGetError(out byte* description);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__init.html#gaff45816610d53f0b83656092a4034f40"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWerrorfun_ptr glfwSetErrorCallback(GLFWerrorfun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetErrorCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetErrorCallback_erased(void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#ga70b1156d5d24e9928f145d6c864369d2"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWmonitor* glfwGetMonitors(out int count);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#ga7af83e13489d90379588fb331b9e4b68"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial byte* glfwGetMonitorName(GLFWmonitor monitor);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#ga702750e24313a686d3637297b6e85fda"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial void glfwSetMonitorUserPointer(GLFWmonitor monitor, nint pointer);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#ga1adbfbfb8cd58b23cfee82e574fbbdc5"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial nint glfwGetMonitorUserPointer(GLFWmonitor monitor);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#gab39df645587c8518192aa746c2fb06c3"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWmonitorfun_ptr glfwSetMonitorCallback(GLFWmonitorfun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetMonitorCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetMonitorCallback_erased(void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#gad2e24d2843cb7d6c26202cddd530fc1b"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWvidmode* glfwGetVideoModes(GLFWmonitor monitor, out int count);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#gaba376fa7e76634b4788bddc505d6c9d5"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWvidmode* glfwGetVideoMode(GLFWmonitor monitor);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#ga76ba90debcf0062b5c4b73052b24f96f"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWgammaramp* glfwGetGammaRamp(GLFWmonitor monitor);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga8cb2782861c9d997bcf2dea97f363e5f"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial void glfwWindowHintString(int hint, byte* value);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga3555a418df92ad53f917597fe2f64aeb"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWwindow glfwCreateWindow(int width, int height, byte* title, GLFWmonitor monitor, GLFWwindow share);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gac6151765c54b789c4fe66c6bc6215953"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial byte* glfwGetWindowTitle(GLFWwindow window);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga5d877f09e968cef7a360b513306f17ff"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial void glfwSetWindowTitle(GLFWwindow window, byte* title);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gadd7ccd39fe7a7d1f0904666ae5932dc5"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial void glfwSetWindowIcon(GLFWwindow window, int count, GLFWimage* images);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga3d2fc6026e690ab31a13f78bc9fd3651"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial void glfwSetWindowUserPointer(GLFWwindow window, nint pointer);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gae77a4add0d2023ca21ff1443ced01653"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial nint glfwGetWindowUserPointer(GLFWwindow window);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga08bdfbba88934f9c4f92fd757979ac74"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWwindowposfun_ptr glfwSetWindowPosCallback(GLFWwindow window, GLFWwindowposfun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetWindowPosCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetWindowPosCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gad91b8b047a0c4c6033c38853864c34f8"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWwindowsizefun_ptr glfwSetWindowSizeCallback(GLFWwindow window, GLFWwindowsizefun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetWindowSizeCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetWindowSizeCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gada646d775a7776a95ac000cfc1885331"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWwindowclosefun_ptr glfwSetWindowCloseCallback(GLFWwindow window, GLFWwindowclosefun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetWindowCloseCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetWindowCloseCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga1c5c7eb889c33c7f4d10dd35b327654e"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWwindowrefreshfun_ptr glfwSetWindowRefreshCallback(GLFWwindow window, GLFWwindowrefreshfun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetWindowRefreshCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetWindowRefreshCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gac2d83c4a10f071baf841f6730528e66c"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWwindowfocusfun_ptr glfwSetWindowFocusCallback(GLFWwindow window, GLFWwindowfocusfun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetWindowFocusCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetWindowFocusCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gac793e9efd255567b5fb8b445052cfd3e"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWwindowiconifyfun_ptr glfwSetWindowIconifyCallback(GLFWwindow window, GLFWwindowiconifyfun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetWindowIconifyCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetWindowIconifyCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gacbe64c339fbd94885e62145563b6dc93"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWwindowmaximizefun_ptr glfwSetWindowMaximizeCallback(GLFWwindow window, GLFWwindowmaximizefun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetWindowMaximizeCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetWindowMaximizeCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gab3fb7c3366577daef18c0023e2a8591f"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWframebuffersizefun_ptr glfwSetFramebufferSizeCallback(GLFWwindow window, GLFWframebuffersizefun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetFramebufferSizeCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetFramebufferSizeCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gaf2832ebb5aa6c252a2d261de002c92d6"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWwindowcontentscalefun_ptr glfwSetWindowContentScaleCallback(GLFWwindow window, GLFWwindowcontentscalefun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetWindowContentScaleCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetWindowContentScaleCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gaeaed62e69c3bd62b7ff8f7b19913ce4f"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial byte* glfwGetKeyName(int key, int scancode);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga1caf18159767e761185e49a3be019f8d"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWkeyfun_ptr glfwSetKeyCallback(GLFWwindow window, GLFWkeyfun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetKeyCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetKeyCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gab25c4a220fd8f5717718dbc487828996"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWcharfun_ptr glfwSetCharCallback(GLFWwindow window, GLFWcharfun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetCharCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetCharCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga0b7f4ad13c2b17435ff13b6dcfb4e43c"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWcharmodsfun_ptr glfwSetCharModsCallback(GLFWwindow window, GLFWcharmodsfun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetCharModsCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetCharModsCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga6ab84420974d812bee700e45284a723c"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWmousebuttonfun_ptr glfwSetMouseButtonCallback(GLFWwindow window, GLFWmousebuttonfun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetMouseButtonCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetMouseButtonCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gac1f879ab7435d54d4d79bb469fe225d7"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWcursorposfun_ptr glfwSetCursorPosCallback(GLFWwindow window, GLFWcursorposfun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetCursorPosCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetCursorPosCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gad27f8ad0142c038a281466c0966817d8"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWcursorenterfun_ptr glfwSetCursorEnterCallback(GLFWwindow window, GLFWcursorenterfun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetCursorEnterCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetCursorEnterCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga571e45a030ae4061f746ed56cb76aede"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWscrollfun_ptr glfwSetScrollCallback(GLFWwindow window, GLFWscrollfun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetScrollCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetScrollCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gab773f0ee0a07cff77a210cea40bc1f6b"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWdropfun_ptr glfwSetDropCallback(GLFWwindow window, GLFWdropfun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetDropCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetDropCallback_erased(GLFWwindow window, void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gaeb1c0191d3140a233a682987c61eb408"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial float* glfwGetJoystickAxes(int jid, out int count);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga5ffe34739d3dc97efe432ed2d81d9938"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial byte* glfwGetJoystickButtons(int jid, out int count);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga06e660841b3e79c54da4f54a932c5a2c"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial byte* glfwGetJoystickHats(int jid, out int count);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gac6a8e769e18e0bcfa9097793fc2c3978"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial byte* glfwGetJoystickName(int jid);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga6659411aec3c7fcef27780e2cb2d9600"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial byte* glfwGetJoystickGUID(int jid);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga6b2f72d64d636b48a727b437cbb7489e"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial void glfwSetJoystickUserPointer(int jid, nint pointer);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga18cefd7265d1fa04f3fd38a6746db5f3"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial nint glfwGetJoystickUserPointer(int jid);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga2f60a0e5b7bd8d1b7344dc0a7cb32b4c"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial GLFWjoystickfun_ptr glfwSetJoystickCallback(GLFWjoystickfun_ptr callback);

        [LibraryImport(LibraryName, EntryPoint = nameof(glfwSetJoystickCallback))]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        internal static unsafe partial void* glfwSetJoystickCallback_erased(void* callback);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gaed5104612f2fa8e66aa6e846652ad00f"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial int glfwUpdateGamepadMappings(byte* @string);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga8aea73a1a25cc6c0486a617019f56728"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial byte* glfwGetGamepadName(int jid);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gaba1f022c5eb07dfac421df34cdcd31dd"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial void glfwSetClipboardString(GLFWwindow window, byte* @string);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga71a5b20808ea92193d65c21b82580355"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial byte* glfwGetClipboardString(GLFWwindow window);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__context.html#ga87425065c011cef1ebd6aac75e059dfa"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial int glfwExtensionSupported(byte* extension);

        /// <summary>
        /// <see href="https://www.glfw.org/docs/3.4/group__context.html#ga35f1837e6f666781842483937612f163"/>
        /// </summary>
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
        public static unsafe partial nint glfwGetProcAddress(byte* name);
    }
}