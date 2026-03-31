using CollectionsErrorHandlingJSON;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// ── 1. Dictionary ──────────────────────────
Dictionary<string, int> skillLevel = new Dictionary<string, int>
{
    { "C#", 7 },
    { "Power Apps", 5 },
    { "LINQ", 8 },
    { "Plugins", 3 }
};

Console.WriteLine("=== Skill Levels ===");
foreach (var skill in skillLevel)
    Console.WriteLine($"{skill.Key} -> {skill.Value}");

bool linqExists = skillLevel.ContainsKey("LINQ");
Console.WriteLine($"LINQ Exists: {linqExists}");

skillLevel.Add("Power Automate", 4);
Console.WriteLine($"Total Skills: {skillLevel.Count}");

// ── 2. Account Relationships ───────────────
Console.WriteLine("\n=== Account Relationships ===");

var account1 = new AccountRelationships.Account("Avanade", "Consulting", 500000);
account1.AddContact(new AccountRelationships.Contact("Hari", "hari@gmail.com", "12345"));
account1.AddContact(new AccountRelationships.Contact("Phani", "phani@gmail.com", "99999"));
account1.AddContact(new AccountRelationships.Contact("Vijju", "vijju@gmail.com", "77777"));
account1.DisplayAll();

var account2 = new AccountRelationships.Account("Accenture", "Consulting", 800000);
account2.AddContact(new AccountRelationships.Contact("Sara", "sara@gmail.com", "55555"));
account2.AddContact(new AccountRelationships.Contact("Alex", "alex@gmail.com", "44444"));
account2.DisplayAll();