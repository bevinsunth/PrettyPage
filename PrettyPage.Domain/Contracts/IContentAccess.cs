using System;
using System.Collections.Generic;
using System.Text;
using PrettyPage.Entities.Models;

namespace PrettyPage.Domain.Contracts
{
    public interface IContentAccessRepository
    {
        HomePage GetHomePageData();
    }
}
