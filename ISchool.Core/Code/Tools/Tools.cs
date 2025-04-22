namespace ArabityAuth
{
    public class Tools
    {

        #region Dependancey injuction

        private Microsoft.AspNetCore.Hosting.IHostingEnvironment Environment;

        public Tools(Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment)
        {
            Environment = _environment;
        }

        #endregion



        #region Add Images

        public string AddImages(IFormFile imagefile, string username)
        {

            if (imagefile == null)
            { return "avatar.png" + username; }
            string imageUrl = imagefile.FileName;
            string uploads = Path.Combine(Environment.WebRootPath, "UsersImages");
            string path = Path.Combine(uploads, username + imageUrl);

            if (System.IO.File.Exists(imageUrl))
            {
                string temporary = Path.Combine(Environment.WebRootPath, "ImagePackups");
                File.Copy(path, temporary);
                string newFilePath = Path.Combine(path, username + imageUrl);
                File.Move(temporary, newFilePath);
            }
            else
            { imagefile.CopyTo(new FileStream(path, FileMode.Create)); }


            return username + imageUrl;
        }

        #endregion


        #region Add Answers Images

        public string AddAnswersImages(IFormFile imagefile, string username)
        {

            if (imagefile == null)
            { return "avatar.png" + username; }
            string imageUrl = imagefile.FileName;
            string uploads = Path.Combine(Environment.WebRootPath, "AnswersImages");
            string path = Path.Combine(uploads, username + imageUrl);

            if (System.IO.File.Exists(imageUrl))
            {
                string temporary = Path.Combine(Environment.WebRootPath, "ImagePackups");
                File.Copy(path, temporary);
                string newFilePath = Path.Combine(path, username + imageUrl);
                File.Move(temporary, newFilePath);
            }
            else
            { imagefile.CopyTo(new FileStream(path, FileMode.Create)); }


            return username + imageUrl;
        }

        #endregion


        #region Add Tasks

        public string AddTasks(IFormFile taskFile, string username)
        {

            if (taskFile == null)
            { return "Defult File" + username; }
            string fileUrl = taskFile.FileName;
            string files = Path.Combine(Environment.WebRootPath, "Files");
            string path = Path.Combine(files, username + fileUrl);

            if (System.IO.File.Exists(fileUrl))
            {
                string temporary = Path.Combine(Environment.WebRootPath, "ImagePackups");
                File.Copy(path, temporary);
                string newFilePath = Path.Combine(path, username + fileUrl);
                File.Move(temporary, newFilePath);
            }
            else
            { taskFile.CopyTo(new FileStream(path, FileMode.Create)); }


            return username + fileUrl;
        }

        #endregion


        #region Add Vedios

        public string AddVedios(IFormFile vediofile, string phone, string title)
        {

            if (vediofile == null)
            { return "Defult User Image" + phone; }
            string vedioUrl = vediofile.FileName;
            string vedios = Path.Combine(Environment.WebRootPath, "Vedios");
            string path = Path.Combine(vedios, phone + title + vedioUrl);

            if (System.IO.File.Exists(vedioUrl))
            {
                string temporary = Path.Combine(Environment.WebRootPath, "ImagePackups");
                File.Copy(path, temporary);
                string newFilePath = Path.Combine(path, phone + title + vedioUrl);
                File.Move(temporary, newFilePath);
            }
            else
            { vediofile.CopyTo(new FileStream(path, FileMode.Create)); }


            return phone + title + vedioUrl;
        }

        #endregion


        #region Update Images

        public string UpdateImages(IFormFile imagefile, string imagename)
        {
            string imageUrl = imagefile.FileName;
            string path = Path.Combine(Environment.WebRootPath, "UsersImages");
            if (System.IO.File.Exists(imagename))
            {
                System.IO.File.Delete(imagename);
                imagefile.CopyTo(new FileStream(path, FileMode.Create));
            }


            return imageUrl;
        }

        #endregion


    }
}
