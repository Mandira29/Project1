# Restaurant Management System
# Restaurant Management System (RMS)

## Project Overview

The Restaurant Management System (RMS) is a standalone desktop application developed using C# and .NET (WPF/Windows Forms). The system helps restaurants manage daily operations including menu management, order processing, customer management, inventory tracking, billing, reporting, and employee administration.

The application improves operational efficiency, reduces manual paperwork, and provides data-driven insights through dashboards and reports.

---

# Objectives

* Automate restaurant operations.
* Manage customer orders efficiently.
* Maintain menu and inventory records.
* Generate sales and business reports.
* Provide secure user authentication.
* Enable data backup and recovery.
* Support data import and export.

---

# Technology Stack

| Component            | Technology            |
| -------------------- | --------------------- |
| Programming Language | C#                    |
| Framework            | .NET 8                |
| UI Framework         | WPF (MVVM Pattern)    |
| Database             | SQLite                |
| ORM                  | Entity Framework Core |
| Charts               | LiveCharts2           |
| PDF Reports          | QuestPDF              |
| Excel Export         | ClosedXML             |
| Version Control      | Git & GitHub          |

---

# System Users

### Administrator

* Manage users
* View reports
* Manage menu items
* Manage inventory
* Configure system settings

### Cashier

* Create orders
* Process payments
* Generate bills

### Manager

* Monitor dashboard
* View sales reports
* Manage inventory

---

# Main Features

## 1. Login & Authentication

### Functions

* User Login
* Logout
* Password Encryption
* Role-Based Access Control

### Event Handling

* Login Button Click
* Password Validation
* Keyboard Enter Key Login

---

## 2. Dashboard

### Features

* Total Sales
* Today's Orders
* Low Stock Items
* Monthly Revenue
* Recent Transactions

### Charts

* Daily Sales Chart
* Monthly Revenue Chart
* Top Selling Items

---

## 3. Menu Management (CRUD)

### Functions

* Add Menu Item
* Update Menu Item
* Delete Menu Item
* Search Menu Item

### Fields

* Item ID
* Item Name
* Category
* Price
* Availability Status

---

## 4. Customer Management (CRUD)

### Functions

* Add Customer
* Edit Customer
* Delete Customer
* Search Customer

### Fields

* Customer ID
* Name
* Contact Number
* Email
* Loyalty Points

---

## 5. Inventory Management (CRUD)

### Functions

* Add Stock
* Update Stock
* Delete Stock
* Monitor Inventory

### Fields

* Product Name
* Quantity
* Supplier
* Reorder Level

### Validation

* Quantity cannot be negative
* Required field validation

---

## 6. Order Management

### Functions

* Create Orders
* Add Multiple Food Items
* Calculate Total Amount
* Generate Bill

### Event Handling

* Add To Cart Button
* Remove Item Button
* Checkout Button

---

## 7. Billing System

### Features

* Automatic Tax Calculation
* Discount Calculation
* Receipt Generation

### Outputs

* Printable Bill
* PDF Receipt

---

## 8. Employee Management (CRUD)

### Functions

* Add Employee
* Update Employee
* Delete Employee
* Search Employee

### Fields

* Employee ID
* Name
* Position
* Salary
* Contact Number

---

## 9. Report Generation

### Available Reports

#### Sales Report

* Daily Sales
* Weekly Sales
* Monthly Sales

#### Inventory Report

* Current Stock
* Low Stock Items

#### Employee Report

* Employee Details

### Export Formats

* PDF
* Excel
* CSV

---

## 10. Import & Export

### Import

* Excel Files
* CSV Files

### Export

* PDF Reports
* Excel Reports
* CSV Data

---

## 11. Backup & Restore

### Backup

* Full Database Backup
* Automatic Backup

### Restore

* Restore Previous Backup
* Recover Deleted Data

---

# Innovative Feature

## AI-Based Sales Prediction

The system analyzes previous sales records and predicts:

* Expected daily revenue
* Popular menu items
* Future inventory requirements

Benefits:

* Better inventory planning
* Reduced food wastage
* Improved profit forecasting

---

# GUI Design

## Main Windows

### Login Window

* Username TextBox
* Password Box
* Login Button

### Dashboard Window

* KPI Cards
* Charts
* Navigation Menu

### Menu Management Window

