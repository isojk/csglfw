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

| System | Processor Architecture | Notes |
|---|---|---|
| Linux | ARM64 | **Untested**<br>Compiled using `arm-linux-gnueabihf-gcc-12` version 12.2.0 (Debian 12.2.0-14) on Debian 12 |
| Linux | x64 | Compiled using `x86_64-linux-gnu-gcc-12` version 12.2.0 (Debian 12.2.0-14) on Debian 12 |
| macOS | ARM64 | **Untested**<br>Taken from the official distribution |
| macOS | x64 | Taken from the official distribution |
| Windows | x64 | Taken from the official distribution |
<!-- | Windows | ARM64 | **Not tested** | -->

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
