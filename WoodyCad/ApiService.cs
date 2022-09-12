using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WoodyCad
{
    public abstract class ApiService
    {
        public string TargetPath { get; set; }
        public string Uri { get; set; }

        public abstract Drawing GetDrawing(string DrawingId);

        public abstract void CheckIn(Drawing UploadDrawing);

        public abstract HttpWebResponse CheckOut(string DrawingId);
        public abstract List<Drawing> FindDrawing(DrawingSearchDto query);
    }
}
