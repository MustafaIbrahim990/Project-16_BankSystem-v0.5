# 🏦 Project-16: Bank System (v0.5)

**Author:** Mustafa A. Ibrahim

This repository contains a comprehensive **Bank System** application developed in **C#**, using a **Layered Architecture**:
- Console App (CLI)
- Business Layer
- Data Access Layer (DAL)

It includes advanced functionalities such as:
- 💾 SQL Server integration  
- 💱 Currency and country-linked management  
- 🔁 Transfer and login logging  
- 🔐 Robust user authentication with role-based permissions  

All data is persistently stored in **SQL Server**, ensuring scalability, reliability, and integrity.

---

## 📅 General Overview & Functionality

- Manage client accounts (personal data, PIN, balances)  
- Perform transactions (Deposit, Withdraw, Transfer)  
- Secure user login & role-based access control  
- Currency exchange with real-time rate updates  
- Country management linked to currencies  
- Detailed logging for all operations  
- Persistent data storage in SQL Server

---

## 💻 Technologies Used

- **Language:** C#  
- **Frameworks:**  
  - .NET Framework  
  - ADO.NET for SQL Server operations  
  - SQL Server for persistent data storage  

---

## 🛠️ Architecture

- **Console App:** CLI interface for users  
- **Business Layer:** Core application logic (validation, rules, services)  
- **Data Access Layer:** Handles all SQL Server interactions  
- **Windows Forms App:** *(Optional GUI front-end placeholder)*

---

## 🔧 Key Features

- ✅ **Layered Architecture** – Scalable and maintainable structure  
- 🧱 **OOP Design** – Strong encapsulation and class modeling (`clsClient`, `clsUser`, `clsCurrency`, `clsCountry`, etc.)  
- 🔐 **Authentication & Authorization** – Role-based permissions  
- 🧑‍💼 **User & Client Management** – Full CRUD operations  
- 💱 **Currency System** – Exchange rates, converter, linked to countries  
- 🧾 **Transfer & Login Logs** – Audit trails  
- 🖥️ **CLI Interface** – Clear, layered text-based menus  
- 🛡️ **Data Validation** – Strict checks at the business layer  

---

## ⬇️ Installation & Running

### 🔧 Prerequisites

- Visual Studio 2019+  
- SQL Server (Express / Developer Edition)  
- SQL Server Management Studio (SSMS)

### ⚙️ Setup Steps

1. **Clone the repository:**
   ```bash
   git clone https://github.com/MustafaIbrahim990/Project-16_BankSystem-v0.5.git
