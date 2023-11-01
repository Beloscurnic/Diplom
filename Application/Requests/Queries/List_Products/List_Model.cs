using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Requests.Queries.List_Products
{

        public class List_Model
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public decimal StandardCost { get; set; }
        }
    
}
