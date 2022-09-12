using Autodesk.AutoCAD.ApplicationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WoodyCad
{
    public class ValutService
    {
        private ApiService ApiService;

        public ValutService()
        {
            ApiService = new EKIApiService();
        }

        public void CheckIn(Drawing UploadDrawing)
        {
            throw new NotImplementedException();
        }

        public Drawing CheckOut(Drawing drawing)
        {
            // 문자열의 경로로 디렉토리가 존재하는지 확인
            if (!Directory.Exists(ApiService.TargetPath))
            {
                // 디렉토리가 존재하지 않으면 디렉토리를 생성
                Directory.CreateDirectory(ApiService.TargetPath);
            }

            string localFilePath = ApiService.TargetPath + "co_"+drawing.DrawingNo+"_"+drawing.DrawingName + ".dwg";

            // TO-DO: 이미 파일이 존재하고, Open한 상태이면 alert 발생

            // 파일이 존재하는지 확인하여 존재하면 삭제
            if (File.Exists(localFilePath))
            {
                File.Delete(localFilePath);
            }

            HttpWebResponse response = ApiService.CheckOut(drawing.DrawingId);

            Stream resStream = response.GetResponseStream();
            int bytesProcessed = 0;

            // Create the local file
            Stream localStream = File.Create(localFilePath);

            // Allocate a 1k buffer
            byte[] buffer = new byte[1024];
            int bytesRead;

            do
            {
                // Read data (up to 1k) from the stream
                bytesRead = resStream.Read(buffer, 0, buffer.Length);

                // Write the data to the local file
                localStream.Write(buffer, 0, bytesRead);

                // Increment total bytes processed
                bytesProcessed += bytesRead;
            } while (bytesRead > 0);

            localStream.Close();

            Application.DocumentManager.Open(localFilePath, false);


            return drawing;
        }

        public Drawing CheckOut(string DrawingId)
        {
            Drawing drawing = ApiService.GetDrawing(DrawingId);
            return CheckOut(drawing);
        }

        public List<Drawing> FindDrawing(DrawingSearchDto query)
        {
            List<Drawing> drawingList = ApiService.FindDrawing(query);


            return drawingList;
        }

        public Drawing GetDrawing(long DrawingId)
        {
            throw new NotImplementedException();
        }

        public List<Drawing> ListDrawing(Drawing searchDrawing)
        {
            throw new NotImplementedException();
        }
    }
}