* DataGrid
* Search Bar
* CRUD Buttons

### Inventory Window

* DataGrid
* Filters
* Stock Alerts

### Order Window

* Menu List
* Shopping Cart
* Checkout Section

### Reports Window

* Report Filters
* Export Buttons

---

# Event-Driven Programming

### Button Events

* Login
* Save
* Update
* Delete
* Export

### Validation Events

* TextChanged
* LostFocus
* Numeric Validation

### Menu Events

* File Menu
* Report Menu
* Backup Menu

### Keyboard Events

* Enter Key Login
* Shortcut Keys

### Mouse Events

* Double Click Records
* Context Menu Operations

---

# Database Design

## Users Table

| Field        | Type    |
| ------------ | ------- |
| UserId       | Integer |
| Username     | Text    |
| PasswordHash | Text    |
| Role         | Text    |

## MenuItems Table

| Field    | Type    |
| -------- | ------- |
| ItemId   | Integer |
| Name     | Text    |
| Category | Text    |
| Price    | Decimal |

## Customers Table

| Field      | Type    |
| ---------- | ------- |
| CustomerId | Integer |
| Name       | Text    |
| Contact    | Text    |

## Orders Table

| Field       | Type     |
| ----------- | -------- |
| OrderId     | Integer  |
| CustomerId  | Integer  |
| TotalAmount | Decimal  |
| OrderDate   | DateTime |

## Inventory Table

| Field       | Type    |
| ----------- | ------- |
| InventoryId | Integer |
| ProductName | Text    |
| Quantity    | Integer |

---

# Security Features

* Password Hashing
* Role-Based Access Control
* Input Validation
* SQL Injection Prevention
* Secure Backup Storage

---

# Project Structure

```text
RestaurantManagementSystem/
├── Models/
├── Views/
├── ViewModels/
├── Services/
├── Data/
├── Reports/
├── Helpers/
├── Resources/
├── Database/
└── README.md


Version Control & Git Workflow
Our team uses Git and GitHub for collaborative development, adhering to an agile branching workflow.

Branching Strategy
master / main: Contains production-ready, stable code.

Feature Branches: Team members build specific features on isolated branches (e.g., categoriesList, customerList) before merging.

Team Workflow
Isolate tasks into standalone feature branches.

Commit tasks with descriptive updates.

Push branches to the remote repository.

Initiate a Pull Request (PR) on GitHub.

Review code and merge feature branches back into the master branch.

Team Contributions & Git Evidence
Core Contributors
Mandira29 (Rose)

Established baseline project configuration structure and initial build architecture.

Created data models and backend logic, including database.sql integrations.

Developed the UI core layout for customer interactions (customersForm).

Managed repository integration, successfully merging pull requests for feature additions (categoriesList, customerList).

Completed functional implementation of the product listing module (productsList.cs).

sachintha-ramesh

Built functional logic and UI panels for customer records view (CustomerForm dashboard).

Developed category management structures to configure dynamic menu additions.

Executed debugging and optimization patches for the registration forms.

ThiliniMelshika

Handled layout design configurations for primary windows (ManinForm.cs, mainForm[Design], maninForm.resx).

Built frontend view models for the main interactive dashboard interface.

seminipriyanath

Developed structural UI view modules specifically for stock management and product catalog cards.

Git Workflow Verification
The following captured logs verify team collaboration, branch maintenance, pull request tracking, and merge confirmations on GitHub:

Remote Commits Summary
Shows master updates tracking feature merges and product core updates.

Shows sequential foundation commits tracking database scripts and basic form construction.

Future Enhancements
Online Ordering

Mobile Application

QR Code Menu

Cloud Database

AI Chat Assistant

Customer Loyalty System

Expected Outcomes
The Restaurant Management System will:

Improve operational efficiency

Reduce manual errors

Increase customer satisfaction

Provide business insights through reports and dashboards

Support data-driven decision making

Conclusion
The Restaurant Management System is a complete desktop-based business solution developed using C# and .NET technologies. The application demonstrates GUI design, event-driven programming, data storage, report generation, CRUD operations, authentication, backup and restore functionality, dashboard analytics, and an innovative AI-based sales prediction feature.

🔗 Repository Links
GitHub Repository: https://github.com/Mandira29/Project1/

Commit History: https://github.com/Mandira29/Project1/commits/master/



