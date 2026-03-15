



## What is Boilerplate code?

Boilerplate code refers to sections of code which are included in many places with little or no alteration.


## Unsigned and Signed datatypes

in C# unsigned variables are only holding positive numbers, like: `uint, ubyte`.
and signed can hold both, positive and negative numbers like: `int, byte`.



## Datatypes types based on how the occupy memory

Datatypes can be categorized into two parts based on how the occupy memory, ==Value type ==, and ==Reference type==

![[Screenshot 2026-03-10 215327.png]]

## Stack 🧱 (Fast, temporary memory)

The **stack** is a small, very fast memory area used for **short-lived data**.

### Characteristics

- Very **fast access**
    
- **Automatically managed**
    
- Stores **local variables and value types**
    
- Memory is **freed automatically when the method ends**
    

### Example

void MyMethod()  
{  
    int number = 10;  
}

What happens:

1. `MyMethod` starts
    
2. `number` is stored in the **stack**
    
3. When the method finishes → the stack memory is **automatically cleared**
    

Think of it like a **stack of plates**:

- You put a plate on top
    
- You remove the top one first
    

This is called **LIFO (Last In First Out)**.

---

## Heap 🧠 (Large dynamic memory)

The **heap** is used to store **objects and reference types**.

### Characteristics

- Much **larger memory**
    
- **Slower** than stack
    
- Managed by **Garbage Collector**
    
- Stores **objects and reference types**
    

### Example

class Person  
{  
    public string Name;  
}  
  
void MyMethod()
{  
    Person p = new Person();  
}

What happens:

1. `Person p` reference is stored in **stack**
    
2. `new Person()` object is stored in **heap**
    

Memory structure:

STACK                HEAP  
-----                -----  
p --------------->   Person object

## Reference Type

![[Screenshot 2026-03-10 220159.png]]


## Disabling and reenabling warnings 

`` #pragma warning disable CS0168
``int unusedVar;
``#pragma warning restore CS0168

that is who you disable and reenable a warning. 


## CultureInfo.InvarientCulture

Creates an independent culture object so that it convert different parsing data, time and date.  

## Casting

In C#, **casting**, the **`Convert` class**, and **parsing** are all methods for type conversion, but they differ in purpose, flexibility, error handling, and performance.

- **Casting** is for converting between _compatible_ types (e.g., numeric types, or within an inheritance hierarchy).
- **Parsing** is specifically for converting a `string` into a primitive data type (e.g., an `int` or `DateTime`).
- The **`Convert` class** is a utility that offers a robust set of methods for conversions between a wide range of base types, handling some conversions that casting or parsing alone might not, and providing a more "forgiving" approach to certain value-based conversions. 

Detailed Differences

|Feature|Casting|Convert Class|Parsing|
|---|---|---|---|
|**Source Type**|Compatible types (numeric, class hierarchy, etc.).|All base types supported by the class.|Exclusively from a `string` type.|
|**Error Handling**|Can cause data loss silently (e.g., `double` to `int` truncates decimals) or throw an `InvalidCastException`.|Throws an `OverflowException` on data loss and a `FormatException` for invalid input.|Throws exceptions (`FormatException`, `ArgumentNullException`, `OverflowException`) on invalid input or `null` values. (Use `TryParse` methods for safer, non-throwing operations).|
|**Data Loss**|Allows data loss (narrowing conversions must be explicit).|Generally more robust, using "banker's rounding" for floating-point to integer conversions, and throwing exceptions for data that is out of range.|Strict interpretation, requiring the string to perfectly match the target type's format (e.g., `"125.00"` cannot be parsed to an `int` directly).|
|**Mechanism**|A language-level operation, often involving simply re-interpreting the memory representation (for numeric types) or checking type compatibility (for reference types).|A static class providing helper methods that often use `Parse` internally or the `IConvertible` interface.|A method (e.g., `int.Parse()`, `DateTime.Parse()`) implemented by the target type to interpret the string content at runtime.|

Summary of Use Cases

- **Casting:** Use when converting between types that have an implicit or explicit relationship (e.g., `int` to `double`, or derived class to base class) and you are aware of potential data loss in explicit casts.
- **`Convert` class:** Use for general, robust conversions between different base types, especially when you need to handle `null` inputs gracefully (e.g., `Convert.ToInt32(null)` returns 0).
- **Parsing:** Use when converting data obtained from external input (like user input from a console or a file) in string format into a usable data type, and you are confident the string is in the correct format, or if you plan to use the safer `TryParse` pattern.



## Implicitly typed variables

var keyword, by using var keyword, the datatype is automatically given to the variable by the compiler.  


## ?? keyword is called: Null-coalescing operator

int num2 = int.Parse(Console.ReadLine() ?? "0");

This basically says that if the user input is null, then use 0 as string input.

## ! keyword

int num2 = int.Parse(Console.ReadLine()!);

The exclamation mark in here tells the compiler that "trust me the value will not be null, so the compiler won't give any warning"