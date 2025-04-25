# CustomerManagerApp

A simple ASP.NET Core MVC web app to view, add, and edit customer details.  
Data is stored in memory (no database needed). Built for a programming test with a focus on clean design and meeting requirements.

---

## Features
- View customer list
- Add & edit customers
- Input validation
- Responsive UI with Bootstrap

---

## Tech Stack
- ASP.NET Core MVC (.NET 9)
- Razor Views
- C#
- Bootstrap

---

## Customer Fields & Validation

- **Name**: Max 50 characters  
- **Age**: 0 - 110  
- **Post Code**: Must include letters & numbers (spaces allowed)  
- **Height (m)**: 0 - 2.50 (2 decimal places)

---

## How to Run

```bash
git clone https://github.com/your-username/CustomerManagerApp.git
cd CustomerManagerApp
dotnet run
