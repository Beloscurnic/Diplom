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

namespace Application.Requests.Queries.Full_List_Products
{
    public partial class List_Full_Products
    {
        public class Hendler: IRequestHandler<Query,List_View_Model>
            
        {
            private readonly IDbContext db;
            public Hendler(IDbContext dbContext)
            {
                db = dbContext;
            }

            public async Task<List_View_Model> Handle (Query query,CancellationToken cancellationToken)
            {
                var entity = await db.Products.ToListAsync (cancellationToken);
                return new List_View_Model { Products = entity} ;
            }
        }

        public class List_View_Model
        {
            public IList<Product> Products { get; set; }
        }

        public class Query : IRequest<List_View_Model>
        {

        }
    }
}
