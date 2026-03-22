# 🔹 What is a Jagged Array?

A **jagged array** is:

> 👉 An array of arrays (each row can have different sizes)

---

## ✅ Basic Example

int[][] jaggedArray = new int[3][];

👉 What this means:

- You have **3 arrays inside one array**
- But those inner arrays are **not created yet**

---

## 🔧 Initialize It Properly

int[][] jaggedArray = new int[3][];  
  
jaggedArray[0] = new int[2]; // 2 elements  
jaggedArray[1] = new int[4]; // 4 elements  
jaggedArray[2] = new int[1]; // 1 element

👉 Now each row has **different length**

---

## 📦 Full Example with Values

int[][] jaggedArray = new int[3][];  
  
jaggedArray[0] = new int[] { 1, 2 };  
jaggedArray[1] = new int[] { 3, 4, 5, 6 };  
jaggedArray[2] = new int[] { 7 };

---

# 🔥 Why It’s Called “Jagged”

Because it’s **not a perfect rectangle** — it’s uneven:

[1, 2]  
[3, 4, 5, 6]  
[7]

👉 Looks “jagged” (uneven edges)

---

# 🔹 Jagged Array vs 2D Array (IMPORTANT)

### 🧠 1. 2D Array (Matrix)

int[,] matrix = new int[3, 3];

👉 Always **fixed size (rows × columns)**

[1, 2, 3]  
[4, 5, 6]  
[7, 8, 9]

---

### 🧠 2. Jagged Array

int[][] jagged;

👉 Rows can have **different lengths**

---

# 🔥 Key Difference

|Feature|2D Array|Jagged Array|
|---|---|---|
|Shape|Fixed|Flexible|
|Memory|Continuous|Separate arrays|
|Use case|Matrix math|Variable-length data|

---

# 🔹 Real-Life Use Case

Let’s say:

- Students have different number of subjects

int[][] marks = new int[3][];  
  
marks[0] = new int[] { 80, 90 };       // 2 subjects  
marks[1] = new int[] { 70, 85, 88 };   // 3 subjects  
marks[2] = new int[] { 95 };           // 1 subject

👉 Perfect use of jagged array

---

# 🔹 Loop Through Jagged Array

for (int i = 0; i < jaggedArray.Length; i++)  
{  
    for (int j = 0; j < jaggedArray[i].Length; j++)  
    {  
        Console.Write(jaggedArray[i][j] + " ");  
    }  
    Console.WriteLine();  
}

---

# ⚠️ Common Mistake

int[][] arr = new int[3][];  
arr[0][0] = 10; // ❌ ERROR

👉 Why?  
Because `arr[0]` is still **null**

✔ Fix:

arr[0] = new int[2];  
arr[0][0] = 10;

---

# 🚀 Final Mental Model

👉 Jagged array =

array → contains → arrays → contain → values