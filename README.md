Low-level C# bindings for the [GLFW](https://github.com/glfw/glfw) library, version **3.4**.

This library utilizes modern language and compiler features (like [Function Pointers](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/function-pointers) or [P/Invoke source generator](https://learn.microsoft.com/en-us/dotnet/standard/native-interop/pinvoke-source-generation)) and therefore requires .NET 8 as the minimum target framework version.

All types, constants and methods have exactly the same name as their native counterparts.

## Static Linking

This library supports linking native dependencies statically into the target application, enabling to deploy single self-contained native executable.

This feature is available only when the target application is published using [Native AOT](https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/) deployment model in **Release** configuration.

To enable this feature for a project referencing this library as a `PackageReference` (e.g. installed with NuGet package manager), a property `GLFWEnableStaticBuild` with a value set to `true` must be defined in the project configuration of the target application:
```xml
<PropertyGroup>
    <GLFWEnableStaticBuild>true</GLFWEnableStaticBuild>
</PropertyGroup>
```

Everything else should be managed by the package automagically.

---

If this library is instead referenced as a `ProjectReference` (as a local project in Visual Studio) two additional steps must be taken:
1)  An `AdditionalProperties` attribute must be defined in the `ProjectReference` in order to propagate the `GLFWEnableStaticBuild` property, like this:
    ```xml
    <ProjectReference Include="..\..\csglfw\Isojk.Csglfw.csproj" AdditionalProperties="GLFWEnableStaticBuild=$(GLFWEnableStaticBuild)" />
    ```
2)  All required properties and targets from the `buildTransitive` directory must be imported at the end of the project configuration, like this:
    ```xml
    <Import Project="..\..\csglfw\buildTransitive\Isojk.Csglfw.props" />
    <Import Project="..\..\csglfw\buildTransitive\Isojk.Csglfw.targets" />
    ```

## Supported Platforms

<!--
win-arm64 static /MT:   Remove-Item -Recurse .\build; cmake -S . -B build -AARM64 -DBUILD_SHARED_LIBS=OFF -DCMAKE_MSVC_RUNTIME_LIBRARY=MultiThreaded
win-arm64 static /MD:   Remove-Item -Recurse .\build; cmake -S . -B build -AARM64 -DBUILD_SHARED_LIBS=OFF -DCMAKE_MSVC_RUNTIME_LIBRARY=MultiThreadedDLL
win-arm64 dynamic:      Remove-Item -Recurse .\build; cmake -S . -B build -AARM64 -DBUILD_SHARED_LIBS=ON

linux-arm64 gcc:        sudo apt-get install gcc-arm-linux-gnueabihf
                        sudo ln -fs /usr/bin/arm-linux-gnueabihf-gcc /etc/alternatives/cc

linux-arm64 static:     rm -rf ./build && cmake -S . -B build -DBUILD_SHARED_LIBS=OFF -DX11_X11_LIB=ignore_this
linux-arm64 dynamic:    rm -rf ./build && cmake -S . -B build -DBUILD_SHARED_LIBS=ON -DX11_X11_LIB=ignore_this
-->

| System | Processor Architecture | Notes |
|---|---|---|
| Linux | ARM64 | **Untested**<br>Compiled with `arm-linux-gnueabihf-gcc-12` version 12.2.0 (Debian 12.2.0-14) on Debian 12 |
| Linux | x64 | Compiled with `x86_64-linux-gnu-gcc-12` version 12.2.0 (Debian 12.2.0-14) on Debian 12 |
| macOS | ARM64 | **Untested**<br>Copied from the [official package with pre-compiled binaries](https://www.glfw.org/download) |
| macOS | x64 | Copied from the [official package with pre-compiled binaries](https://www.glfw.org/download) |
| Windows | ARM64 | **Untested**<br>Compiled with MSVC 19.43.34810.0<br>Windows SDK version 10.0.22621.0<br>MSVC v143 - VS2022 C++ ARM64/ARM64EC build tools (v14.43-17.13)<br>MSVC v143 - VS2022 C++ ARM64/ARM64EC Spectre-mitigated libs (v14.43-17.13) |
| Windows | x64 | Copied from the [official package with pre-compiled binaries](https://www.glfw.org/download) |

## WSL

If you encounter issues on Windows Subsystem for Linux, try to set the platform to X11 manually as a quick fix, like so:
```cs
glfwInitHint(GLFW_PLATFORM, GLFW_PLATFORM_X11);

if (!glfwInit()) {
    return;
}

// ...
```

## Basic Example

```cs
using static Isojk.Csglfw.API;

GLFWwindow window = default;

if (!glfwInit()) {
    return;
}

try {
    window = glfwCreateWindow(1280, 800, "Hello world");
    if (!window) {
        glfwTerminate();
        return;
    }

    glfwSetKeyCallback(window, (window, key, scancode, action, mods) => {
        if (key == GLFW_KEY_ESCAPE && action == GLFW_PRESS) {
            glfwSetWindowShouldClose(window, true);
        }
    });

    while (!glfwWindowShouldClose(window)) {
        glfwWaitEvents();
    }
}
finally {
    if (window) {
        glfwDestroyWindow(window);
    }

    glfwTerminate();
}
```

## An Example with Function Pointers

```cs
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using static Isojk.Csglfw.API;

GLFWwindow window = default;

if (!glfwInit()) {
    return;
}

try {
    window = glfwCreateWindow(1280, 800, "Hello world");
    if (!window) {
        glfwTerminate();
        return;
    }

    unsafe {
        Isojk.Csglfw.API.Unsafe.glfwSetKeyCallback(window, &KeyCallback);
    }

    while (!glfwWindowShouldClose(window)) {
        glfwWaitEvents();
    }
}
finally {
    if (window) {
        glfwDestroyWindow(window);
    }

    glfwTerminate();
}

[UnmanagedCallersOnly(CallConvs = new System.Type[] {typeof(CallConvCdecl)})]
static unsafe void KeyCallback(GLFWwindow window, int key, int scancode, int action, int mods) {
    if (key == GLFW_KEY_ESCAPE && action == GLFW_PRESS) {
        glfwSetWindowShouldClose(window, true);
    }
}
```


<!--
Purge NuGet cache: dotnet nuget locals --clear all
Pack: dotnet pack -c Release -p:Platform=x64 -o d:\nuget

-->
