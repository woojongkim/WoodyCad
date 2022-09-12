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
        
        [JsonProperty("revision")]
        public string Revision { get; set; }
        
        [JsonProperty("comment")]
        public string Comment { get; set; }
        
        [JsonProperty("drafter")]
        public string Drafter { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        public Drawing(string drawingId, string drawingNo, string drawingName, string revision, string comment, string drafter, string createdDate)
        {
            DrawingId = drawingId;
            DrawingNo = drawingNo;
            DrawingName = drawingName;
            Revision = revision;
            Comment = comment;
            Drafter = drafter;
            CreatedDate = createdDate;
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
}
