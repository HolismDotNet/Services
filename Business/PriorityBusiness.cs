using Holism.Business;
using Holism.Services.DataAccess;
using Holism.Services.Models;

namespace Holism.Services.Business
{
    public class PriorityBusiness : EnumBusiness<Priority>
    {
        public override string ConnectionString =>
            Repository.Ticket.ConnectionString;
    }
}
