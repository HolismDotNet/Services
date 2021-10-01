using Holism.Business;
using Holism.DataAccess;
using Holism.Services.DataAccess;
using Holism.Services.Models;

namespace Holism.Services.Business
{
    public class AttachedFileBusiness : Business<AttachedFile, AttachedFile>
    {
        protected override Repository<AttachedFile> WriteRepository => Repository.AttachedFile;

        protected override ReadRepository<AttachedFile> ReadRepository => Repository.AttachedFile;

    }
}
