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
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Isojk.Csglfw;

using LibraryCallConv = CallConvCdecl;

public static partial class API {
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWerrorfun(int error, [MarshalAs(UnmanagedType.LPUTF8Str)] string? description);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWmonitorfun(GLFWmonitor monitor, int @event);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWwindowposfun(GLFWwindow window, int xpos, int ypos);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWwindowsizefun(GLFWwindow window, int width, int height);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWwindowclosefun(GLFWwindow window);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWwindowrefreshfun(GLFWwindow window);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWwindowfocusfun(GLFWwindow window, [MarshalAs(UnmanagedType.I4)] bool focused);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWwindowiconifyfun(GLFWwindow window, [MarshalAs(UnmanagedType.I4)] bool iconified);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWwindowmaximizefun(GLFWwindow window, [MarshalAs(UnmanagedType.I4)] bool maximized);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWframebuffersizefun(GLFWwindow window, int width, int height);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWwindowcontentscalefun(GLFWwindow window, float xscale, float yscale);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWkeyfun(GLFWwindow window, int key, int scancode, int action, int mods);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWcharfun(GLFWwindow window, uint codepoint);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWcharmodsfun(GLFWwindow window, uint codepoint, int mods);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWmousebuttonfun(GLFWwindow window, int button, int action, int mods);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWcursorposfun(GLFWwindow window, double xpos, double ypos);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWcursorenterfun(GLFWwindow window, [MarshalAs(UnmanagedType.I4)] bool entered);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWscrollfun(GLFWwindow window, double xoffset, double yoffset);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWjoystickfun(int jid, int @event);

    public delegate void GLFWdropfun(GLFWwindow window, int path_count, IReadOnlyList<string?> paths);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__init.html#ga317aac130a235ab08c6db0834907d85e"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    [return: MarshalAs(UnmanagedType.I4)]
    public static partial bool glfwInit();

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__init.html#gaaae48c0a18607ea4a4ba951d939f0901"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwTerminate();

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__init.html#ga110fd1d3f0412822b4f1908c026f724a"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwInitHint(int hint, int value);

