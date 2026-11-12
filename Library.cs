
namespace Booklibrary_system
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();

        // ---------- Books ----------

        public List<Book> GetBooks()
        {
            return new List<Book>(books);
        }

        public bool AddBook(Book book)
        {
            if (FindBook(book.BookId) != null)
                return false;

            books.Add(book);
            return true;
        }

        public bool RemoveBook(string bookId)
        {
            Book? book = FindBook(bookId);
            if (book == null || !book.IsAvailable)
                return false;

            books.Remove(book);
            return true;
        }

        public Book? FindBook(string bookId)
        {
            foreach (Book b in books)
            {
                if (b.BookId == bookId)
                    return b;
            }
            return null;
        }

        public List<Book> SearchByTitle(string keyword)
        {
            List<Book> results = new List<Book>();
            foreach (Book b in books)
            {
                if (b.Title.ToLower().Contains(keyword.ToLower()))
                    results.Add(b);
            }
            return results;
        }

        // ---------- Members ----------

        public bool AddMember(Member member)
        {
            if (FindMember(member.MemberId) != null)
                return false;

            members.Add(member);
            return true;
        }

        public Member? FindMember(string memberId)
        {
            foreach (Member m in members)
            {
                if (m.MemberId == memberId)
                    return m;
            }
            return null;
        }

        // ---------- Borrow / Return ----------

        public string BorrowBook(string bookId, string memberId)
        {
            Book? book = FindBook(bookId);
            if (book == null)
                return "Book not found.";

            Member? member = FindMember(memberId);
            if (member == null)
                return "Member not found.";

            if (!book.Borrow(memberId))
                return "Book is already borrowed.";

            return $"{book.Title} borrowed by {member.Name}.";
        }

        public string ReturnBook(string bookId)
        {
            Book? book = FindBook(bookId);
            if (book == null)
                return "Book not found.";

            if (!book.Return())
                return "Book was not returned.";

            return $"{book.Title} returned.";
        }
    }
}