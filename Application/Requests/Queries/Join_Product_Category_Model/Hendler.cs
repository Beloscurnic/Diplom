using Diplom.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Requests.Queries.Join_Product_Category_Model
{
    public partial class Join_Product_Category_Model
    {
        public class Hendler : IRequestHandler<Query, List_View_Model5>

        {
            private readonly IDbContext db;
            public Hendler(IDbContext dbContext)
            {
                db = dbContext;
            }

            public async Task<List_View_Model5> Handle(Query query, CancellationToken cancellationToken)
            {
                var entity = await db.Products
                  .Join(
                      db.ProductModels,
                      product => product.ProductModelId,
                      productModel => productModel.ProductModelId,
                      (product, productModel) => new { Product = product, ProductModel = productModel }
                  )
                  .Join(
                      db.ProductCategories,
                      combined => combined.Product.ProductCategoryId,
                      productCategory => productCategory.ProductCategoryId,
                      (combined, productCategory) => new Join_product_category_model
                      {
                          ProductId = combined.Product.ProductId,
                          Name = combined.Product.Name,
                          ProductNumber = combined.Product.ProductNumber,
                          Color = combined.Product.Color,
                          StandardCost = combined.Product.StandardCost,
                          ListPrice = combined.Product.ListPrice,
                          Size = combined.Product.Size,
                          Weight = combined.Product.Weight,
                          SellStartDate = combined.Product.SellStartDate,
                          SellEndDate = combined.Product.SellEndDate,
                          DiscontinuedDate = combined.Product.DiscontinuedDate,
                          ThumbNailPhoto = combined.Product.ThumbNailPhoto,
                          ThumbnailPhotoFileName = combined.Product.ThumbnailPhotoFileName,
                          Rowguid = combined.Product.Rowguid,
                          ModifiedDate = combined.Product.ModifiedDate,
                          ProductModelId = combined.ProductModel.ProductModelId,
                          Model_Name = combined.ProductModel.Name,
                          CatalogDescription = combined.ProductModel.CatalogDescription,
                          Model_Rowguid = combined.ProductModel.Rowguid,
                          Model_ModifiedDate = combined.ProductModel.ModifiedDate,
                          ProductCategoryId = productCategory.ProductCategoryId,
                          ParentProductCategoryId = productCategory.ParentProductCategoryId,
                          Category_Name = productCategory.Name,
                          Category_Rowguid = productCategory.Rowguid,
                          Category_ModifiedDate = productCategory.ModifiedDate
                      }
                  ).ToListAsync(cancellationToken);

                return new List_View_Model5 { Join_product_category_models = entity };
            }
        }

        public class List_View_Model5
        {
            public IList<Join_product_category_model> Join_product_category_models { get; set; }
        }

        public class Query : IRequest<List_View_Model5>
        {

        }

        public class Join_product_category_model
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
            public string Model_Name { get; set; }
            public string CatalogDescription { get; set; }
            public Guid Model_Rowguid { get; set; }
            public DateTime Model_ModifiedDate { get; set; }


        }
    }
}
