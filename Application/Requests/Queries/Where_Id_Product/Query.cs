using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Requests.Queries.Where_Id_Product
{
    public partial class Where_Product
    {
        public class Query : IRequest<List_View_Model>
        {
            public int ProductId { get; set; }
        }
    }
}
