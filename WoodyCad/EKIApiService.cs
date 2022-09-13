using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
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

        public override void CheckIn(byte[] fileData, DrawingUploadDto UploadDrawing)
        {
           

            string url = "http://localhost:8080/uploadFile";
            string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "multipart/form-data; boundary=" + boundary;
            request.Method = "POST";

            Stream requestStream = request.GetRequestStream();

            ByteBuider byteBuider = new ByteBuider();

            byteBuider.WriteLine($"--{boundary}");
            byteBuider.WriteLine($"Content-Disposition: form-data; name=\"file\"; filename=\"{UploadDrawing.FileName}\"");
            byteBuider.WriteLine($"Content-Type: form-data\r\n");
            byteBuider.Write(fileData);
            byteBuider.WriteLine($"\r\n");
            byteBuider.WriteLine($"--{boundary}");
            byteBuider.WriteLine($"Content-Disposition: form-data; name=\"data\"");
            byteBuider.WriteLine($"Content-Type: application/json\r\n");
            byteBuider.WriteLine($"{{\"drawingNo\":\"{UploadDrawing.DrawingNo}\", \"drawingName\":\"{UploadDrawing.DrawingName}\", \"drafter\":\"{UploadDrawing.Drafter}\",\"test\":1}}");
            byteBuider.WriteLine($"--{boundary}--");


            //String test = $"--{boundary}\r\nContent-Disposition: form-data; name=\"file\"; filename=\"{fileName}\"\r\nContent-Type: form-data\r\n\r\nHELLO\r\n--{boundary}\r\nContent-Disposition: form-data; name=\"data\"\r\nContent-Type: application/json\r\n\r\n{{\"drawingNo\":\"1234\", \"drawingName\":\"MAP 2 GLOBE\", \"drafter\":\"woody\",\"test\":1}}\r\n--{boundary}--\r\n";
            //byte[] bytes = System.Text.Encoding.UTF8.GetBytes(test);

            requestStream.Write(byteBuider.Result, 0, byteBuider.Result.Length);
            requestStream.Close();

            WebResponse webResponse = request.GetResponse();
            Stream stream = webResponse.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string response = reader.ReadToEnd();

            LoggerUtils.Debug(response);
        }

        public override HttpWebResponse DownloadDrawing(string drawingId, bool checkout)
        {
            string url;
            if (checkout)
                url = Uri + "checkout/" + drawingId;
            else
                url = Uri + "downloadFile/" + drawingId;

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

        public override List<Drawing> FindRevisons(string drawingId)
        {
            List<Drawing> drawings = null;

            string url = Uri + "drawing/list/"+drawingId;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

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
