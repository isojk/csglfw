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
using System.Runtime.InteropServices;

namespace Isojk.Csglfw;

using unsafe GLFWallocatefun_ptr = delegate* unmanaged[Cdecl]</*size_t*/ nuint, nint, nint>;
using unsafe GLFWreallocatefun_ptr = delegate* unmanaged[Cdecl]<nint, /*size_t*/ nuint, nint, nint>;
using unsafe GLFWdeallocatefun_ptr = delegate* unmanaged[Cdecl]<nint, nint, void>;

public static partial class API {

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__monitor.html"/>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct GLFWmonitor : IEquatable<GLFWmonitor>, IComparable, IComparable<GLFWmonitor>, ISpanFormattable, IUtf8SpanFormattable {
        public static readonly GLFWmonitor Zero = new(nint.Zero);

        private readonly nint Ptr;
        public bool IsInitialized => Ptr != default;

        private GLFWmonitor(nint ptr) {
            Ptr = ptr;
        }

        public override string ToString() => Ptr.ToString();
        public string ToString(string? format, IFormatProvider? formatProvider)
            => Ptr.ToString(format, formatProvider);

        public static implicit operator bool(GLFWmonitor handle) => handle.IsInitialized;

        public override bool Equals(object? obj) => obj is GLFWmonitor && Equals((GLFWmonitor)obj);
        public bool Equals(GLFWmonitor other) => Ptr.Equals(other.Ptr);
        public static bool operator ==(GLFWmonitor left, GLFWmonitor right) => left.Equals(right);
        public static bool operator !=(GLFWmonitor left, GLFWmonitor right) => !(left == right);
        public override int GetHashCode() => Ptr.GetHashCode();

        public int CompareTo(object? obj) => Ptr.CompareTo(obj);
        public int CompareTo(GLFWmonitor other) => Ptr.CompareTo(other.Ptr);

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
            => Ptr.TryFormat(destination, out charsWritten, format, provider);

        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
            => Ptr.TryFormat(utf8Destination, out bytesWritten, format, provider);
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__window.html"/>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct GLFWwindow : IEquatable<GLFWwindow>, IComparable, IComparable<GLFWwindow>, ISpanFormattable, IUtf8SpanFormattable {
        public static readonly GLFWwindow Zero = new(nint.Zero);

        private readonly nint Ptr;
        public bool IsInitialized => Ptr != default;

        private GLFWwindow(nint ptr) {
            Ptr = ptr;
        }

        public override string ToString() => Ptr.ToString();
        public string ToString(string? format, IFormatProvider? formatProvider)
            => Ptr.ToString(format, formatProvider);

        public static implicit operator bool(GLFWwindow handle) => handle.IsInitialized;

        public override bool Equals(object? obj) => obj is GLFWwindow && Equals((GLFWwindow)obj);
        public bool Equals(GLFWwindow other) => Ptr.Equals(other.Ptr);
        public static bool operator ==(GLFWwindow left, GLFWwindow right) => left.Equals(right);
        public static bool operator !=(GLFWwindow left, GLFWwindow right) => !(left == right);
        public override int GetHashCode() => Ptr.GetHashCode();

        public int CompareTo(object? obj) => Ptr.CompareTo(obj);
        public int CompareTo(GLFWwindow other) => Ptr.CompareTo(other.Ptr);

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
            => Ptr.TryFormat(destination, out charsWritten, format, provider);

        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
            => Ptr.TryFormat(utf8Destination, out bytesWritten, format, provider);
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/group__input.html"/>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct GLFWcursor : IEquatable<GLFWcursor>, IComparable, IComparable<GLFWcursor>, ISpanFormattable, IUtf8SpanFormattable {
        public static readonly GLFWcursor Zero = new(nint.Zero);

        private readonly nint Ptr;
        public bool IsInitialized => Ptr != default;

        private GLFWcursor(nint ptr) {
            Ptr = ptr;
        }

        public override string ToString() => Ptr.ToString();
        public string ToString(string? format, IFormatProvider? formatProvider)
            => Ptr.ToString(format, formatProvider);

        public static implicit operator bool(GLFWcursor handle) => handle.IsInitialized;

