using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
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

        public abstract void CheckIn(byte[] fileData, DrawingUploadDto UploadDrawing);

        public abstract List<Drawing> FindDrawing(DrawingSearchDto query);
        public abstract HttpWebResponse DownloadDrawing(string drawingId, bool checkout);
        public abstract List<Drawing> FindRevisons(string drawingId);
    }
}
