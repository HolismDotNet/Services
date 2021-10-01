using Holism.Business;
using Holism.Services.DataAccess;
using Holism.Services.Models;

namespace Holism.Services.Business
{
    public class StateBusiness : EnumBusiness<State>
    {
        public override string ConnectionString =>
            Repository.Ticket.ConnectionString;
    }
}