        public override bool Equals(object? obj) => obj is GLFWcursor && Equals((GLFWcursor)obj);
        public bool Equals(GLFWcursor other) => Ptr.Equals(other.Ptr);
        public static bool operator ==(GLFWcursor left, GLFWcursor right) => left.Equals(right);
        public static bool operator !=(GLFWcursor left, GLFWcursor right) => !(left == right);
        public override int GetHashCode() => Ptr.GetHashCode();

        public int CompareTo(object? obj) => Ptr.CompareTo(obj);
        public int CompareTo(GLFWcursor other) => Ptr.CompareTo(other.Ptr);

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
            => Ptr.TryFormat(destination, out charsWritten, format, provider);

        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
            => Ptr.TryFormat(utf8Destination, out bytesWritten, format, provider);
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/struct_g_l_f_wvidmode.html"/>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct GLFWvidmode {
        public readonly int width;
        public readonly int height;
        public readonly int redBits;
        public readonly int greenBits;
        public readonly int blueBits;
        public readonly int refreshRate;
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/struct_g_l_f_wgammaramp.html"/>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct GLFWgammaramp {
        public readonly unsafe ushort* red_internal;
        public readonly unsafe ushort* green_internal;
        public readonly unsafe ushort* blue_internal;
        public readonly int size_internal;

        public ReadOnlySpan<ushort> red {
            get {
                unsafe {
                    return new ReadOnlySpan<ushort>(red_internal, size_internal);
                }
            }
        }

        public ReadOnlySpan<ushort> green {
            get {
                unsafe {
                    return new ReadOnlySpan<ushort>(green_internal, size_internal);
                }
            }
        }

        public ReadOnlySpan<ushort> blue {
            get {
                unsafe {
                    return new ReadOnlySpan<ushort>(blue_internal, size_internal);
                }
            }
        }


        public unsafe GLFWgammaramp(int size, ushort* red, ushort* green, ushort* blue) {
            red_internal = red;
            green_internal = green;
            blue_internal = blue;
            size_internal = size;
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/structGLFWimage.html"/>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct GLFWimage {
        private const int PIXEL_WIDTH = 4;

        private readonly int width_internal;
        private readonly int height_internal;

        // The pixels are 32-bit, little-endian, non-premultiplied RGBA, i.e. eight
        // bits per channel with the red channel first.  They are arranged canonically
        // as packed sequential rows, starting from the top-left corner.
        private readonly unsafe byte* pixels_internal;

        public int width => width_internal;
        public int height => height_internal;
        public ReadOnlySpan<byte> pixels {
            get {
                unsafe {
                    return new(pixels_internal, width_internal * height_internal * PIXEL_WIDTH);
                }
            }
        }

        public unsafe GLFWimage(int width, int height, byte* pixels) {
            width_internal = width;
            height_internal = height;
            pixels_internal = pixels;
        }
    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/struct_g_l_f_wgamepadstate.html"/>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct GLFWgamepadstate {
        // @TODO 
        // Consider using InlineArrayAttribute instead of fixed buffers
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-12.0/inline-arrays

        private const int NUM_BUTTONS = 15;
        private const int NUM_AXES = 6;
        
        private readonly unsafe byte* buttons_internal;
        private readonly unsafe float* axes_internal;

        public ReadOnlySpan<byte> buttons {
            get {
                unsafe {
                    return new ReadOnlySpan<byte>(buttons_internal, NUM_BUTTONS);
                }
            }
        }

        public ReadOnlySpan<float> axes {
            get {
                unsafe {
                    return new ReadOnlySpan<float>(axes_internal, NUM_AXES);
                }
            }
        }

    }

    /// <summary>
    /// <see href="https://www.glfw.org/docs/3.4/struct_g_l_f_wallocator.html"/>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct GLFWallocator {
        public readonly unsafe GLFWallocatefun_ptr allocate;
        public readonly unsafe GLFWreallocatefun_ptr reallocate;
        public readonly unsafe GLFWdeallocatefun_ptr deallocate;
        public readonly nint user;

        public unsafe GLFWallocator(GLFWallocatefun_ptr allocate, GLFWreallocatefun_ptr reallocate, GLFWdeallocatefun_ptr deallocate, nint user) {
            this.allocate = allocate;
            this.reallocate = reallocate;
            this.deallocate = deallocate;
            this.user = user;
        }
    }
}
