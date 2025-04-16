using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Isojk.Csglfw;

using ptr_t = nint;

public static partial class API {

    internal const string LibraryName = "__glfw3__";

    #if _GLFW_STATIC
        internal const bool IsStaticBuild = true;
    #else
        internal const bool IsStaticBuild = false;

        internal static Assembly GetAssembly() {
            return typeof(API).Assembly;
        }

        internal static E SumAllFlags<E>() where E: struct, Enum {
            int result = default;
            foreach (E value in Enum.GetValues<E>()) {
                result = result | (int)((object)value);
            }

            return (E)((object)result);
        }

        internal static bool ResolveDllImport(Assembly assembly, DllImportSearchPath? searchPath, out ptr_t handle, string rid, string filename) {
            handle = ptr_t.Zero;

            if (NativeLibrary.TryLoad(string.Format("runtimes/{0}/native/{1}", rid, filename), assembly, searchPath, out handle)) {
                return true;
            }

            if (NativeLibrary.TryLoad(filename, assembly, searchPath, out handle)) {
                return true;
            }

            return false;
        }

        internal static Dictionary<string, ptr_t> GLFWImportResolverCache = new Dictionary<string, ptr_t>(StringComparer.InvariantCultureIgnoreCase);

        internal static ptr_t GLFWImportResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath) {
            if (GLFWImportResolverCache.ContainsKey(libraryName)) {
                return GLFWImportResolverCache[libraryName];
            }

            ptr_t libHandle = ptr_t.Zero;
            bool success = false;
            string? filename = null;
            string? rid = null;

            searchPath = searchPath ?? SumAllFlags<DllImportSearchPath>();
            
            if (libraryName == LibraryName) {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                    rid = "win-x64";
                    filename = "glfw3.dll";
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
                    // @TODO
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD)) {
                    // @TODO
                }

                if (rid is not null && filename is not null) {
                    success = ResolveDllImport(assembly, searchPath, out libHandle, rid, filename);
                }
            }

            return libHandle;
        }

        internal static bool NativeDependenciesLoaded = false;
        static API() {
            if (NativeDependenciesLoaded) {
                return;
            }

            Assembly assembly = GetAssembly();

    #if _GLFW_AOT
            NativeLibrary.SetDllImportResolver(assembly, GLFWImportResolver);
            NativeDependenciesLoaded = true;
    #else
    #pragma warning disable IL2026
            // call NativeLibrary.SetDllImportResolver via reflection because it's not available in NET Standard
            // https://github.com/dotnet/standard/issues/1764

            if (Type.GetType("System.Runtime.InteropServices.NativeLibrary, System.Runtime.InteropServices") is not Type nativeLibrary) {
                return;
            }

            if (Type.GetType("System.Runtime.InteropServices.DllImportResolver, System.Runtime.InteropServices") is not Type dllImportResolver) {
                return;
            }

            var setDllImportResolver = nativeLibrary.GetMethod("SetDllImportResolver", [typeof(Assembly), dllImportResolver]);
            var dllImportResolverFunc = Delegate.CreateDelegate(dllImportResolver, null, GetMethodInfo(() => GLFWImportResolver(string.Empty, assembly, null)));
            setDllImportResolver?.Invoke(null, [assembly, dllImportResolverFunc]);
        
            NativeDependenciesLoaded = true;
    #pragma warning restore IL2026
    #endif
        }
    #endif

    #if !_GLFW_AOT
    #pragma warning disable IL2026
        internal static  MethodInfo GetMethodInfo(Expression<Action> expression) {
            if (expression.Body is MethodCallExpression mce) {
                return mce.Method;
            }

            throw new ArgumentException("Expression is not a method", nameof(expression));
        }
    #pragma warning restore IL2026
    #endif
}