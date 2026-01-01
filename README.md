# 🏦 Compound Interest Calculator

> **Day 1** of the 118-Day ASP.NET Backend Developer Mastery Journey

A C# console application that calculates compound interest for savings accounts, demonstrating fundamental programming concepts used in real banking systems.

---

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [How It Works](#how-it-works)
- [Sample Output](#sample-output)
- [What I Learned](#what-i-learned)
- [Future Enhancements](#future-enhancements)
- [Real-World Application](#real-world-application)
- [Project Journey](#project-journey)

---

## 🎯 Overview

This project is the first step in my journey to becoming a backend developer at Equity Bank. It demonstrates the implementation of compound interest calculation—a fundamental feature in every banking application.

**Challenge Date:** January 1, 2025  
**Objective:** Master C# syntax, variables, methods, and basic mathematical operations through a real-world banking scenario.

---

## ✨ Features

- **Interactive Console Input** - User-friendly prompts for data entry
- **Compound Interest Calculation** - Uses the standard financial formula
- **Formatted Output** - Displays results in Kenyan Shillings (KSh) with 2 decimal places
- **Reusable Method** - Separates calculation logic for clean code architecture
- **Real Banking Context** - Mirrors actual savings account calculations

---

## 🛠️ Technologies Used

- **Language:** C# 12
- **.NET Version:** .NET 8.0
- **IDE:** Visual Studio 2022 / Visual Studio Code
- **Version Control:** Git & GitHub

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) or later
- Visual Studio 2022, VS Code, or any C# IDE

### Installation & Running

1. **Clone the repository**
   ```bash
   git clone https://github.com/steve-ongera/ASP.NET-Mastery-Journey-Day1.git
   cd ASP.NET-Mastery-Journey-Day1
   ```

2. **Navigate to the project folder**
   ```bash
   cd CompoundInterestCalculator
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

   Or open `CompoundInterestCalculator.slnx` in Visual Studio and press `F5`.

---

## 🧮 How It Works

### The Formula

The application uses the standard compound interest formula:

```
A = P × (1 + r/n)^(n×t)
```

Where:
- **A** = Final amount
- **P** = Principal (initial deposit)
- **r** = Annual interest rate (as decimal)
- **n** = Number of times interest is compounded per year
- **t** = Time in years

### Code Structure

```csharp
static double CalculateCompoundInterest(double p, double r, int n, int t)
{
    return p * Math.Pow((1 + r / n), n * t);
}
```

**Key Concepts Demonstrated:**
- Variable declaration and type safety
- User input with `Console.ReadLine()`
- Type conversion (`Convert.ToDouble`, `Convert.ToInt32`)
- Method creation with parameters and return values
- Mathematical operations with `Math.Pow()`
- String formatting and interpolation

---

## 📊 Sample Output

```
=== Compound Interest Calculator ===
Enter principal amount (KSh): 10000
Enter annual interest rate (%): 10
Enter number of times interest is compounded per year: 4
Enter time (in years): 2

--- Results ---
Final Amount: KSh 12155.06
Total Interest Earned: KSh 2155.06
```

### Test Cases

| Principal (KSh) | Rate (%) | Compounds/Year | Years | Final Amount (KSh) | Interest (KSh) |
|-----------------|----------|----------------|-------|-------------------|----------------|
| 10,000          | 10       | 4              | 2     | 12,155.06         | 2,155.06       |
| 50,000          | 8.5      | 12             | 5     | 76,405.82         | 26,405.82      |
| 100,000         | 12       | 365            | 1     | 112,747.78        | 12,747.78      |

---

## 📚 What I Learned

### Technical Skills
- ✅ C# syntax and code structure
- ✅ Data types (`double`, `int`, `string`)
- ✅ User input/output with `Console` class
- ✅ Method creation and invocation
- ✅ Mathematical operations and `Math` library
- ✅ String formatting with interpolation (`$`)
- ✅ Type conversion and casting

### Banking Domain Knowledge
- 💰 How compound interest works
- 💰 Difference between simple and compound interest
- 💰 Common compounding frequencies (monthly, quarterly, annually)
- 💰 Real-world savings account calculations

### Software Development Practices
- 📝 Git version control basics
- 📝 Proper `.gitignore` usage for C# projects
- 📝 Writing clean, readable code
- 📝 Separation of concerns (calculation vs. display logic)
- 📝 Professional README documentation

---

## 🔮 Future Enhancements

As I progress through my 118-day journey, I plan to enhance this project:

- [ ] **Day 2:** Convert to OOP with `SavingsAccount` class
- [ ] **Week 2:** Transform into ASP.NET Core Web API
- [ ] **Week 3:** Add database persistence with Entity Framework
- [ ] **Week 4:** Implement authentication and user accounts
- [ ] **Week 6:** Add scheduled interest calculation (Hangfire)
- [ ] **Week 8:** Create PDF statement generation
- [ ] **Week 15:** Integrate with mobile banking app

### Immediate Enhancements (Optional)
- Add input validation (no negative values)
- Support for simple interest calculation
- Monthly deposit feature (recurring savings)
- Export results to CSV/JSON file
- Multiple currency support
- Comparison table for different rates

---

## 🌍 Real-World Application

This calculator demonstrates concepts used in:

### Banking Systems
- **Equity Bank** - Savings account projections
- **KCB** - Fixed deposit calculators
- **Co-operative Bank** - Investment growth tools

### Features in Production Apps
- Mobile banking apps (balance projections)
- Online banking portals (savings goal trackers)
- Loan calculators (understanding total repayment)
- Investment platforms (ROI calculations)

### Kenyan Banking Context
- Typical savings rates: 6-12% per annum
- Fixed deposits: 8-15% per annum
- Money market funds: 10-14% per annum
- Compounding: Usually monthly or quarterly

---

## 📈 Project Journey

**Date Started:** January 1, 2025  
**Status:** ✅ Completed  
**Time Spent:** ~2 hours  
**Commits:** 1  
**Lines of Code:** ~35

### Challenges Faced
1. **Git Permission Error** - Learned to properly exclude `.vs/` folder
2. **Type Conversion** - Understanding when to use `double` vs `decimal` for money
3. **Formula Implementation** - Correctly translating math formula to code

### Key Takeaways
- Always create `.gitignore` before first commit
- Financial calculations require precision (`double` for interest rates)
- Clean code structure makes logic easy to understand
- User experience matters even in console apps

---

## 🎓 Part of Learning Journey

This project is **Day 1** of my **118-Day ASP.NET Backend Developer Mastery Journey** targeting a backend developer role at **Equity Bank** or similar financial institutions in Kenya.

**Journey Roadmap:**
- ✅ **Week 1:** C# & .NET Fundamentals
- 🔄 **Week 2:** Web APIs Fundamentals
- 📅 **Week 3:** Database Integration
- 📅 **Weeks 4-5:** Authentication & Security
- 📅 **Weeks 6-8:** Advanced Features
- 📅 **Weeks 9-10:** Testing & Quality
- 📅 **Weeks 11-13:** Microservices & Architecture
- 📅 **Weeks 14-17:** Real-World Projects

**End Goal (April 28, 2025):** Job-ready backend developer with production-quality portfolio

---

## 📞 Connect With Me

**Developer:** Steve Ongera  
**GitHub:** [@steve-ongera](https://github.com/steve-ongera)  
**Journey Start:** January 1, 2025  
**Target Role:** Backend Developer @ Equity Bank

---

## 📄 License

This project is part of a personal learning journey and is available for educational purposes.

---

## 🙏 Acknowledgments

- **Inspiration:** 118-Day ASP.NET Mastery Journey curriculum
- **Target Company:** Equity Bank Kenya
- **Community:** C# and .NET developer community

---

### ⭐ If you're also learning ASP.NET, feel free to fork this repo and start your own journey!

**Next:** [Day 2 - OOP Account Classes →](../Day2-OOP-Account-Classes)

---

*"Every expert was once a beginner. Every backend system started with a single line of code."*