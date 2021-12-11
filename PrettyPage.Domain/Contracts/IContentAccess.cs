using System;
using System.Collections.Generic;
using System.Text;
using PrettyPage.Domain.Entities;

namespace PrettyPage.Domain.Contracts
{
    public interface IContentAccessRepository
    {
        HomePage GetHomePageData();
    }
}
