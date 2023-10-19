using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapi.Models.Response
{
    public class ImageGenResponse
    {
        public long Created { get; set; }
        public List<Link>? Data { get; set; }
    }
    public class Link
    {
        public string? Url { get; set; }
    }
}
