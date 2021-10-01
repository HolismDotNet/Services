using Holism.Business;
using Holism.DataAccess;
using Holism.Services.DataAccess;
using Holism.Services.Models;
using System;

namespace Holism.Services.Business
{
    public class PostHtmlHtmlBusiness : Business<PostHtml, PostHtml>
    {
        protected override Repository<PostHtml> WriteRepository => Repository.PostHtml;

        protected override ReadRepository<PostHtml> ReadRepository => Repository.PostHtml;

        public void Create(long postId, string html)
        {
            var postHtml = new PostHtml();
            postHtml.Id = postId;
            postHtml.Html = html;
            Create(postHtml);
        }
    }
}
