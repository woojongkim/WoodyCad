using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodyCad
{
    public class Drawing
    {
        [JsonProperty("drawingId")]
        public string DrawingId { get; set; }
        
        [JsonProperty("drawingNo")]
        public string DrawingNo { get; set; }
        
        [JsonProperty("drawingName")]
        public string DrawingName { get; set; }
        
        [JsonProperty("version")]
        public string Version { get; set; }
        
        [JsonProperty("comment")]
        public string Comment { get; set; }
        
        [JsonProperty("drafter")]
        public string Drafter { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        public Drawing(string drawingId, string drawingNo, string drawingName, string version, string comment, string drafter, string modifiedDate)
        {
            DrawingId = drawingId;
            DrawingNo = drawingNo;
            DrawingName = drawingName;
            Version = version;
            Comment = comment;
            Drafter = drafter;
            ModifiedDate = modifiedDate;
        }

        public Drawing()
        {
        }
    }

    public class DrawingSearchDto
    {
        [JsonProperty("drawingNo")]
        public string DrawingNo { get; set; }

        [JsonProperty("drawingName")]
        public string DrawingName { get; set; }

        [JsonProperty("drafter")]
        public string Drafter { get; set; }

        [JsonProperty("startDate")]
        public String StartDate { get; set; }

        [JsonProperty("endDate")]
        public String EndDate { get; set; }

        public DrawingSearchDto(string drawingNo, string drawingName, string drafter, String startDate, String endDate)
        {
            DrawingNo = drawingNo;
            DrawingName = drawingName;
            Drafter = drafter;
            StartDate = startDate;
            EndDate = endDate;
        }

        public DrawingSearchDto()
        {
        }
    }

    public class DrawingUploadDto
    {
        [JsonProperty("drawingNo")]
        public string DrawingNo { get; set; }

        [JsonProperty("drawingName")]
        public string DrawingName { get; set; }

        [JsonProperty("drafter")]
        public string Drafter { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        public DrawingUploadDto(string drawingNo, string drawingName, string drafter, string comment, string fileName)
        {
            DrawingNo = drawingNo;
            DrawingName = drawingName;
            Drafter = drafter;
            Comment = comment;
            FileName = fileName;
        }
    }
}
