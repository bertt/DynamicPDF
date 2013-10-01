using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PdfSample
{
    public class TestController:ApiController
    {
        public HttpResponseMessage GetTest(string author)
        {
            var person=new Person{Name=author};
            return Request.CreateResponse(HttpStatusCode.OK,person);
        }
    }
}