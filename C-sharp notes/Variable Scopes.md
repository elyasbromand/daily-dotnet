Variable scope in **C#** is one of those topics that seems simple at first, but mastering it makes you a much better programmer. It affects **readability, memory usage, debugging, and architecture decisions**.

I'll walk you through it step-by-step:  
1️⃣ Basic scope  
2️⃣ Block scope  
3️⃣ Method scope  
4️⃣ Class/field scope  
5️⃣ Advanced scopes (loops, lambdas, closures, shadowing)  
6️⃣ Best practices  
7️⃣ Practice exercises

---

# 1. What Variable Scope Means

**Variable scope = the region of code where a variable is accessible.**

Think of it like **permission zones**.

Example:

int a = 10;  
  
{  
    int b = 20;  
}

- `a` → accessible everywhere in the method
    
- `b` → accessible **only inside the block**
    

If you try:

Console.WriteLine(b);

You will get:

The name 'b' does not exist in the current context

Because `b` **went out of scope**.

---

# 2. Block Scope

A **block** is anything inside `{ }`.

Example:

if (true)  
{  
    int x = 5;  
    Console.WriteLine(x);  
}  
  
Console.WriteLine(x); // ❌ error

`x` only exists **inside the if block**.

Blocks include:

- `if`
    
- `for`
    
- `while`
    
- `switch`
    
- `{}` standalone blocks
    

Example:

{  
    int temp = 100;  
}  
  
Console.WriteLine(temp); // ❌ not allowed

---

# 3. Method Scope

Variables declared inside a method exist **only inside that method**.

Example:

void PrintNumber()  
{  
    int number = 10;  
}  
  
void AnotherMethod()  
{  
    Console.WriteLine(number); // ❌ error  
}

Each method has **its own scope**.

Think of methods like **separate rooms**.

---

# 4. Loop Scope

Variables inside loops only live **inside the loop block**.

Example:

for (int i = 0; i < 5; i++)  
{  
    Console.WriteLine(i);  
}  
  
Console.WriteLine(i); // ❌ error

`i` disappears after the loop.

But:

int i;  
  
for (i = 0; i < 5; i++)  
{  
}  
  
Console.WriteLine(i); // ✅ allowed

Because `i` was declared **outside**.

---

# 5. Class Scope (Fields)

Variables declared inside a class but outside methods are **fields**.

Example:

class Car  
{  
    int speed = 100;  
  
    void PrintSpeed()  
    {  
        Console.WriteLine(speed);  
    }  
}

`speed` is accessible **in all methods of the class**.

Fields live as long as the **object exists**.

---

# 6. Local Variables vs Fields

Example:

class Test  
{  
    int number = 10; // field  
  
    void Method()  
    {  
        int number = 20; // local variable  
  
        Console.WriteLine(number);  
    }  
}

Output:

20

Because **local variables override fields inside methods**.

If you want the field:

Console.WriteLine(this.number);

---

# 7. Variable Shadowing

Shadowing happens when a **local variable hides another variable**.

Example:

int x = 5;  
  
void Test()  
{  
    int x = 10;  
    Console.WriteLine(x);  
}

Inside `Test()`, the outer `x` is **hidden**.

Shadowing can happen with:

- fields
    
- parameters
    
- local variables
    

Example with parameter:

int number = 5;  
  
void Print(int number)  
{  
    Console.WriteLine(number);  
}

The parameter shadows the field.

---

# 8. Scope in `switch`

In C#, `switch` cases share the same scope.

Example:

switch (value)  
{  
    case 1:  
        int x = 10;  
        break;  
  
    case 2:  
        int x = 20; // ❌ error  
        break;  
}

Solution:

switch (value)  
{  
    case 1:  
    {  
        int x = 10;  
        break;  
    }  
  
    case 2:  
    {  
        int x = 20;  
        break;  
    }  
}

Each case now has its own block.

---

# 9. Scope with `using`

Example:

using (var file = new StreamReader("file.txt"))  
{  
    string text = file.ReadToEnd();  
}

`file` only exists **inside the using block**.

After the block:

- the variable disappears
    
- the resource is disposed
    

---

# 10. Lambda Scope (Advanced)

Variables captured by lambdas are part of a **closure**.

Example:

int x = 10;  
  
Func<int> getNumber = () => x;  
  
Console.WriteLine(getNumber());

The lambda **captures `x` from outer scope**.

Even more interesting:

int x = 10;  
  
Func<int> f = () => x;  
  
x = 20;  
  
Console.WriteLine(f());

Output:

20

Because lambdas capture **the variable, not the value**.

---

# 11. Loop Closure Trap (Classic Bug)

Example:

var actions = new List<Action>();  
  
for (int i = 0; i < 3; i++)  
{  
    actions.Add(() => Console.WriteLine(i));  
}  
  
foreach (var action in actions)  
{  
    action();  
}

You might expect:

0  
1  
2

But output is:

3  
3  
3

Because the lambda captured the **same `i` variable**.

Fix:

for (int i = 0; i < 3; i++)  
{  
    int copy = i;  
    actions.Add(() => Console.WriteLine(copy));  
}

Now:

0  
1  
2

---

# 12. Static vs Instance Scope

Example:

class Counter  
{  
    static int total;  
    int instanceValue;  
}

- `instanceValue` → belongs to each object
    
- `total` → shared by the entire class
    

---

# 13. Scope and Lifetime

Scope and lifetime are related but **not identical**.

|Concept|Meaning|
|---|---|
|Scope|Where variable is accessible|
|Lifetime|How long it exists in memory|

Example:

void Test()  
{  
    int x = 10;  
}

`x`:

- scope → inside `Test`
    
- lifetime → until method finishes
    

---

# Best Practices (Important)

### 1️⃣ Keep variables in the smallest scope possible

Bad:

int result;  
  
if (condition)  
{  
    result = 10;  
}

Better:

if (condition)  
{  
    int result = 10;  
}

---

### 2️⃣ Avoid shadowing

Bad:

int number;  
  
void Set(int number)  
{  
}

Better:

void Set(int value)  
{  
}

---

### 3️⃣ Prefer local variables

Local variables are:

- safer
    
- easier to reason about
    
- thread safe
    

---

### 4️⃣ Avoid large method scopes

Instead of:

void Process()  
{  
    int a;  
    int b;  
    int c;  
}

Break methods down.

---

# Practice Exercises

Try solving these.

---

### Exercise 1

What happens?

int x = 5;  
  
{  
    int y = 10;  
}  
  
Console.WriteLine(y);

---

### Exercise 2

Output?

int x = 10;  
  
void Test()  
{  
    int x = 20;  
    Console.WriteLine(x);  
}

---

### Exercise 3

What prints?

var funcs = new List<Func<int>>();  
  
for (int i = 0; i < 3; i++)  
{  
    funcs.Add(() => i);  
}  
  
foreach (var f in funcs)  
{  
    Console.WriteLine(f());  
}

---

### Exercise 4

Fix the bug:

for (int i = 0; i < 5; i++)  
{  
    Task.Run(() => Console.WriteLine(i));  
}

---

💡 If you want, I can also show you the **10 most common scope mistakes even senior C# developers make** (especially with **LINQ, async, and closures**). Those are extremely useful if you're moving toward **advanced .NET development.**