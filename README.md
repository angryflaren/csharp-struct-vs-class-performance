# C# Struct vs. Class: A Performance Analysis

A practical analysis of structs vs. classes in C#. This project explores their impact on performance and memory usage through benchmarks, helping developers choose the right data type for their applications.

This repository contains the source code and the [original research paper (in Russian)](./csharp-struct-vs-class-analysis.pdf) for this analysis.

## 📖 About the Project

Choosing between a `struct` and a `class` in C# is a fundamental decision that significantly affects an application's performance and memory footprint. While the theory is well-documented, the practical implications are not always clear.

This research provides clear, data-driven recommendations by answering a simple question: **When is it better to use a struct, and when is a class the more appropriate choice?**

The analysis is based on a series of practical experiments using the [BenchmarkDotNet](https://benchmarkdotnet.org/) library for precise and reliable measurements.

<p align="center">
  <a href="https://github.com/dotnet/BenchmarkDotNet">
    <img src="https://raw.githubusercontent.com/dotnet/BenchmarkDotNet/ec962b0bd6854c991d7a3ebd77037579165acb36/docs/logo/logo-wide.png" width="400" alt="BenchmarkDotNet Logo">
  </a>
</p>

## 🔬 Experiments

To get clear answers, we conducted three key experiments to compare structs and classes in different scenarios:

1.  **Object Copying:** Measured the performance of shallow and deep copying for objects with a varying number of fields (3, 10, and 50).
2.  **Passing to a Method:** Analyzed the overhead of passing objects of different sizes (small, medium, and large) to methods, comparing pass-by-value (for structs) and pass-by-reference (for classes).
3.  **Array Access:** Compared the speed of sequential and random access on large arrays of structs versus arrays of classes.

## 💡 Key Findings

The benchmarks showed that the optimal choice always depends heavily on the specific task.

#### ✅ Use a `struct` when:

* **Working with arrays:** Arrays of structs are significantly faster, especially with sequential access. This is due to better data locality, which leads to fewer cache misses. The performance advantage is even more dramatic with random access patterns.
* **You have small, simple data structures:** For small objects, structs are faster to pass to methods and do not create pressure on the Garbage Collector (GC), as they are typically allocated on the stack.
* **You want to avoid GC overhead:** Reducing heap allocations with structs can lead to fewer GC pauses, which is critical in high-performance applications.

#### ✅ Use a `class` when:

* **You have large, complex data structures:** It is more efficient to pass a single reference to a large object than to copy a large struct with all its data.
* **You need OOP features:** Classes support inheritance and polymorphism, which are essential for building complex object models.
* **You frequently perform shallow copies:** Copying a reference is an extremely fast operation, regardless of the object's size. For shallow copies, classes consistently outperform structs as the number of fields grows.

## 🚀 How to Run the Benchmarks

You are encouraged to run the experiments yourself to validate the results.

1.  Clone this repository.
2.  Open the `.sln` solution file in Visual Studio 2022 or newer.
3.  Make sure the benchmark project (e.g., `BenchmarkLab`) is set as the startup project.
4.  Build the solution in **Release** configuration.
5.  Run the project without debugging (Ctrl + F5).

BenchmarkDotNet will run all the experiments and display the results in the console.

## 📜 License

This project is licensed under the **MIT License**. See the `LICENSE` file for details.

## ✍️ Authors

| Role | Name | Contact |
| :--- | :--- | :--- |
| **Author** | **Matvey Zhuchkov** | <a href="mailto:matthewzhv@outlook.com" title="Contact via Outlook"><img src="./assets/outlook-logo.png" height="28" alt="Outlook Logo" style="vertical-align:middle;"></a> &nbsp; <a href="https://t.me/alikkuc" title="Contact via Telegram"><img src="./assets/telegram-logo.png" height="28" alt="Telegram Logo" style="vertical-align:middle;"></a> |
| **Supervisor** | **Olga Andreeva** | <a href="mailto:andreevaov@gmail.com" title="Contact via Gmail"><img src="./assets/gmail-logo.png" height="28" alt="Gmail Logo" style="vertical-align:middle;"></a> &nbsp; <a href="https://t.me/OlgaAndreeva99" title="Contact via Telegram"><img src="./assets/telegram-logo.png" height="28" alt="Telegram Logo" style="vertical-align:middle;"></a> |
