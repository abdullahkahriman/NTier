using NTier.Core;
using NTier.Data.Model.Entity;
using System;
using System.Collections.Generic;

namespace NTier.Data.Service
{
    public class BookService : Repository<Book>
    {
        public BookService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public Result<List<Book>> Get()
        {
            Result<List<Book>> result;

            try
            {
                var books = this.Get<Book>();
                result = new Result<List<Book>>(false, "", books);
            }
            catch (Exception ex)
            {
                result = new Result<List<Book>>(false, ex.Message, true);
            }

            return result;
        }
    }
}