    // @TODO glfwInitVulkanLoader

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__init.html#ga9f8ffaacf3c269cc48eafbf8b9b71197"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwGetVersion(out int major, out int minor, out int rev);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__init.html#ga026abd003c8e6501981ab1662062f1c0"/>
    /// </summary>
    public static string glfwGetVersionString() {
        unsafe {
            return Helpers.ReturnNonOwningString(&Unsafe.glfwGetVersionString)!;
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__init.html#ga944986b4ec0b928d488141f92982aa18"/>
    /// </summary>
    public static int glfwGetError(out string? description) {
        unsafe {
            int retVal = Unsafe.glfwGetError(out byte* descriptionNative);
            description = Utf8StringMarshaller.ConvertToManaged(descriptionNative);
            return retVal;
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__init.html#gaff45816610d53f0b83656092a4034f40"/>
    /// </summary>
    public static GLFWerrorfun? glfwSetErrorCallback(GLFWerrorfun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetErrorCallback_handle, &Unsafe.glfwSetErrorCallback_erased, callback);
        }
    }

    internal static GLFWerrorfun? glfwSetErrorCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__init.html#ga6d6a983d38bd4e8fd786d7a9061d399e"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial int glfwGetPlatform();

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__init.html#ga8785d2b6b36632368d803e78079d38ed"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    [return: MarshalAs(UnmanagedType.I4)]
    public static partial bool glfwPlatformSupported(int platform);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#ga70b1156d5d24e9928f145d6c864369d2"/>
    /// </summary>
    public static ReadOnlySpan<GLFWmonitor> glfwGetMonitors(out int count) {
        unsafe {
            GLFWmonitor* retVal_native = Unsafe.glfwGetMonitors(out count);
            return new ReadOnlySpan<GLFWmonitor>(retVal_native, count);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#gac3adb24947eb709e1874028272e5dfc5"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial GLFWmonitor glfwGetPrimaryMonitor();

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#ga102f54e7acc9149edbcf0997152df8c9"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwGetMonitorPos(GLFWmonitor monitor, out int xpos, out int ypos);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#ga7387a3bdb64bfe8ebf2b9e54f5b6c9d0"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static 
    partial void glfwGetMonitorWorkarea(GLFWmonitor monitor, out int xpos, out int ypos, out int width, out int height);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#ga7d8bffc6c55539286a6bd20d32a8d7ea"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwGetMonitorPhysicalSize(GLFWmonitor monitor, out int widthMM, out int heightMM);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#gad3152e84465fa620b601265ebfcdb21b"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwGetMonitorContentScale(GLFWmonitor monitor, out float xscale, out float yscale);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#ga7af83e13489d90379588fb331b9e4b68"/>
    /// </summary>
    public static string? glfwGetMonitorName(GLFWmonitor monitor) {
        unsafe {
            return Helpers.ReturnNonOwningString(&Unsafe.glfwGetMonitorName, monitor);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#ga702750e24313a686d3637297b6e85fda"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetMonitorUserPointer(GLFWmonitor monitor, nint pointer);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#ga1adbfbfb8cd58b23cfee82e574fbbdc5"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial nint glfwGetMonitorUserPointer(GLFWmonitor monitor);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#gab39df645587c8518192aa746c2fb06c3"/>
    /// </summary>
    public static GLFWmonitorfun? glfwSetMonitorCallback(GLFWmonitorfun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetMonitorCallback_handle, &Unsafe.glfwSetMonitorCallback_erased, callback);
        }
    }

    internal static GLFWmonitorfun? glfwSetMonitorCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#gad2e24d2843cb7d6c26202cddd530fc1b"/>
    /// </summary>
    public static ReadOnlySpan<GLFWvidmode> glfwGetVideoModes(GLFWmonitor monitor) {
        unsafe {
            GLFWvidmode* retValPtr = Unsafe.glfwGetVideoModes(monitor, out int count);
            return new ReadOnlySpan<GLFWvidmode>(retValPtr, count);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#gaba376fa7e76634b4788bddc505d6c9d5"/>
    /// </summary>
    public static ref readonly GLFWvidmode glfwGetVideoMode(GLFWmonitor monitor) {
        unsafe {
            GLFWvidmode* retValPtr = Unsafe.glfwGetVideoMode(monitor);
            return ref System.Runtime.CompilerServices.Unsafe.AsRef<GLFWvidmode>(retValPtr);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#ga6ac582625c990220785ddd34efa3169a"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetGamma(GLFWmonitor monitor, float gamma);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#ga76ba90debcf0062b5c4b73052b24f96f"/>
    /// </summary>
    public static ref readonly GLFWgammaramp glfwGetGammaRamp(GLFWmonitor monitor) {
        unsafe {
            GLFWgammaramp* retValPtr = Unsafe.glfwGetGammaRamp(monitor);
            return ref System.Runtime.CompilerServices.Unsafe.AsRef<GLFWgammaramp>(retValPtr);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html#ga583f0ffd0d29613d8cd172b996bbf0dd"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetGammaRamp(GLFWmonitor monitor, in GLFWgammaramp ramp);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gaa77c4898dfb83344a6b4f76aa16b9a4a"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwDefaultWindowHints();

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga7d9c8c62384b1e2821c4dc48952d2033"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwWindowHint(int hint, int value);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga7d9c8c62384b1e2821c4dc48952d2033"/>
    /// </summary>
    public static void glfwWindowHint(int hint, bool value)
        => glfwWindowHint(hint, value ? 1 : 0);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga8cb2782861c9d997bcf2dea97f363e5f"/>
    /// </summary>
    [LibraryImport(LibraryName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwWindowHintString(int hint, string value);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga3555a418df92ad53f917597fe2f64aeb"/>
    /// </summary>
    public static GLFWwindow glfwCreateWindow(int width, int height, ReadOnlySpan<byte> title)
        => glfwCreateWindow(width, height, title, GLFWmonitor.Zero, GLFWwindow.Zero);
    
    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga3555a418df92ad53f917597fe2f64aeb"/>
    /// </summary>
    public static GLFWwindow glfwCreateWindow(int width, int height, ReadOnlySpan<byte> title, GLFWmonitor monitor)
        => glfwCreateWindow(width, height, title, monitor, GLFWwindow.Zero);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga3555a418df92ad53f917597fe2f64aeb"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial GLFWwindow glfwCreateWindow(int width, int height, ReadOnlySpan<byte> title, GLFWmonitor monitor, GLFWwindow share);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga3555a418df92ad53f917597fe2f64aeb"/>
    /// </summary>
    public static GLFWwindow glfwCreateWindow(int width, int height, string title)
        => glfwCreateWindow(width, height, title, GLFWmonitor.Zero, GLFWwindow.Zero);
    
    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga3555a418df92ad53f917597fe2f64aeb"/>
    /// </summary>
    public static GLFWwindow glfwCreateWindow(int width, int height, string title, GLFWmonitor monitor)
        => glfwCreateWindow(width, height, title, monitor, GLFWwindow.Zero);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga3555a418df92ad53f917597fe2f64aeb"/>
    /// </summary>
    [LibraryImport(LibraryName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial GLFWwindow glfwCreateWindow(int width, int height, string title, GLFWmonitor monitor, GLFWwindow share);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gacdf43e51376051d2c091662e9fe3d7b2"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwDestroyWindow(GLFWwindow window);
    
    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga24e02fbfefbb81fc45320989f8140ab5"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    [return: MarshalAs(UnmanagedType.I4)]
    public static partial bool glfwWindowShouldClose(GLFWwindow window);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga49c449dde2a6f87d996f4daaa09d6708"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetWindowShouldClose(GLFWwindow window, [MarshalAs(UnmanagedType.I4)] bool value);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gac6151765c54b789c4fe66c6bc6215953"/>
    /// </summary>
    public static string? glfwGetWindowTitle(GLFWwindow window) {
        unsafe {
            return Helpers.ReturnNonOwningString(&Unsafe.glfwGetWindowTitle, window);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga5d877f09e968cef7a360b513306f17ff"/>
    /// </summary>
    [LibraryImport(LibraryName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetWindowTitle(GLFWwindow window, string title);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gadd7ccd39fe7a7d1f0904666ae5932dc5"/>
    /// </summary>
    public static void glfwSetWindowIcon(GLFWwindow window, ReadOnlySpan<GLFWimage> images)
        => glfwSetWindowIcon(window, images.Length, images);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gadd7ccd39fe7a7d1f0904666ae5932dc5"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetWindowIcon(GLFWwindow window, int count, ReadOnlySpan<GLFWimage> images);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga73cb526c000876fd8ddf571570fdb634"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwGetWindowPos(GLFWwindow window, out int xpos, out int ypos);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga1abb6d690e8c88e0c8cd1751356dbca8"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetWindowPos(GLFWwindow window, int xpos, int ypos);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gaeea7cbc03373a41fb51cfbf9f2a5d4c6"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwGetWindowSize(GLFWwindow window, out int width, out int height);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gac314fa6cec7d2d307be9963e2709cc90"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetWindowSizeLimits(GLFWwindow window, int minwidth, int minheight, int maxwidth, int maxheight);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga72ac8cb1ee2e312a878b55153d81b937"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetWindowAspectRatio(GLFWwindow window, int numer, int denom);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga371911f12c74c504dd8d47d832d095cb"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetWindowSize(GLFWwindow window, int width, int height);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga0e2637a4161afb283f5300c7f94785c9"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwGetFramebufferSize(GLFWwindow window, out int width, out int height);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga1a9fd382058c53101b21cf211898f1f1"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwGetWindowFrameSize(GLFWwindow window, out int left, out int top, out int right, out int bottom);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gaf5d31de9c19c4f994facea64d2b3106c"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwGetWindowContentScale(GLFWwindow window, out float xscale, out float yscale);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gad09f0bd7a6307c4533b7061828480a84"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial float glfwGetWindowOpacity(GLFWwindow window);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gac31caeb3d1088831b13d2c8a156802e9"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetWindowOpacity(GLFWwindow window, float opacity);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga1bb559c0ebaad63c5c05ad2a066779c4"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwIconifyWindow(GLFWwindow window);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga52527a5904b47d802b6b4bb519cdebc7"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwRestoreWindow(GLFWwindow window);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga3f541387449d911274324ae7f17ec56b"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwMaximizeWindow(GLFWwindow window);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga61be47917b72536a148300f46494fc66"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwShowWindow(GLFWwindow window);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga49401f82a1ba5f15db5590728314d47c"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwHideWindow(GLFWwindow window);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga873780357abd3f3a081d71a40aae45a1"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwFocusWindow(GLFWwindow window);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga2f8d59323fc4692c1d54ba08c863a703"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwRequestWindowAttention(GLFWwindow window);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga4d766499ac02c60f02221a9dfab87299"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial GLFWmonitor glfwGetWindowMonitor(GLFWwindow window);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga81c76c418af80a1cce7055bccb0ae0a7"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetWindowMonitor(GLFWwindow window, GLFWmonitor monitor, int xpos, int ypos, int width, int height, int refreshRate);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gacccb29947ea4b16860ebef42c2cb9337"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial int glfwGetWindowAttrib(GLFWwindow window, int attrib);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gace2afda29b4116ec012e410a6819033e"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetWindowAttrib(GLFWwindow window, int attrib, [MarshalAs(UnmanagedType.I4)] bool value);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga3d2fc6026e690ab31a13f78bc9fd3651"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetWindowUserPointer(GLFWwindow window, nint pointer);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gae77a4add0d2023ca21ff1443ced01653"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial nint glfwGetWindowUserPointer(GLFWwindow window);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga08bdfbba88934f9c4f92fd757979ac74"/>
    /// </summary>
    public static GLFWwindowposfun? glfwSetWindowPosCallback(GLFWwindow window, GLFWwindowposfun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetWindowPosCallback_handle, &Unsafe.glfwSetWindowPosCallback_erased, window, callback);
        }
    }

    internal static GLFWwindowposfun? glfwSetWindowPosCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gad91b8b047a0c4c6033c38853864c34f8"/>
    /// </summary>
    public static GLFWwindowsizefun? glfwSetWindowSizeCallback(GLFWwindow window, GLFWwindowsizefun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetWindowSizeCallback_handle, &Unsafe.glfwSetWindowSizeCallback_erased, window, callback);
        }
    }

    internal static GLFWwindowsizefun? glfwSetWindowSizeCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gada646d775a7776a95ac000cfc1885331"/>
    /// </summary>
    public static GLFWwindowclosefun? glfwSetWindowCloseCallback(GLFWwindow window, GLFWwindowclosefun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetWindowCloseCallback_handle, &Unsafe.glfwSetWindowCloseCallback_erased, window, callback);
        }
    }

    internal static GLFWwindowclosefun? glfwSetWindowCloseCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga1c5c7eb889c33c7f4d10dd35b327654e"/>
    /// </summary>
    public static GLFWwindowrefreshfun? glfwSetWindowRefreshCallback(GLFWwindow window, GLFWwindowrefreshfun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetWindowRefreshCallback_handle, &Unsafe.glfwSetWindowRefreshCallback_erased, window, callback);
        }
    }

    internal static GLFWwindowrefreshfun? glfwSetWindowRefreshCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gac2d83c4a10f071baf841f6730528e66c"/>
    /// </summary>
    public static GLFWwindowfocusfun? glfwSetWindowFocusCallback(GLFWwindow window, GLFWwindowfocusfun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetWindowFocusCallback_handle, &Unsafe.glfwSetWindowFocusCallback_erased, window, callback);
        }
    }

    internal static GLFWwindowfocusfun? glfwSetWindowFocusCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gac793e9efd255567b5fb8b445052cfd3e"/>
    /// </summary>
    public static GLFWwindowiconifyfun? glfwSetWindowIconifyCallback(GLFWwindow window, GLFWwindowiconifyfun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetWindowIconifyCallback_handle, &Unsafe.glfwSetWindowIconifyCallback_erased, window, callback);
        }
    }

    internal static GLFWwindowiconifyfun? glfwSetWindowIconifyCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gacbe64c339fbd94885e62145563b6dc93"/>
    /// </summary>
    public static GLFWwindowmaximizefun? glfwSetWindowMaximizeCallback(GLFWwindow window, GLFWwindowmaximizefun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetWindowMaximizeCallback_handle, &Unsafe.glfwSetWindowMaximizeCallback_erased, window, callback);
        }
    }

    internal static GLFWwindowmaximizefun? glfwSetWindowMaximizeCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gab3fb7c3366577daef18c0023e2a8591f"/>
    /// </summary>
    public static GLFWframebuffersizefun? glfwSetFramebufferSizeCallback(GLFWwindow window, GLFWframebuffersizefun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetFramebufferSizeCallback_handle, &Unsafe.glfwSetFramebufferSizeCallback_erased, window, callback);
        }
    }

    internal static GLFWframebuffersizefun? glfwSetFramebufferSizeCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gaf2832ebb5aa6c252a2d261de002c92d6"/>
    /// </summary>
    public static GLFWwindowcontentscalefun? glfwSetWindowContentScaleCallback(GLFWwindow window, GLFWwindowcontentscalefun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetWindowContentScaleCallback_handle, &Unsafe.glfwSetWindowContentScaleCallback_erased, window, callback);
        }
    }

