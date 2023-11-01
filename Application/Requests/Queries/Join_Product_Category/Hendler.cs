using Diplom.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Requests.Queries.Join_Product_Category
{
    public partial class Join_Product_Category
    {
        public class Hendler : IRequestHandler<Query, List_View_Model3>

        {
            private readonly IDbContext db;
            public Hendler(IDbContext dbContext)
            {
                db = dbContext;
            }

            public async Task<List_View_Model3> Handle(Query query, CancellationToken cancellationToken)
            {
                                var entity = await db.Products
                    .Join(db.ProductCategories,
                        product => product.ProductCategoryId,
                        category => category.ProductCategoryId,
                        (product, category) => new Join_product_category
                        {
                            ProductId = product.ProductId,
                            Name = product.Name,
                            ProductNumber = product.ProductNumber,
                            Color = product.Color,
                            StandardCost = product.StandardCost,
                            ListPrice = product.ListPrice,
                            Size = product.Size,
                            Weight = product.Weight,
                            SellStartDate = product.SellStartDate,
                            SellEndDate = product.SellEndDate,
                            DiscontinuedDate = product.DiscontinuedDate,
                            ThumbNailPhoto = product.ThumbNailPhoto,
                            ThumbnailPhotoFileName = product.ThumbnailPhotoFileName,
                            Rowguid = product.Rowguid,
                            ModifiedDate = product.ModifiedDate,
                            ProductCategoryId = category.ProductCategoryId,
                            Category_Name = category.Name,
                            ParentProductCategoryId = category.ParentProductCategoryId,
                            Category_Rowguid = category.Rowguid,
                            Category_ModifiedDate = category.ModifiedDate
                        }).ToListAsync(cancellationToken);

                return new List_View_Model3 { Join_Product_Categories = entity };
            }
        }

        public class List_View_Model3
        {
            public IList<Join_product_category> Join_Product_Categories { get; set; }
        }

        public class Query : IRequest<List_View_Model3>
        {

        }

        public class Join_product_category
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public string ProductNumber { get; set; }
            public string Color { get; set; }
            public decimal StandardCost { get; set; }
            public decimal ListPrice { get; set; }
            public string Size { get; set; }
            public decimal? Weight { get; set; }
            public int? ProductCategoryId { get; set; }
            public int? ProductModelId { get; set; }
            public DateTime SellStartDate { get; set; }
            public DateTime? SellEndDate { get; set; }
            public DateTime? DiscontinuedDate { get; set; }
            public byte[] ThumbNailPhoto { get; set; }
            public string ThumbnailPhotoFileName { get; set; }
            public Guid Rowguid { get; set; }
            public DateTime ModifiedDate { get; set; }
            public int? ParentProductCategoryId { get; set; }
            public string Category_Name { get; set; }
            public Guid Category_Rowguid { get; set; }
            public DateTime Category_ModifiedDate { get; set; }
        }
    }
}
