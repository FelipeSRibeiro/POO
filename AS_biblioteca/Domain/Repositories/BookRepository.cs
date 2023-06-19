using AS_biblioteca.Data.Context;
using AS_biblioteca.Domain.Entities;
using AS_biblioteca.Domain.Interfaces;

namespace AS_biblioteca.Domain.Repositories
{
    public class BookRepository : IBookRepository
    {
        public readonly DataContext context;

        public BookRepository(DataContext context)
        {
            this.context = context;
        }

        public void Delete(int entityId)
        {
            var book = GetById(entityId);
            context.Books.Remove(book);
            context.SaveChanges();
            System.Console.WriteLine("Livro deletado com sucesso!");
        }

        public IList<Book> GetAll()
        {
            return context.Books.ToList();
        }

        public Book GetById(int entityId)
        {
            return context.Books.SingleOrDefault(x => x.Id == entityId);
        }

        public void Save(Book entity, int id)
        {
            var existingAuthor = context.Authors.SingleOrDefault(x => x.Id == id);
            if (existingAuthor != null)
            {
                entity.Author = existingAuthor;
                context.Books.Add(entity);
                context.SaveChanges();
                Console.WriteLine("Livro cadastrado com sucesso e vinculada ao autor!");
            }
            else
            {
                Console.WriteLine("Autor não encontrado. O livro não pode ser cadastrado!");
            }
        }

        public void Save(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}