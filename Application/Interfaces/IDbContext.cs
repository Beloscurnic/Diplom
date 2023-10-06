using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
   public interface IDbContext
    {

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
