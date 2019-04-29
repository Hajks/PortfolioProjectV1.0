using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PortfolioProjectV1._0.Models;

namespace PortfolioProjectV1._0.Infrastructure.Interfaces
{
    public interface ICharacterProvider
    {
        Characters GetDetailsFromApi();
    }
}