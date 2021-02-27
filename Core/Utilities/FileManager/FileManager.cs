using Core.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Text;

namespace Core.Utilities.FileManager
{
    public class FileManager : IFileManager
    {
        public  string AddImage(IFormFile addFile)
        {
            var sourcepath = Path.GetTempFileName();
            if (addFile.Length > 0)
            {
                using (var stream = new FileStream(sourcepath,FileMode.Create))
                {
                    addFile.CopyTo(stream);
                }
            }
            var result = NewPath(addFile);
            File.Move(sourcepath,result);
            return result;
        }

        public void DeleteImage(string pathDelete)
        {
            File.Delete(pathDelete);
        }

        public  string NewPath(IFormFile newPathFile)
        {
            FileInfo fileinfo = new FileInfo(newPathFile.FileName);
            string fileExtension = fileinfo.Extension;

            string pathfile = Environment.CurrentDirectory + @"\wwwroot\CarImages";
            var newpathfile = Guid.NewGuid().ToString() + "C" + DateTime.Now.Day + "A" + DateTime.Now.Month + "R" + DateTime.Now.Year + fileExtension;

            string result = $@"{pathfile}\{newPathFile}";
            return result;

        }

        public  string UpdateImage(string sourcePathUpdate, IFormFile updateFile)
        {
            var result = NewPath(updateFile);
            if (sourcePathUpdate.Length > 0)
            {
                using (var stream = new FileStream(result,FileMode.Create))
                {
                    updateFile.CopyTo(stream);
                }
            }
            File.Delete(sourcePathUpdate);
            return result;
        }
    }
}