    internal static GLFWwindowcontentscalefun? glfwSetWindowContentScaleCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga37bd57223967b4211d60ca1a0bf3c832"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwPollEvents();

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga554e37d781f0a997656c26b2c56c835e"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwWaitEvents();

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga605a178db92f1a7f1a925563ef3ea2cf"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwWaitEventsTimeout(double timeout);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#gab5997a25187e9fd5c6f2ecbbc8dfd7e9"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwPostEmptyEvent();

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gaf5b859dbe19bdf434e42695ea45cc5f4"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial int glfwGetInputMode(GLFWwindow window, int mode);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gaa92336e173da9c8834558b54ee80563b"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetInputMode(GLFWwindow window, int mode, [MarshalAs(UnmanagedType.I4)] bool value);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gae4ee0dbd0d256183e1ea4026d897e1c2"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    [return: MarshalAs(UnmanagedType.I4)]
    public static partial bool glfwRawMouseMotionSupported();

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gaeaed62e69c3bd62b7ff8f7b19913ce4f"/>
    /// </summary>
    public static string? glfwGetKeyName(int key, int scancode) {
        unsafe {
            return Helpers.ReturnNonOwningString(&Unsafe.glfwGetKeyName, key, scancode);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga67ddd1b7dcbbaff03e4a76c0ea67103a"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial int glfwGetKeyScancode(int key);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gadd341da06bc8d418b4dc3a3518af9ad2"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial int glfwGetKey(GLFWwindow window, int key);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gac1473feacb5996c01a7a5a33b5066704"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial int glfwGetMouseButton(GLFWwindow window, int button);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga01d37b6c40133676b9cea60ca1d7c0cc"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwGetCursorPos(GLFWwindow window, out double xpos, out double ypos);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga04b03af936d906ca123c8f4ee08b39e7"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetCursorPos(GLFWwindow window, double xpos, double ypos);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga556f604f73af156c0db0e97c081373c3"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial GLFWcursor glfwCreateCursor(GLFWimage image, int xhot, int yhot);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gaf2fb2eb2c9dd842d1cef8a34e3c6403e"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial GLFWcursor glfwCreateStandardCursor(int shape);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga81b952cd1764274d0db7fb3c5a79ba6a"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwDestroyCursor(GLFWcursor cursor);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gad3b4f38c8d5dae036bc8fa959e18343e"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetCursor(GLFWwindow window, GLFWcursor cursor);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga1caf18159767e761185e49a3be019f8d"/>
    /// </summary>
    public static GLFWkeyfun? glfwSetKeyCallback(GLFWwindow window, GLFWkeyfun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetKeyCallback_handle, &Unsafe.glfwSetKeyCallback_erased, window, callback);
        }
    }

