namespace ArabityAuth
{
    public class Tools
    {
        public Tools()
        {
            
        }

        #region Add Images

        public string AddImages(IFormFile imagefile, string username)
        {

            if (imagefile == null)
            { return "avatar.png" + username; }
            string imageUrl = imagefile.FileName;
            string uploads = Path.Combine(Environment.CurrentDirectory, "UsersImages");
            string path = Path.Combine(uploads, username + imageUrl);

            if (System.IO.File.Exists(imageUrl))
            {
                string temporary = Path.Combine(Environment.CurrentDirectory, "ImagePackups");
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
            string uploads = Path.Combine(Environment.CurrentDirectory, "AnswersImages");
            string path = Path.Combine(uploads, username + imageUrl);

            if (System.IO.File.Exists(imageUrl))
            {
                string temporary = Path.Combine(Environment.CurrentDirectory, "ImagePackups");
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
            string files = Path.Combine(Environment.CurrentDirectory, "Files");
            string path = Path.Combine(files, username + fileUrl);

            if (System.IO.File.Exists(fileUrl))
            {
                string temporary = Path.Combine(Environment.CurrentDirectory, "ImagePackups");
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

        public string AddVedios(IFormFile vediofile, string username)
        {

            if (vediofile == null)
            { return "Defult User Image" + username; }
            string vedioUrl = vediofile.FileName;
            string vedios = Path.Combine(Environment.CurrentDirectory, "Vedios");
            string path = Path.Combine(vedios, username + vedioUrl);

            if (System.IO.File.Exists(vedioUrl))
            {
                string temporary = Path.Combine(Environment.CurrentDirectory, "ImagePackups");
                File.Copy(path, temporary);
                string newFilePath = Path.Combine(path, username + vedioUrl);
                File.Move(temporary, newFilePath);
            }
            else
            { vediofile.CopyTo(new FileStream(path, FileMode.Create)); }


            return username + vedioUrl;
        }

        #endregion


        #region Update Images

        public string UpdateImages(IFormFile imagefile, string imagename)
        {
            string imageUrl = imagefile.FileName;
            string path = Path.Combine(Environment.CurrentDirectory, "UsersImages");
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
