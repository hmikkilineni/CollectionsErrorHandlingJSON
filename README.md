# Collections, Error Handling, JSON & Account Relationships

C# console app covering Day 5 fundamentals for Dynamics 365 development.

## What I Practiced

### Collections
- Dictionary<string, int> with key-value pairs
- .Add(), .ContainsKey(), .Count
- Looping through Dictionary with foreach

### Error Handling
- try/catch/finally blocks
- FormatException — invalid user input
- DivideByZeroException — division by zero
- throw keyword

### File I/O & JSON
- File.WriteAllText() and File.ReadAllText()
- Newtonsoft.Json — SerializeObject and DeserializeObject
- Saving and reading objects as JSON files

### Account Relationships (One-to-Many)
- Account class with List<Contact>
- AddContact() method
- DisplayAll() method
- Mirrors real Dynamics 365 CRM relationships

## Why This Matters for Dynamics 365
- Plugins use Dictionary for entity attributes
- try/catch is mandatory in every plugin
- JSON used in Power Automate and custom APIs
- Account-Contact relationship is core CRM structure

## Tech
- C# / .NET 8
- Newtonsoft.Json
