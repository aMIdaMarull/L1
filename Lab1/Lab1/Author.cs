namespace Lab1
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Author(int id, string firstName, string lastName)
        {
            if (id < 0)
            {
                throw new ArgumentException("ID cannot be negative.", nameof(id));
            }

            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("First name cannot be null or empty.", nameof(firstName));
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Last name cannot be null or empty.", nameof(lastName));
            }

            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Author (Id: {Id}, FirstName: {FirstName}, LastName: {LastName})";
        }
    }
}
