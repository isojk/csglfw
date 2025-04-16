Modern C# bindings for [GLFW](https://github.com/glfw/glfw).

## Example

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
