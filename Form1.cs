namespace Booklibrary_system
{
    public partial class Form1 : Form
    {
        // The form owns one Library object, which holds all books and members
        private Library library = new Library();

        public Form1()
        {
            InitializeComponent();

            // Connect each button to the method that runs when it's clicked
            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnAddMember.Click += btnAddMember_Click;
            btnBorrow.Click += btnBorrow_Click;
            btnReturn.Click += btnReturn_Click;
            btnSearch.Click += btnSearch_Click;
            btnShowAll.Click += btnShowAll_Click;
            dgvBooks.SelectionChanged += dgvBooks_SelectionChanged;
        }

        // ---------- Start-up ----------

        private void Form1_Load(object? sender, EventArgs e)
        {
            // Sample data so the table isn't empty when the app opens
            library.AddBook(new Book("B001", "Introduction to C#", "Ahmad Razak", 2021));
            library.AddBook(new Book("B002", "Data Structures", "Lee Wei Ming", 2019));
            library.AddBook(new Book("B003", "Web Design Basics", "Siti Aminah", 2022));
            library.AddMember(new Member("M001", "Ali", "012-3456789"));
            library.AddMember(new Member("M002", "Mei Ling", "013-9876543"));

            RefreshBookList();
        }

        // Created earlier by double-clicks in the designer; kept so the designer still finds them
        private void dataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtBookId_TextChanged(object? sender, EventArgs e)
        {
        }

        // ---------- Helper methods ----------

        private void RefreshBookList(List<Book>? books = null)
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = books ?? library.GetBooks();

            DataGridViewColumn? col;

            col = dgvBooks.Columns["BookId"];
            if (col != null) col.HeaderText = "Book ID";

            col = dgvBooks.Columns["IsAvailable"];
            if (col != null) col.HeaderText = "Available";

            col = dgvBooks.Columns["BorrowedBy"];
            if (col != null) col.HeaderText = "Borrowed By";
        }



        private Book? GetSelectedBook()
        {
            if (dgvBooks.CurrentRow == null)
                return null;
            return dgvBooks.CurrentRow.DataBoundItem as Book;
        }

        private void ClearBookFields()
        {
            txtBookId.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            txtBookId.Focus();
        }

        // ---------- Book buttons ----------

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            string id = txtBookId.Text.Trim();
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();

            if (id == "" || title == "" || author == "")
            {
                MessageBox.Show("Please fill in Book ID, Title and Author.", "Missing information");
                return;
            }

            if (!int.TryParse(txtYear.Text, out int year) || year < 1000 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Please enter a valid year.", "Invalid year");
                return;
            }

            if (library.AddBook(new Book(id, title, author, year)))
            {
                MessageBox.Show("Book added.", "Success");
                RefreshBookList();
                ClearBookFields();
            }
            else
            {
                MessageBox.Show($"Book ID {id} already exists.", "Duplicate ID");
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            Book? book = GetSelectedBook();
            if (book == null)
            {
                MessageBox.Show("Please select a book in the table first.", "No book selected");
                return;
            }

            DialogResult answer = MessageBox.Show($"Delete \"{book.Title}\"?", "Confirm delete",
                                                  MessageBoxButtons.YesNo);
            if (answer != DialogResult.Yes)
                return;

            if (library.RemoveBook(book.BookId))
            {
                RefreshBookList();
                ClearBookFields();
            }
            else
            {
                MessageBox.Show("This book is currently borrowed and cannot be deleted.", "Cannot delete");
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearBookFields();
        }

        // When a row is clicked, copy that book into the text boxes
        private void dgvBooks_SelectionChanged(object? sender, EventArgs e)
        {
            Book? book = GetSelectedBook();
            if (book == null)
                return;

            txtBookId.Text = book.BookId;
            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            txtYear.Text = book.Year.ToString();
        }

        // ---------- Member and loan buttons ----------

        private void btnAddMember_Click(object? sender, EventArgs e)
        {
            string id = txtMemberId.Text.Trim();
            string name = txtMemberName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (id == "" || name == "")
            {
                MessageBox.Show("Please fill in Member ID and Name.", "Missing information");
                return;
            }

            if (library.AddMember(new Member(id, name, phone)))
            {
                MessageBox.Show($"Member {name} added.", "Success");
                txtMemberName.Clear();
                txtPhone.Clear();
            }
            else
            {
                MessageBox.Show($"Member ID {id} already exists.", "Duplicate ID");
            }
        }

        private void btnBorrow_Click(object? sender, EventArgs e)
        {
            Book? book = GetSelectedBook();
            if (book == null)
            {
                MessageBox.Show("Please select a book in the table first.", "No book selected");
                return;
            }

            string memberId = txtMemberId.Text.Trim();
            if (memberId == "")
            {
                MessageBox.Show("Please enter a Member ID.", "Missing information");
                return;
            }

            string message = library.BorrowBook(book.BookId, memberId);
            MessageBox.Show(message, "Borrow");
            RefreshBookList();
        }

        private void btnReturn_Click(object? sender, EventArgs e)
        {
            Book? book = GetSelectedBook();
            if (book == null)
            {
                MessageBox.Show("Please select a book in the table first.", "No book selected");
                return;
            }

            string message = library.ReturnBook(book.BookId);
            MessageBox.Show(message, "Return");
            RefreshBookList();
        }

        // ---------- Search ----------

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (keyword == "")
            {
                RefreshBookList();
                return;
            }

            List<Book> results = library.SearchByTitle(keyword);
            RefreshBookList(results);

            if (results.Count == 0)
                MessageBox.Show("No books found.", "Search");
        }

        private void btnShowAll_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            RefreshBookList();
        }
    }
}