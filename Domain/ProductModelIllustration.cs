using System;
using System.Collections.Generic;

#nullable disable

namespace Diplom.Domain
{
    public partial class ProductModelIllustration
    {
        public int ProductModelId { get; set; }
        public int IllustrationId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Illustration Illustration { get; set; }
        public virtual ProductModel ProductModel { get; set; }
    }
}
