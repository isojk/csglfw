using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Isojk.Csglfw;

internal static class Helpers {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static unsafe string? ReturnNonOwningString(delegate* <byte*> pinvoke) {
        byte* retValNative = pinvoke();
        return Utf8StringMarshaller.ConvertToManaged(retValNative);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static unsafe string? ReturnNonOwningString<T>(delegate* <T, byte*> pinvoke, T param1)
        where T: unmanaged
    {
        byte* retValNative = pinvoke(param1);
        return Utf8StringMarshaller.ConvertToManaged(retValNative);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static unsafe string? ReturnNonOwningString<T, U>(delegate* <T, U, byte*> pinvoke, T param1, U param2)
        where T: unmanaged
        where U: unmanaged
    {
        byte* retValNative = pinvoke(param1, param2);
        return Utf8StringMarshaller.ConvertToManaged(retValNative);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static unsafe ReadOnlySpan<T> JoystickReturnReadOnlySpan<T>(delegate* <int, out int, T*> pinvoke, int jid, out int count)
        where T: unmanaged
    {
        T* ptr = pinvoke(jid, out count);
        return new ReadOnlySpan<T>(ptr, count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static unsafe TCallback? SetCallback<TCallback>(ref TCallback? handle, delegate* <void*, void*> pinvoke, TCallback? newCallback)
        where TCallback: class
    {
        void* newCallbackPtr = default;
        TCallback? previousCallback = handle;
        
        if (newCallback is not null) {
            newCallbackPtr = (void*) Marshal.GetFunctionPointerForDelegate(newCallback);
        }

        handle = newCallback;
        
        {
            pinvoke(newCallbackPtr);
        }

        return previousCallback;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static unsafe TCallback? SetCallback<TCallback, TParam1>(ref TCallback? handle, delegate* <TParam1, void*, void*> pinvoke, TParam1 param1, TCallback? newCallback)
        where TCallback: class
        where TParam1: unmanaged
    {
        void* newCallbackPtr = default;
        TCallback? previousCallback = handle;
        
        if (newCallback is not null) {
            newCallbackPtr = (void*) Marshal.GetFunctionPointerForDelegate(newCallback);
        }

        handle = newCallback;
        
        {
            pinvoke(param1, newCallbackPtr);
        }

        return previousCallback;
    }
}