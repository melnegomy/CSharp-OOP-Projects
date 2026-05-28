# 🎬 Movie Ticket Booking System

## 📌 Overview

The **Movie Ticket Booking System** is a C# Object-Oriented Programming (OOP) project that simulates a cinema ticket management system.

The project demonstrates important OOP concepts such as:

* Encapsulation
* Inheritance
* Polymorphism
* Abstraction
* Interfaces
* Partial Classes
* Extension Methods
* Composition

The system supports different ticket types, booking/canceling tickets, cinema management, and revenue calculation.

---

# 🛠 Technologies Used

* C#
* .NET
* Console Application
* Object-Oriented Programming (OOP)

---

# 📂 Project Structure

## Interfaces

### `IPrintable`

Used for printing ticket details.

```csharp
interface IPrintable
{
    void Print();
}
```

### `IBookable`

Used for booking and canceling tickets.

```csharp
interface IBookable
{
    bool Book();
    bool Cancel();
}
```

---

# 🎟 Ticket System

## Abstract Class: `Ticket`

The base abstract class for all ticket types.

### Features

* Auto-generated Ticket ID
* Movie name validation
* Price validation
* Booking status
* Tax calculation
* Abstract final price calculation
* Abstract printing method

### Important Members

| Member                  | Description                   |
| ----------------------- | ----------------------------- |
| `MovieName`             | Name of the movie             |
| `Price`                 | Base ticket price             |
| `IsBooked`              | Booking status                |
| `PriceAfterTax`         | Price after 14% tax           |
| `CalculateFinalPrice()` | Calculates final ticket price |
| `Book()`                | Books the ticket              |
| `Cancel()`              | Cancels the booking           |

---

# 🎫 Ticket Types

## 1️⃣ StandardTicket

Represents a normal cinema ticket.

### Extra Features

* Seat Number

### Final Price

```text
Price + Tax
```

---

## 2️⃣ VIPTicket

Represents a VIP cinema ticket.

### Extra Features

* Lounge Access
* Service Fee

### Final Price

```text
Price + Tax + Service Fee
```

---

## 3️⃣ IMAXTicket

Represents an IMAX ticket.

### Extra Features

* Optional 3D Mode

### Final Price

```text
Price (+ 3D Extra) + Tax
```

---

# 🎥 Projector Class

The `Projector` class simulates cinema projector operations.

### Methods

* `Start()`
* `Stop()`

This demonstrates **Composition**, because the `Cinema` class contains a `Projector` object.

---

# 🏢 Cinema Class

The `Cinema` class is implemented using **Partial Classes**.

## Partial File 1 — Ticket Management

Contains:

* Cinema opening/closing
* Ticket storage
* Adding tickets

## Partial File 2 — Reporting

Contains:

* Printing all tickets

---

# 🔥 Extension Methods

## `GenerateReceipt()`

Generates a formatted receipt for a ticket.

Example:

```text
========== RECEIPT ==========
Movie    : Avengers
Type     : VIPTicket
Price    : 200
Final    : 278.00
Status   : Booked
=============================
```

---

## `TotalRevenue()`

Calculates total revenue from all tickets.

---

# 🧠 OOP Concepts Used

| Concept           | Usage                                            |
| ----------------- | ------------------------------------------------ |
| Encapsulation     | Private fields with properties                   |
| Inheritance       | Ticket subclasses inherit from `Ticket`          |
| Polymorphism      | Overriding `CalculateFinalPrice()` and `Print()` |
| Abstraction       | Abstract class `Ticket`                          |
| Interfaces        | `IPrintable`, `IBookable`                        |
| Composition       | Cinema contains Projector                        |
| Partial Classes   | `Cinema` split into multiple files               |
| Extension Methods | Receipt & Revenue methods                        |

---

# ▶️ Program Flow

1. Create cinema object
2. Open cinema
3. Create tickets
4. Book tickets
5. Add tickets to cinema
6. Print all tickets
7. Display polymorphism results
8. Generate receipt
9. Calculate total revenue
10. Close cinema

---

# ✅ Sample Output

```text
=== Cinema Opened ===
Projector ON

--- All Tickets ---
[Ticket #1] Inception | Standard | Seat: A5
[Ticket #2] Avengers | VIP
[Ticket #3] Dune | IMAX

--- Total Revenue ---
Total Revenue: 529.20

=== Cinema Closed ===
Projector OFF
```

---

# 🚀 Future Improvements

Possible future enhancements:

* Database integration
* GUI interface
* Online payment system
* Seat availability map
* Admin panel
* Customer accounts
* File handling

---

# 👨‍💻 Author

Developed by:
Mohammed Habib Elnogomy

.NET Backend Developer Student
FCIS - Mansoura University

