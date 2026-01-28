# M1 Practice - 28th January 2026

This repository contains C# practice problems covering various programming concepts including Exception Handling, Interfaces, and String Manipulation.

## Project Structure

```
M1-Prac-28th-Jan/
├── Exception/          # Exception handling exercises
│   ├── GOAIR.cs       # Employee ID validation with custom exceptions
│   └── ShopValidator.cs # Gadget validation utilities
├── Interface/          # Interface implementation exercises
│   └── Hotel.cs       # Hotel room management system
├── String/            # String manipulation exercises
│   └── WordWand.cs    # Word transformation utilities
└── Program.cs         # Main entry point
```

## Features

### 1. Exception Handling
- **GOAIR Employee Validation**: Validates employee IDs with format `GOAIR/XXXX`
- **Gadget Validator**: Validates gadget IDs and warranty periods with custom exception handling

### 2. Interface Implementation
- **Hotel Room System**: Implements room booking with membership discount calculations
- Default interface methods for membership year calculation
- Dynamic billing based on room type and membership status

### 3. String Manipulation
- **WordWand**: Transforms sentences based on word count
  - Even word count: Reverses word order
  - Odd word count: Reverses each individual word

## Technologies Used
- **.NET 10.0**
- **C#**
- **Visual Studio / VS Code**

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/Fleek691/M1Practice-28-01-2026.git
   ```

2. Navigate to the project directory:
   ```bash
   cd M1-Prac-28th-Jan
   ```

3. Build the project:
   ```bash
   dotnet build
   ```

4. Run the project:
   ```bash
   dotnet run
   ```

## Requirements
- .NET SDK 10.0 or higher
- Visual Studio 2022 or VS Code with C# extension

## Author
Avish

## License
This is a practice project for educational purposes.