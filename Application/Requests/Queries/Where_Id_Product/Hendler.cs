using Diplom.Application.Interfaces;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Requests.Queries.Where_Id_Product
{
    public partial class Where_Product
    {
        public class Hendler : IRequestHandler<Query, List_View_Model>

        {
            private readonly IDbContext db;
            public Hendler(IDbContext dbContext)
            {
                db = dbContext;
            }

            public async Task<List_View_Model> Handle(Query query, CancellationToken cancellationToken)
            {
                var entity = await db.Products.FirstOrDefaultAsync(u => u.ProductId == query.ProductId);
                return new List_View_Model { Products = entity };
            }
        }
    }
}
