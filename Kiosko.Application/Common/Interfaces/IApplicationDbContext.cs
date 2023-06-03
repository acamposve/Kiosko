using Kiosko.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {



        DbSet<CompanyActivity> CompanyActivities { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
