// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//using (ApplicationDbContext context = new())
//{
//    context.Database.EnsureCreated();
//    if (context.Database.GetPendingMigrations().Count() > 0)
//    {
//        context.Database.Migrate();
//    }
//}

//AddBook();
//GetAllBooks();
//GetBook();
//UpdateBook();
//DeleteBook();

//async void DeleteBook()
//{
//    using var context = new ApplicationDbContext();
//    Book book = await context.Books.FindAsync(8);
//    context.Books.Remove(book);
//    await context.SaveChangesAsync();
//}

//void UpdateBook()
//{
//    try
//    {
//        using var context = new ApplicationDbContext();
//        var books = context.Books.Where(u => u.Publisher_Id== 1);
//        foreach (var book in books) {
//            book.Price = 55.55m;
//        }
//        context.SaveChanges();
//    }
//    catch (Exception e)
//    {
//    }
//}

//async void GetBook()
//{
//    using var context = new ApplicationDbContext();
//    var books = await context.Books.Skip(0).Take(2).ToListAsync();
//    //Console.WriteLine(book.Title + " - " + book.ISBN);
//    foreach (var book in books)
//    {
//        Console.WriteLine(book.Title + " - " + book.ISBN);
//    }

//    books = await context.Books.Skip(4).Take(1).ToListAsync();
//    //Console.WriteLine(book.Title + " - " + book.ISBN);
//    foreach (var book in books)
//    {
//        Console.WriteLine(book.Title + " - " + book.ISBN);
//    }
//}

//async void GetAllBooks()
//{
//    using var context = new ApplicationDbContext();
//    var books = await context.Books.ToListAsync();
//    foreach (var book in books)
//    {
//        Console.WriteLine(book.Title+ " - " + book.ISBN);
//    }
//}

//async void AddBook()
//{
//    Book book = new Book() { Title = "New EF Core Book", ISBN = "99999", Price = 10.93m, Publisher_Id = 1 };
//    using var context = new ApplicationDbContext();
//    var books = await context.Books.AddAsync(book);
//    await context.SaveChangesAsync();
//}