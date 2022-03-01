using Microsoft.EntityFrameworkCore;
using RazorPagesbooks.Models;

namespace RazorPagesMovie.Models
{
    public static class NewBaseType
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesBookContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesBookContext>>()))
            {
                if (context == null || context.Book == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "When Harry Met Sally",
                        PublishDate = DateTime.Parse("1989-2-12"),
                        Author = "Warner",
                        Sells = 1.5M,
                    },
                     new Book
                    {
                        Title = "Wings The Fire",
                        PublishDate = DateTime.Parse("1999-1-1"),
                        Author = "Kalam",
                        Sells = 1.2M,
                    },
 new Book
                    {
                        Title = "Surviving Hell",
                        PublishDate = DateTime.Parse("2001-2-15"),
                        Author = "Coleman",
                        Sells = 2.1M,
                    },
                    new Book
                    {
                        Title = "High Achiver",
                        PublishDate = DateTime.Parse("2004-10-12"),
                        Author = "SMith",
                        Sells = 2.5M,
                    },
               
                    


                    new Book
                    {
                        Title = "Rio Bravo",
                        PublishDate = DateTime.Parse("1959-4-15"),
                        Author = "Chetan Bhagat",
                        Sells = 1M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}