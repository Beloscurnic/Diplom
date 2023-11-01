using Application.Requests.Queries.List_Products;
using Application.Requests.Queries.Full_List_Category;
using Application.Requests.Queries.Where_Id_Product;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Application.Requests.Queries.Join_Product_Category;
using Application.Requests.Queries.Join_Where_Product_Category;
using System.Web;
using Application.Requests.Queries.Join_Product_Category_Model;

namespace WebAPI.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/{version:apiVersion}/[controller]")]
    public class HomeController : Controller
    {
        private readonly SQL_DbContext _db;
        private IMediator _mediator;
        protected IMediator Mediator =>
            _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        public HomeController(SQL_DbContext db) { _db = db; }


        [HttpGet("List_Products")]
        [ProducesResponseType(typeof(List_View_Model1), 200)]
        public async Task<ActionResult<List_View_Model1>> GetProducts2()
        {
            var query = new Query();
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("Full_List_Category")]
        [ProducesResponseType(typeof(List_Full_Category.List_View_Model), 200)]
        public async Task<ActionResult<List_Full_Category.List_View_Model>> FullCategorys()
        {
            var query = new List_Full_Category.Query();
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("Full_List_Products")]
        public async Task<ActionResult<Application.Requests.Queries.Full_List_Products.List_Full_Products>> GetFullProducts()
        {
            var query = new Application.Requests.Queries.Full_List_Products.List_Full_Products.Query();
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("Products/{productid}")]
        public async Task<ActionResult<Where_Product>> GetProduct(int productid)
        {
            var query = new Where_Product.Query()
            {
                ProductId = productid
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("Join_Product_Category")]
        public async Task<ActionResult<Join_Product_Category.List_View_Model3>> Join_Product_Category()
        {
            var query = new Join_Product_Category.Query();
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("Join_Where_Product_Category/{color}")]
        public async Task<ActionResult<Join_Where_Product_Category.List_View_Model4>> Join_Where_Product_Category(string color)
        {
            var query = new Join_Where_Product_Category.Query() { Color=color};
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("Join_product_category_model")]
        public async Task<ActionResult<Join_Product_Category_Model.List_View_Model5>> Join_product_category_Model()
        {
            var query = new Join_Product_Category_Model.Query();
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

    }
}
