using System.Linq;
using IRunes.App.Extensions;
using IRunes.Data;
using SIS.HTTP.Requests.Contracts;
using SIS.HTTP.Responses.Contracts;

namespace IRunes.App.Controllers
{
    public class AlbumsController : BaseController
    {
        public IHttpResponse All(IHttpRequest httpRequest)
        {
            using (var context = new RunesDbContext())
            {
                this.ViewData["Albums"] =
                    context.Albums.Select(album => album.ToHtmlAll()).ToList();

                return this.View();
            }
        }
        public IHttpResponse Create(IHttpRequest httpRequest)
        {
            return this.View();
        }
        public IHttpResponse Details(IHttpRequest httpRequest)
        {

        }
    }
}
