using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Media;

namespace WoodyCad
{
    public class EKIApiService : ApiService
    {
        public EKIApiService()
        {
            TargetPath = "C:\\EKI\\Temp\\";
            Uri = "http://localhost:8080/";
        }

        public override void CheckIn(Drawing UploadDrawing)
        {
            throw new NotImplementedException();
        }

        public override HttpWebResponse CheckOut(string DrawingId)
        {
            string url = Uri + "downloadFile/" + DrawingId;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            return response;
        }

        public override Drawing GetDrawing(string DrawingId)
        {
            Drawing drawing = new Drawing();
            drawing.DrawingId = DrawingId;
            drawing.DrawingNo = "testNo";

            return drawing;
        }

        public override List<Drawing> FindDrawing(DrawingSearchDto query)
        {
            List<Drawing> drawings = null;

            JObject jObject = JObject.FromObject(query);

            // iterate jObject and make query string
            StringBuilder sb = new StringBuilder();
            foreach (var item in jObject)
            {
                if (item.Value.ToString() != "")
                    sb.Append(item.Key + "=" + item.Value + "&");
            }

            // url encode
            string queryString = sb.ToString();
            
            string url = Uri + "drawing";
            string requestUriString = url + "?" + queryString;

            LoggerUtils.Debug(requestUriString);

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(requestUriString);

            using (var response = req.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);

                    string data = reader.ReadToEnd();

                    LoggerUtils.Debug(data);

                    // parsing json data and make list of drawing
                    drawings = JsonConvert.DeserializeObject<List<Drawing>>(data);
                    
                }
            }




            return drawings;
        }
    }

}
