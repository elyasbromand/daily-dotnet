In C#, a **finalizer** (historically called a **destructor**) is ==a special method used to perform necessary cleanup operations before a class instance is reclaimed by the Garbage Collector (GC)==. While the GC automatically manages memory for most objects, finalizers are intended for releasing **unmanaged resources**—such as file handles, network connections, or window handles—that the GC does not know how to handle on its own.

Key Characteristics

- **Syntax:** A finalizer is defined using a tilde (`~`) followed by the class name (e.g., `~MyClass()`). It cannot have access modifiers (like `public` or `private`) or parameters.
- **Automatic Execution:** You cannot call a finalizer explicitly. It is invoked automatically by the GC when it determines the object is no longer reachable.
- **Non-deterministic:** You cannot predict exactly _when_ a finalizer will run. It runs on a separate thread, which can impact performance and makes debugging difficult.
- **One per Class:** A class can only have one finalizer, and it cannot be inherited or overloaded. 

Finalizer vs. Dispose

While both are used for cleanup, they serve different roles in the .NET Dispose Pattern: 

- **IDisposable.Dispose():** Allows developers to **explicitly** and immediately release resources (deterministic cleanup). This is the preferred method for most scenarios.
- **Finalizer:** Acts as a **safety net** (backup). If a developer forgets to call `Dispose()`, the finalizer will eventually run to prevent permanent resource leaks. 

Why Avoid Them?

Microsoft recommends avoiding finalizers whenever possible for several reasons: 

- **Performance Impact:** Objects with finalizers require at least **two GC cycles** to be fully reclaimed, increasing memory pressure and overhead.
- **Complexity:** Finalizers cannot safely access other managed objects because those objects might have already been finalized.
- **Alternatives:** Most unmanaged handles can be wrapped in a [SafeHandle](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.safehandle?view=net-10.0), which provides built-in finalization logic and removes the need for custom finalizers in your own classes.