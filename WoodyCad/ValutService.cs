using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using acadApplication = Autodesk.AutoCAD.ApplicationServices.Core.Application;

namespace WoodyCad
{
    public class VaultService
    {
        private static VaultService Instance;

        private ApiService ApiService;

        public static VaultService GetInstance()
        {
            if(Instance == null)
                Instance = new VaultService();

            return Instance;
        }


        private VaultService()
        {
            ApiService = new EKIApiService();
        }

        public void CheckIn(string filePath, DrawingUploadDto uploadDrawing)
        {
            object obj = Application.GetSystemVariable("DBMOD");

            LoggerUtils.Info("Upload drwing : " + uploadDrawing.ToString());
            LoggerUtils.Debug(filePath);
            LoggerUtils.Debug(System.Convert.ToInt16(obj).ToString());
            
            Document acDoc = Application.DocumentManager.MdiActiveDocument;

            string tempFilePath = ApiService.TargetPath + "\\temp.dwg";

            using (DocumentLock documentLock = acDoc.LockDocument())
            {

                //acDoc.Database.SaveAs(acDoc.Name, true, DwgVersion.Current, acDoc.Database.SecurityParameters);
                File.Copy(acDoc.Name, tempFilePath, true);
                
                FileStream fileStream = new FileStream(tempFilePath, FileMode.Open, FileAccess.Read);
                byte[] fileBytes = new byte[fileStream.Length];
                fileStream.Read(fileBytes, 0, fileBytes.Length);
                fileStream.Close();

                //acadApplication.DocumentManager.Open(filePath, false);


                ApiService.CheckIn(fileBytes, uploadDrawing);
            }
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

        public Drawing OpenDrawing(Drawing drawing, Boolean checkout)
        {
            // 문자열의 경로로 디렉토리가 존재하는지 확인
            if (!Directory.Exists(ApiService.TargetPath))
            {
                // 디렉토리가 존재하지 않으면 디렉토리를 생성
                Directory.CreateDirectory(ApiService.TargetPath);
            }

            string localFilePath = ApiService.TargetPath + drawing.DrawingNo + "_" + drawing.DrawingName + ".dwg";

            // TO-DO: 이미 파일이 존재하고, Open한 상태이면 alert 발생
            foreach(Document doc in acadApplication.DocumentManager)
            {
                if(doc.Name.Equals(localFilePath))
                {
                    LoggerUtils.Alert("File is already opened.");
                    return null;
                }
            }

            // 파일이 존재하는지 확인하여 존재하면 삭제
            if (File.Exists(localFilePath))
            {
                File.Delete(localFilePath);
            }

            HttpWebResponse response = ApiService.DownloadDrawing(drawing.DrawingId, checkout);

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

        internal List<Drawing> FindRevisions(string drawingId)
        {
            return ApiService.FindRevisons(drawingId);
        }
    }
}
