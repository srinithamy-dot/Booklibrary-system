namespace Booklibrary_system
{
    public class Book
    {
        // Properties
        public string BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; private set; } = true;
        public string BorrowedBy { get; private set; } = "";

        // Constructor
        public Book(string bookId, string title, string author, int year)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Year = year;
        }

        // Methods
        public bool Borrow(string memberId)
        {
            if (!IsAvailable)
                return false;          // already borrowed

            IsAvailable = false;
            BorrowedBy = memberId;
            return true;
        }

        public bool Return()
        {
            if (IsAvailable)
                return false;          // wasn't borrowed

            IsAvailable = true;
            BorrowedBy = "";
            return true;
        }
    }
}