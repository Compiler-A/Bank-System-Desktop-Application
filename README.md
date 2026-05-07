# 🏦 Bank System Desktop Application

A full-featured **desktop banking management system** built with **C# / Windows Forms**, following a clean **3-Tier Architecture** pattern. The application simulates core banking operations including account management, transactions, and user administration — all backed by a structured SQL Server database.

---

## 📋 Table of Contents

- [Overview](#overview)
- [Architecture](#architecture)
- [Features](#features)
- [Project Structure](#project-structure)
- [Database Schema](#database-schema)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Prerequisites](#prerequisites)
- [Installation](#installation)

---

## 📌 Overview

This project is a desktop application that simulates a simplified banking system. It allows bank employees or administrators to manage clients, bank accounts, and financial transactions through a clean and structured Windows Forms interface.

---

## 🏗️ Architecture

The project follows a **3-Tier Architecture**:

```
┌─────────────────────────────┐
│      Presentation Layer     │  ← BankSystem (Windows Forms UI)
├─────────────────────────────┤
│      Business Layer         │  ← BusinessLayer (Logic & Validation)
├─────────────────────────────┤
│        Data Layer           │  ← DataLayer (SQL Server / ADO.NET)
└─────────────────────────────┘
```

| Layer | Folder | Responsibility |
|-------|--------|----------------|
| **Presentation** | `BankSystem/` | UI Forms, user interaction |
| **Business** | `BusinessLayer/` | Business logic, rules & validation |
| **Data** | `DataLayer/` | Database queries, CRUD operations |

---

## ✨ Features

- 👤 **Client Management** — Add, update, delete, and search for clients
- 🏦 **Account Management** — Create and manage bank accounts
- 💸 **Transactions** — Deposit, withdraw, and transfer between accounts
- 🔐 **User Authentication** — Login system with user roles
- 📋 **Transaction History** — View logs of all financial operations
- 🗄️ **Database Integration** — Persistent storage via SQL Server

---

## 📁 Project Structure

```
Bank-System-Desktop-Application/
│
├── BankSystem/             # Presentation Layer (Windows Forms)
│   ├── Forms/              # UI screens/forms
│   └── ...
│
├── BusinessLayer/          # Business Logic Layer
│   ├── clsClient.cs        # Client business logic
│   ├── clsAccount.cs       # Account business logic
│   ├── clsTransaction.cs   # Transaction logic
│   └── ...
│
├── DataLayer/              # Data Access Layer
│   ├── clsClientData.cs    # Client DB operations
│   ├── clsAccountData.cs   # Account DB operations
│   └── ...
│
├── BankSystemDB.svg        # Database schema diagram
├── bnkdb                   # SQL Server database file
└── README.md
```

---

## 🗄️ Database Schema

The database schema is visualized in [`BankSystemDB.svg`](./BankSystemDB.svg). It includes tables for clients, accounts, users, and transactions with proper relational constraints.

---

## 🛠️ Technologies Used

| Technology | Purpose |
|-----------|---------|
| **C#** | Primary programming language |
| **Windows Forms (WinForms)** | Desktop UI framework |
| **ADO.NET** | Database connectivity |
| **SQL Server** | Relational database |
| **.NET Framework** | Runtime environment |

---

## 🚀 Getting Started

### Prerequisites

Make sure you have the following installed:

- [Visual Studio 2019+](https://visualstudio.microsoft.com/) (with .NET Desktop Development workload)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or SQL Server Express)
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) *(optional but recommended)*

### Installation

1. **Clone the repository**

   ```bash
   git clone https://github.com/Compiler-A/Bank-System-Desktop-Application.git
   cd Bank-System-Desktop-Application
   ```

2. **Set up the database**

   - Open SQL Server Management Studio
   - Attach or restore the `bnkdb` database file
   - Verify all tables are created correctly using the `BankSystemDB.svg` diagram as reference

3. **Configure the connection string**

   In the `DataLayer` project, locate the database connection settings and update the connection string to match your SQL Server instance:

   ```csharp
   // Example in DataLayer
   static string connectionString = "Server=YOUR_SERVER;Database=bnkdb;Integrated Security=True;";
   ```

4. **Open the solution in Visual Studio**

   - Open `BankSystem.sln`
   - Set `BankSystem` as the startup project
   - Build the solution (`Ctrl + Shift + B`)

5. **Run the application**

   Press `F5` or click **Start** in Visual Studio.

---

## 📄 License

This project is open source and available for educational purposes.

---

## 👤 Author

**Compiler-A** — [GitHub Profile](https://github.com/Compiler-A)