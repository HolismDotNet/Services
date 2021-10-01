using Holism.Services.Models;
using Holism.DataAccess;

namespace Holism.Services.DataAccess
{
    public class Repository
    {
        public static Repository<Ticket> Ticket
        {
            get
            {
                return new Holism.DataAccess.Repository<Ticket
                >(new ServicesContext());
            }
        }

        public static Repository<Post> Post
        {
            get
            {
                return new Holism.DataAccess.Repository<Post
                >(new ServicesContext());
            }
        }

        public static Repository<PostHtml> PostHtml
        {
            get
            {
                return new Holism.DataAccess.Repository<PostHtml
                >(new ServicesContext());
            }
        }

        public static Repository<AttachedFile> AttachedFile
        {
            get
            {
                return new Holism.DataAccess.Repository<AttachedFile
                >(new ServicesContext());
            }
        }

        public static Repository<TicketView> TicketView
        {
            get
            {
                return new Holism.DataAccess.Repository<TicketView
                >(new ServicesContext());
            }
        }
    }
}
