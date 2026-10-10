using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace WebApplication_Templates.Helpers.File
{
    public class FileHelper : IFileHelper
    {
        IWebHostEnvironment _webHostEnvironment;
        private string folderName;

        public FileHelper(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public string OldImageName { get; private set; }

        string IFileHelper.SaveDoc(IFormFile File, string folderName, string OldImageName)
        {
            string FinalName;

            if (File != null)
            {
                List<string> allowedExtensions = new List<string>
                {
                    ".pdf", ".docx", ".doc"
                };

                var rootPath = Path.Combine(
                    _webHostEnvironment.WebRootPath,
                    folderName
                );

                if (!Directory.Exists(rootPath))
                {
                    Directory.CreateDirectory(rootPath);
                }

                FileInfo fileInfo = new FileInfo(File.FileName);

                var newName =
                    Guid.NewGuid().ToString() + fileInfo.Extension;

                if (allowedExtensions.Contains(fileInfo.Extension))
                {
                    var fullPath = Path.Combine(rootPath, newName);

                    using (var stream = new FileStream(
                        fullPath,
                        FileMode.Create))
                    {
                        File.CopyTo(stream);
                    }

                    FinalName = $"/{folderName}/{newName}";
                }
                else
                {
                    FinalName = "Error";
                }
            }
            else
            {
                return OldImageName;
            }

            return FinalName;
        }

        string IFileHelper.SaveImge(IFormFile File, string foledrName, string OldmageName)
        {
            string FinalName;

            if (File != null)
            {
                List<string> allowedExtensions = new List<string>
                {
                    ".png", ".jpeg", ".jpg", ".gif"
                };

                
                var rootPath = Path.Combine(
                    _webHostEnvironment.WebRootPath,
                    foledrName
                );

                if (!Directory.Exists(rootPath))
                {
                    Directory.CreateDirectory(rootPath);
                }

                FileInfo fileInfo = new FileInfo(File.FileName);

                var newName =
                    Guid.NewGuid().ToString() + fileInfo.Extension;

                if (allowedExtensions.Contains(fileInfo.Extension))
                {
                    var fullPath = Path.Combine(rootPath, newName);

                    using (var stream = new FileStream(
                        fullPath,
                        FileMode.Create))
                    {
                        File.CopyTo(stream);
                    }

                    FinalName = $"/{foledrName}/{newName}";
                }
                else
                {
                    FinalName = "Error";
                }
            }
            else
            {
                
                return OldmageName;
            }

            return FinalName;
        }
    }
}