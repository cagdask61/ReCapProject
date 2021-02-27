using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.FileManager
{
    public interface IFileManager
    {
        string AddImage(IFormFile addFile);
        void DeleteImage(string pathDelete);
        string NewPath(IFormFile newPathFile);
        string UpdateImage(string sourcePathUpdate,IFormFile updateFile);
    }
}