    internal static GLFWkeyfun? glfwSetKeyCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gab25c4a220fd8f5717718dbc487828996"/>
    /// </summary>
    public static GLFWcharfun? glfwSetCharCallback(GLFWwindow window, GLFWcharfun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetCharCallback_handle, &Unsafe.glfwSetCharCallback_erased, window, callback);
        }
    }

    internal static GLFWcharfun? glfwSetCharCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga0b7f4ad13c2b17435ff13b6dcfb4e43c"/>
    /// </summary>
    public static GLFWcharmodsfun? glfwSetCharModsCallback(GLFWwindow window, GLFWcharmodsfun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetCharModsCallback_handle, &Unsafe.glfwSetCharModsCallback_erased, window, callback);
        }
    }

    internal static GLFWcharmodsfun? glfwSetCharModsCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga6ab84420974d812bee700e45284a723c"/>
    /// </summary>
    public static GLFWmousebuttonfun? glfwSetMouseButtonCallback(GLFWwindow window, GLFWmousebuttonfun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetMouseButtonCallback_handle, &Unsafe.glfwSetMouseButtonCallback_erased, window, callback);
        }
    }

    internal static GLFWmousebuttonfun? glfwSetMouseButtonCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gac1f879ab7435d54d4d79bb469fe225d7"/>
    /// </summary>
    public static GLFWcursorposfun? glfwSetCursorPosCallback(GLFWwindow window, GLFWcursorposfun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetCursorPosCallback_handle, &Unsafe.glfwSetCursorPosCallback_erased, window, callback);
        }
    }

    internal static GLFWcursorposfun? glfwSetCursorPosCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gad27f8ad0142c038a281466c0966817d8"/>
    /// </summary>
    public static GLFWcursorenterfun? glfwSetCursorEnterCallback(GLFWwindow window, GLFWcursorenterfun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetCursorEnterCallback_handle, &Unsafe.glfwSetCursorEnterCallback_erased, window, callback);
        }
    }

    internal static GLFWcursorenterfun? glfwSetCursorEnterCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga571e45a030ae4061f746ed56cb76aede"/>
    /// </summary>
    public static GLFWscrollfun? glfwSetScrollCallback(GLFWwindow window, GLFWscrollfun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetScrollCallback_handle, &Unsafe.glfwSetScrollCallback_erased, window, callback);
        }
    }

    internal static GLFWscrollfun? glfwSetScrollCallback_handle;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void GLFWdropfun_native(GLFWwindow window, int path_count, byte** paths);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gab773f0ee0a07cff77a210cea40bc1f6b"/>
    /// </summary>
    public static GLFWdropfun? glfwSetDropCallback(GLFWwindow window, GLFWdropfun? safeCallback) {
        unsafe {
            GLFWdropfun_native? newCallback = default;
            GLFWdropfun? previousSafeCallback = default;

            if (safeCallback is not null) {
                newCallback = (GLFWwindow window, int path_count, byte** paths) => {
                    var list = new List<string?>();
                    foreach (byte* path in new ReadOnlySpan<nint>(paths, path_count)) {
                        list.Add(Utf8StringMarshaller.ConvertToManaged(path));
                    }

                    safeCallback(window, path_count, list);
                };
            }

            GLFWdropfun_native? previousCallback = Helpers.SetCallback(ref glfwSetDropCallback_handle, &Unsafe.glfwSetDropCallback_erased, window, newCallback);
            if (previousCallback is not null) {
                previousSafeCallback = (GLFWwindow window, int paths_count, IReadOnlyList<string?> pathsSafe) => {
                    Span<byte> unmanagedStringBuffer = stackalloc byte[Utf8StringMarshaller.ManagedToUnmanagedIn.BufferSize];

                    Span<nint> buffer = default;
                    if (pathsSafe.Count >= 0 && pathsSafe.Count <= 2 << 6) {
#pragma warning disable CS9081 // A result of a stackalloc expression of this type in this context may be exposed outside of the containing method
                        buffer = stackalloc nint[pathsSafe.Count];
#pragma warning restore CS9081 // A result of a stackalloc expression of this type in this context may be exposed outside of the containing method
                    }
                    else {
                        buffer = new nint[pathsSafe.Count];
                    }

                    for (int i = 0; i < pathsSafe.Count; i++) {
                        string? pathSafe = pathsSafe[i];
                        byte* path = default;
                        if (pathSafe is string s) {
                            path = Utf8StringMarshaller.ConvertToUnmanaged(s);
                        }

                        buffer[i] = (nint)path;
                    }

                    fixed (nint* bufferPtr = buffer) {
                        previousCallback(window, paths_count, (byte**) bufferPtr);
                    }
                };
            }

            return previousSafeCallback;
        }
    }

    internal static GLFWdropfun_native? glfwSetDropCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gaed0966cee139d815317f9ffcba64c9f1"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    [return: MarshalAs(UnmanagedType.I4)]
    public static partial bool glfwJoystickPresent(int jid);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gaeb1c0191d3140a233a682987c61eb408"/>
    /// </summary>
    public static ReadOnlySpan<float> glfwGetJoystickAxes(int jid, out int count) {
        unsafe {
            return Helpers.JoystickReturnReadOnlySpan<float>(&Unsafe.glfwGetJoystickAxes, jid, out count);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gaeb1c0191d3140a233a682987c61eb408"/>
    /// </summary>
    public static ReadOnlySpan<float> glfwGetJoystickAxes(int jid) {
        unsafe {
            return Helpers.JoystickReturnReadOnlySpan<float>(&Unsafe.glfwGetJoystickAxes, jid, out _);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga5ffe34739d3dc97efe432ed2d81d9938"/>
    /// </summary>
    public static ReadOnlySpan<byte> glfwGetJoystickButtons(int jid, out int count) {
        unsafe {
            return Helpers.JoystickReturnReadOnlySpan<byte>(&Unsafe.glfwGetJoystickButtons, jid, out count);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga5ffe34739d3dc97efe432ed2d81d9938"/>
    /// </summary>
    public static ReadOnlySpan<byte> glfwGetJoystickButtons(int jid) {
        unsafe {
            return Helpers.JoystickReturnReadOnlySpan<byte>(&Unsafe.glfwGetJoystickButtons, jid, out _);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga06e660841b3e79c54da4f54a932c5a2c"/>
    /// </summary>
    public static ReadOnlySpan<byte> glfwGetJoystickHats(int jid, out int count) {
        unsafe {
            return Helpers.JoystickReturnReadOnlySpan<byte>(&Unsafe.glfwGetJoystickHats, jid, out count);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga06e660841b3e79c54da4f54a932c5a2c"/>
    /// </summary>
    public static ReadOnlySpan<byte> glfwGetJoystickHats(int jid) {
        unsafe {
            return Helpers.JoystickReturnReadOnlySpan<byte>(&Unsafe.glfwGetJoystickHats, jid, out _);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gac6a8e769e18e0bcfa9097793fc2c3978"/>
    /// </summary>
    public static string? glfwGetJoystickName(int jid) {
        unsafe {
            return Helpers.ReturnNonOwningString(&Unsafe.glfwGetJoystickName, jid);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga6659411aec3c7fcef27780e2cb2d9600"/>
    /// </summary>
    public static Guid? glfwGetJoystickGUID(int jid) {
        unsafe {
            string? str = Helpers.ReturnNonOwningString(&Unsafe.glfwGetJoystickGUID, jid);
            if (Guid.TryParse(str, out Guid guid)) {
                return guid;
            }

            return null;
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga6b2f72d64d636b48a727b437cbb7489e"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetJoystickUserPointer(int jid, nint pointer);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga18cefd7265d1fa04f3fd38a6746db5f3"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial nint glfwGetJoystickUserPointer(int jid);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gad0f676860f329d80f7e47e9f06a96f00"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    [return: MarshalAs(UnmanagedType.I4)]
    public static partial bool glfwJoystickIsGamepad(int jid);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga2f60a0e5b7bd8d1b7344dc0a7cb32b4c"/>
    /// </summary>
    public static GLFWjoystickfun? glfwSetJoystickCallback(GLFWjoystickfun? callback) {
        unsafe {
            return Helpers.SetCallback(ref glfwSetJoystickCallback_handle, &Unsafe.glfwSetJoystickCallback_erased, callback);
        }
    }

    internal static GLFWjoystickfun? glfwSetJoystickCallback_handle;

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gaed5104612f2fa8e66aa6e846652ad00f"/>
    /// </summary>
    [LibraryImport(LibraryName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    [return: MarshalAs(UnmanagedType.I4)]
    public static partial bool glfwUpdateGamepadMappings(string @string);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga8aea73a1a25cc6c0486a617019f56728"/>
    /// </summary>
    public static string? glfwGetGamepadName(int jid) {
        unsafe {
            return Helpers.ReturnNonOwningString(&Unsafe.glfwGetGamepadName, jid);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gadccddea8bce6113fa459de379ddaf051"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    [return: MarshalAs(UnmanagedType.I4)]
    public static partial bool glfwGetGamepadState(int jid, out GLFWgamepadstate state);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gaba1f022c5eb07dfac421df34cdcd31dd"/>
    /// </summary>
    [LibraryImport(LibraryName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetClipboardString(GLFWwindow window, string @string);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga71a5b20808ea92193d65c21b82580355"/>
    /// </summary>
    public static string? glfwGetClipboardString(GLFWwindow window) {
        unsafe {
            return Helpers.ReturnNonOwningString(&Unsafe.glfwGetClipboardString, window);
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gaa6cf4e7a77158a3b8fd00328b1720a4a"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial double glfwGetTime();

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#gaf59589ef6e8b8c8b5ad184b25afd4dc0"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSetTime(double time);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga09b2bd37d328e0b9456c7ec575cc26aa"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial ulong glfwGetTimerValue();

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html#ga3289ee876572f6e91f06df3a24824443"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial ulong glfwGetTimerFrequency();

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__context.html#ga1c04dc242268f827290fe40aa1c91157"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwMakeContextCurrent(GLFWwindow window);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__context.html#gad94e80185397a6cf5fe2ab30567af71c"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial GLFWwindow glfwGetCurrentContext();

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html#ga15a5a1ee5b3c2ca6b15ca209a12efd14"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSwapBuffers(GLFWwindow window);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__context.html#ga6d4e0cdf151b5e579bd67f13202994ed"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial void glfwSwapInterval(int value);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__context.html#ga87425065c011cef1ebd6aac75e059dfa"/>
    /// </summary>
    [LibraryImport(LibraryName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    [return: MarshalAs(UnmanagedType.I4)]
    public static partial bool glfwExtensionSupported(string extension);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__context.html#ga87425065c011cef1ebd6aac75e059dfa"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    [return: MarshalAs(UnmanagedType.I4)]
    public static partial bool glfwExtensionSupported(ReadOnlySpan<byte> extension);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__context.html#ga35f1837e6f666781842483937612f163"/>
    /// </summary>
    [LibraryImport(LibraryName)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial nint glfwGetProcAddress(ReadOnlySpan<byte> name);

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__context.html#ga35f1837e6f666781842483937612f163"/>
    /// </summary>
    [LibraryImport(LibraryName, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = new Type[] {typeof(LibraryCallConv)})]
    public static partial nint glfwGetProcAddress(string name);

    // @TODO glfwVulkanSupported

    // @TODO glfwGetRequiredInstanceExtensions

    // @TODO glfwGetInstanceProcAddress

    // @TODO glfwGetPhysicalDevicePresentationSupport

    // @TODO glfwCreateWindowSurface
}
