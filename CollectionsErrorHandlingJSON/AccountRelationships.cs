

namespace CollectionsErrorHandlingJSON
{
    public class AccountRelationships
    {
        public class Contact
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }

            public Contact(string name, string email, string phone)
            {
                Name = name;
                Email = email;
                Phone = phone;
            }
                public void DisplayInfo()
            {
                Console.WriteLine($" {Name} {Email} {Phone} ");
            }
            

        }
        public class Account
        {
            public string Name { get; set; }
            public string Industry { get; set; }
            public double AnnualRevenue { get; set; }

            public List<Contact> Contacts { get; set; } = new List<Contact>();

            public Account(string name, string industry, double annualRevenue)
            {
                Name = name;
                Industry = industry;
                AnnualRevenue = annualRevenue;
            }
            public void AddContact(Contact contact)
            {
                // add contact to list
                Contacts.Add(contact);
            }
            public void DisplayAll()
            {
                Console.WriteLine($"\n=== Account: {Name} ===");
                Console.WriteLine($"Industry: {Industry} | Revenue: €{AnnualRevenue}");
                Console.WriteLine("Contacts:");
                foreach (var contact in Contacts)
                {
                    contact.DisplayInfo();
                }

            }

        }
    }
}
