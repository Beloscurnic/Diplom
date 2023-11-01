using Diplom.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Requests.Queries.List_Products
{

        public class Hendler : IRequestHandler<Query, List_View_Model1>
        {
            private readonly IDbContext DbContext;

            public Hendler(IDbContext dbContext)
            {
                DbContext = dbContext;
            }

            public async Task<List_View_Model1> Handle(Query request, CancellationToken cancellationToken)
            {
                var entity = await DbContext.Products.Select(p => new List_Model
                {
                  ProductId = p.ProductId,
                  Name = p.Name,
                  StandardCost = p.StandardCost
                }).ToListAsync(cancellationToken);
                return new List_View_Model1 { List_Models = entity };
            }
        
    }
}