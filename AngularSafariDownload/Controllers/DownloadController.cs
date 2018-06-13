namespace AngularSafariDownload.Controllers
{
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Web;
    using System.Web.Http;

    [RoutePrefix("api/download")]
    public class DownloadController : ApiController
    {
        const string Filename = "SafariDownloadProblem.pdf";
        
        [HttpPost]
        [Route()]
        public HttpResponseMessage GetDocumentContent()
        {
            var currentPath = HttpContext.Current.Server.MapPath("~/") + "SafariDownloadProblem.pdf";
            var document = File.ReadAllBytes(currentPath);
            var response = this.Request.CreateResponse(HttpStatusCode.OK, document);
            response.Content = new ByteArrayContent(document);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            response.Content.Headers.ContentDisposition =
                new ContentDispositionHeaderValue("attachment") { FileName = Filename };
            response.Content.Headers.ContentLength = document.Length;
            return response;
        }

        [HttpGet]
        [Route()]
        public HttpResponseMessage GetDocument()
        {
            var currentPath = HttpContext.Current.Server.MapPath("~/") + "SafariDownloadProblem.pdf";
            var document = File.ReadAllBytes(currentPath);
            var response = this.Request.CreateResponse(HttpStatusCode.OK, document);
            response.Content = new ByteArrayContent(document);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            response.Content.Headers.ContentDisposition =
                new ContentDispositionHeaderValue("attachment") { FileName = Filename };
            response.Content.Headers.ContentLength = document.Length;
            return response;
        }

    }
}
