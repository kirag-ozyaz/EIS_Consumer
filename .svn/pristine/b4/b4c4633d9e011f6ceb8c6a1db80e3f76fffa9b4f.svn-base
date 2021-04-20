using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace EIS
{
    /// <summary>
    /// Проверялка качалка базовая
    /// </summary>
    public abstract class ChekerDownloader
    {
        #region Members
        internal const string settingsUpdatesFile = "settingsUpdates.xml";
        internal string soursePath = string.Empty;
        internal string newVersion = string.Empty;
        internal string updateFileName = string.Empty;
        internal string updateArhivePath = string.Empty;
        #endregion
        public ChekerDownloader(string soursePath)
        {
            this.soursePath = soursePath;
            updateArhivePath = System.IO.Path.GetTempPath() + @"EISUpdateArhive\";
            OnlyDownload = false;
        }
        public ChekerDownloader(string soursePath, string updateArhivePath)
        {
            this.soursePath = soursePath;
            this.updateArhivePath = updateArhivePath;
            OnlyDownload = true;
        }
        #region Property
        /// <summary>
        /// Получает, устанавливает текущую версию ПО
        /// </summary>
        public Version CurrentVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// Получает, устанавливает путь для архива обновлений
        /// </summary>
        public string UpdateArhivePath
        {
            get
            {
                return updateArhivePath;
            }
            set { updateArhivePath = value; }
        }
        /// <summary>
        /// Получает, устанавливает флаг необходимости удаления архива после его распаковки
        /// </summary>
        public bool RemoveUpdateArhiveAfterExtract
        {
            get;
            set;
        }
        public bool OnlyDownload
        {
            get;
            set;
        }
        #endregion
        #region Methods
        //public bool DounloadsUpdates()
        //{
        //    List<string> updateList = GetUpdateList();
        //    foreach (string name in updateList)
        //    {
        //        DownloadUpdateArhive(name);
        //    }
        //    return updateList.Count > 0;
        //}
        public string PrepareUpdates()
        {
            List<string> updateList = GetUpdateList();
            //MessageBox.Show("getupdatelist " + updateList.Count.ToString());
            if (updateList.Count == 0) return string.Empty;            
            string extarctPath =  System.IO.Path.GetTempPath() + @"EISUpdate\";
            if (Directory.Exists(extarctPath))
            {
                Directory.Delete(extarctPath,true);
            }
            if (!OnlyDownload)
                Directory.CreateDirectory(extarctPath);
            foreach (string name in updateList)
            {
                if (DownloadUpdateArhive(name)&&!OnlyDownload)
                {
                    string update = updateArhivePath;
                    update = update[update.Length - 1] == Path.DirectorySeparatorChar ? update += name : update += Path.DirectorySeparatorChar + name;
                    Compress.DecompressToDirectory(update, extarctPath);
                    if (RemoveUpdateArhiveAfterExtract)
                        File.Delete(updateArhivePath);
                }
            }
            if (OnlyDownload)
            {
                DownloadUpdateArhive(settingsUpdatesFile);
            }
            if (Directory.Exists(extarctPath)&&Directory.GetFiles(extarctPath).Length > 0)
                return extarctPath;
            else return string.Empty;
        }
        protected virtual List<string> GetUpdateList()
        {
            return new List<string>();
        }
        /// <summary>
        /// Загрузить файл обновлений
        /// </summary>
        /// <returns></returns>
        protected virtual bool DownloadUpdateArhive(string fileName)
        {
            return false;
        }

        internal List<string> GetVersionsFile(string setFile)
        {
            List<string> fileList = new List<string>();
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            StreamReader stream = new StreamReader(setFile);
            string xml = stream.ReadToEnd();
            doc.LoadXml(xml);
            System.Xml.XmlNode files = doc.SelectSingleNode("UpdSetings").SelectSingleNode("Files");            

            foreach (System.Xml.XmlNode file in files.ChildNodes)
            {
                Version ver = new Version(file.Attributes["Version"].Value.ToString());
                string filename = file.Attributes["FileName"].Value.ToString();
                if (ver > CurrentVersion)
                {
                    fileList.Add(filename);
                    CurrentVersion = ver;
                }
            }
            stream.Close();
            return fileList;
        }
        #endregion

    }

    public class ChekerDownloaderFromFolder : ChekerDownloader
    {
        public ChekerDownloaderFromFolder(string soursePath)
            : base(soursePath)
        {
        }

        public ChekerDownloaderFromFolder(string soursePath, string updateArhivePath)
            : base(soursePath, updateArhivePath)
        {
        }
        protected override List<string> GetUpdateList()
        {
            string updateSetPath = soursePath;
            updateSetPath = updateSetPath[updateSetPath.Length - 1] == Path.DirectorySeparatorChar ? updateSetPath += settingsUpdatesFile : updateSetPath += Path.DirectorySeparatorChar + settingsUpdatesFile;
            if (File.Exists(updateSetPath))
            {
                return GetVersionsFile(updateSetPath);
            }
            return base.GetUpdateList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName">Имя копируемого файла</param>
        /// <returns></returns>
        protected override bool DownloadUpdateArhive(string fileName)
        {
            string updatePath = soursePath;
            updatePath = updatePath[updatePath.Length - 1] == Path.DirectorySeparatorChar ? updatePath += fileName : updatePath += Path.DirectorySeparatorChar + fileName;
            string update = updateArhivePath;
            if (!Directory.Exists(updateArhivePath))
            {
                Directory.CreateDirectory(updateArhivePath);
            }
            update = update[update.Length - 1] == Path.DirectorySeparatorChar ? update += fileName : update += Path.DirectorySeparatorChar + fileName;
            try
            {
                File.Copy(updatePath, update, true);
            }
            catch  /*(Exception ex)*/
            {
                return false;
            }
            return true;
        }
    }

    public class ChekerDownloaderFromFTP : ChekerDownloader
    {
        #region 
        #endregion
        #region
        public string FTPUser
        {
            get;
            set;
        }
        public string FTPPassword
        {
            get;
            set;
        }
        #endregion
        public ChekerDownloaderFromFTP(string soursePath)
            : base(soursePath)
        {
            FTPPassword = FTPUser = string.Empty;
        }

        public ChekerDownloaderFromFTP(string soursePath, string updateArhivePath)
            : base(soursePath, updateArhivePath)
        {
            FTPPassword = FTPUser = string.Empty;
        }

        protected override List<string> GetUpdateList()
        {
            List<string> res = new List<string>();
            string setDirPath = System.IO.Path.GetTempPath() + @"EISUpdate\";
            
            if (!Download(soursePath, settingsUpdatesFile, setDirPath, FTPUser, FTPPassword)) return base.GetUpdateList();
            
            string setPath = setDirPath[setDirPath.Length - 1] == Path.DirectorySeparatorChar ? setDirPath += settingsUpdatesFile : setDirPath += Path.DirectorySeparatorChar + settingsUpdatesFile;
            if (File.Exists(setPath))
            {
                res = GetVersionsFile(setPath);
                try
                {
                    File.Delete(setPath);
                    Directory.Delete(setDirPath);
                }
                catch { }
            }
            return res;
        }
        protected override bool DownloadUpdateArhive(string fileName)
        {
            if (!Directory.Exists(updateArhivePath))
            {
                Directory.CreateDirectory(updateArhivePath);
            }
            return Download(soursePath, fileName, updateArhivePath, FTPUser, FTPPassword);
        }
        // Функция закачки файла
        public static bool Download(string downloaduri, string filename, string dest, string login, string password)
        {
            try
            {
                //MessageBox.Show("begin download");
                // Создадим запрос для работы с ftp
                string path = downloaduri;
                path = path[path.Length - 1] == Path.DirectorySeparatorChar ? path += filename : path += Path.DirectorySeparatorChar + filename;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(path);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.KeepAlive = true;
                request.UsePassive = true;
                request.UseBinary = true;
                request.Credentials = new NetworkCredential(login, password);
                //MessageBox.Show("1");
                // и объект ответа сервера
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    // Открываем поток для получения файла
                    using (Stream stream = response.GetResponseStream())
                    {
                        string destPath = dest;
                        destPath = destPath[destPath.Length - 1] == Path.DirectorySeparatorChar ? destPath += filename : destPath += Path.DirectorySeparatorChar + filename;
                        // и поток для записи в файл
                        if (!Directory.Exists(dest))
                            Directory.CreateDirectory(dest);

                        FileStream file = File.Create(destPath);
                        byte[] buffer = new byte[32 * 1024];
                        int read;
                        //MessageBox.Show("2");
                        while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                            file.Write(buffer, 0, read);

                        file.Close();
                        //MessageBox.Show("3");
                        /*using (StreamReader reader = new StreamReader(stream))
                        {
                            string destPath = dest;
                            destPath = destPath[destPath.Length - 1] == Path.DirectorySeparatorChar ? destPath += filename : destPath += Path.DirectorySeparatorChar + filename;
                            // и поток для записи в файл
                            if (!Directory.Exists(dest))
                                Directory.CreateDirectory(dest);
                            List<byte> list = new List<byte>();

                            using (StreamWriter destination = new StreamWriter(destPath, false))
                            {
                                destination.Write(reader.ReadToEnd());
                                destination.Flush();
                            }
                        }*/
                        //int b;
                        //while ((b = stream.ReadByte()) != -1)
                        //    list.Add((byte)b);
                        //File.WriteAllBytes(destPath, list.ToArray());

                        //stream.Close();
                    }
                }
                //MessageBox.Show("end download");
                return true;
            }
            catch /*(Exception ex)*/
            {
                return false;
            }
        }
    }

    public static class Compress
    {        
        static bool DecompressFile(string sDir, System.IO.Compression.GZipStream zipStream)
        {
            //Decompress file name
            byte[] bytes = new byte[sizeof(int)];
            int Readed = zipStream.Read(bytes, 0, sizeof(int));
            if (Readed < sizeof(int))
                return false;

            int iNameLen = BitConverter.ToInt32(bytes, 0);
            bytes = new byte[sizeof(char)];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iNameLen; i++)
            {
                zipStream.Read(bytes, 0, sizeof(char));
                char c = BitConverter.ToChar(bytes, 0);
                sb.Append(c);
            }
            string sFileName = sb.ToString();

            //Decompress Creation, Access, Write date
            bytes = new byte[sizeof(long)];
            zipStream.Read(bytes, 0, sizeof(long));
            long l = BitConverter.ToInt64(bytes, 0);
            DateTime dateCreation = DateTime.FromBinary(l);

            bytes = new byte[sizeof(long)];
            zipStream.Read(bytes, 0, sizeof(long));
            l = BitConverter.ToInt64(bytes, 0);
            DateTime dateAccess = DateTime.FromBinary(l);

            bytes = new byte[sizeof(long)];
            zipStream.Read(bytes, 0, sizeof(long));
            l = BitConverter.ToInt64(bytes, 0);
            DateTime dateWrite = DateTime.FromBinary(l);

            //Decompress file content
            bytes = new byte[sizeof(int)];
            zipStream.Read(bytes, 0, sizeof(int));
            int iFileLen = BitConverter.ToInt32(bytes, 0);

            bytes = new byte[iFileLen];
            zipStream.Read(bytes, 0, bytes.Length);

            string sFilePath = Path.Combine(sDir, sFileName);
            string sFinalDir = Path.GetDirectoryName(sFilePath);
            if (!Directory.Exists(sFinalDir))
                Directory.CreateDirectory(sFinalDir);

            using (FileStream outFile = new FileStream(sFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                outFile.Write(bytes, 0, iFileLen);
            File.SetCreationTime(sFilePath, dateCreation);
            File.SetLastAccessTime(sFilePath, dateAccess);
            File.SetLastWriteTime(sFilePath, dateWrite);

            return true;
        }
        public static void DecompressToDirectory(string sCompressedFile, string sDir)
        {
            using (FileStream inFile = new FileStream(sCompressedFile, FileMode.Open, FileAccess.Read, FileShare.None))
            using (System.IO.Compression.GZipStream zipStream = new System.IO.Compression.GZipStream(inFile, System.IO.Compression.CompressionMode.Decompress, true))
                while (DecompressFile(sDir, zipStream)) ;
        }
    }    
}
