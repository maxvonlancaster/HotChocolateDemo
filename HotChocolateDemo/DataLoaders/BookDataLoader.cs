using HotChocolateDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace HotChocolateDemo.DataLoaders
{
    public class BookDataLoader : BatchDataLoader<int, Book>
    {
        private DemoContext _demoContext;

        public BookDataLoader(
            IBatchScheduler batchScheduler,
            DemoContext demoContext,
            DataLoaderOptions? options = null
            )
            : base(batchScheduler, options)
        {
            _demoContext = demoContext;
        }

        //private DemoContext _demoContext;

        //public BookDataLoader(DemoContext demoContext)
        //{
        //    _demoContext = demoContext;
        //}

        protected override async Task<IReadOnlyDictionary<int, Book>> LoadBatchAsync(
            IReadOnlyList<int> keys, 
            CancellationToken cancellationToken)
        {
            return await _demoContext.Books
                .Where(x => keys.Contains(x.Id))
                .ToDictionaryAsync(x => x.Id, cancellationToken);
        }
    }
}
