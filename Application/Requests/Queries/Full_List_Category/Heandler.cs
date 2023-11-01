using Diplom.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Requests.Queries.Full_List_Category
{
    public partial class List_Full_Category
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
                var entity = await db.ProductCategories.Select(u => new List_Model2
                {
                    ProductCategoryId = u.ProductCategoryId,
                    ParentProductCategoryId = u.ParentProductCategoryId,
                    Name = u.Name,
                    Rowguid = u.Rowguid,
                    ModifiedDate = u.ModifiedDate,
                }).ToListAsync(cancellationToken);
                return new List_View_Model { ProductCategoriess = entity };
            }
        }

        public class List_View_Model
        {
            public IList<List_Model2> ProductCategoriess { get; set; }
        }

        public class Query : IRequest<List_View_Model>
        {

        }

        public class List_Model2
        {
            public int ProductCategoryId { get; set; }
            public int? ParentProductCategoryId { get; set; }
            public string Name { get; set; }
            public Guid Rowguid { get; set; }
            public DateTime ModifiedDate { get; set; }
        }
    }
}
