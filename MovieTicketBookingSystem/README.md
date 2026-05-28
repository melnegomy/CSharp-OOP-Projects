# 🎬 Movie Ticket Booking System

A console-based Movie Ticket Booking System developed using C# and Object-Oriented Programming (OOP) principles. The project demonstrates core and advanced OOP concepts including abstraction, inheritance, polymorphism, encapsulation, interfaces, partial classes, composition, and extension methods.

---

# 🚀 Features

* Multiple ticket types
* Ticket booking & cancellation
* Automatic ticket IDs
* Revenue calculation
* Receipt generation
* Cinema management
* Tax calculation
* Polymorphism support
* Clean file organization

---

# 🛠 Technologies Used

* C#
* .NET
* Console Application
* Object-Oriented Programming (OOP)

---

# 📂 Project Structure

```text
Movie-Ticket-Booking-System
│
├── Interfaces
│   ├── IPrintable.cs
│   └── IBookable.cs
│
├── Tickets
│   ├── Ticket.cs
│   ├── StandardTicket.cs
│   ├── VIPTicket.cs
│   └── IMAXTicket.cs
│
├── Cinema
│   ├── Cinema.Tickets.cs
│   └── Cinema.Reporting.cs
│
├── Extensions
│   └── TicketExtensions.cs
│
├── Services
│   └── Projector.cs
│
├── Program.cs
│
└── README.md
```

---

# 🧠 OOP Concepts Used

| Concept           | Usage                                   |
| ----------------- | --------------------------------------- |
| Encapsulation     | Private fields with properties          |
| Inheritance       | Ticket subclasses inherit from `Ticket` |
| Polymorphism      | Overriding methods                      |
| Abstraction       | Abstract class `Ticket`                 |
| Interfaces        | `IPrintable`, `IBookable`               |
| Composition       | Cinema contains Projector               |
| Partial Classes   | Cinema split into multiple files        |
| Extension Methods | Receipt & Revenue methods               |

---

# 🎟 Ticket Types

## Standard Ticket

* Seat number support
* Basic ticket pricing

## VIP Ticket

* Lounge access
* Additional service fee

## IMAX Ticket

* Optional 3D support
* Enhanced pricing

---

# 🔥 Extension Methods

## GenerateReceipt()

Generates formatted receipt information for a ticket.

## TotalRevenue()

Calculates total revenue from all tickets.

---

# ▶️ Program Flow

1. Open cinema
2. Create tickets
3. Book tickets
4. Add tickets to cinema
5. Print all tickets
6. Generate receipt
7. Calculate total revenue
8. Close cinema

---

# 👨‍💻 Author

Mohammed Habib Elnogomy
Junior .NET Backend Developer
