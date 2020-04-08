﻿using System.Collections.Generic;
using Classes;
using Project1;

namespace WCF
{
    public class ClassesWCF : IClasses
    {
        public void AddNewFile(Dictionary<string, string> newFile)
        {
            using (var service  = new Services())
            {
                service.AddNewFile(newFile);
            }
        }

        public void AddNewPropriety(File file, string proprietyName, string proprietyValue)
        {
            using (var service = new Services())
            {
                service.AddNewPropriety(file,proprietyName,proprietyValue);
            }
        }


        public bool CopyFilesToPath(string path, List<int> filesIds)
        {
            bool result = false;
            using (var service = new Services())
            {
                result = service.CopyFilesToPath(path,filesIds);
            }
            return result;
        }


        public bool DefinitiveDelete(int id)
        {
            bool result = false;
            using (var service = new Services())
            {
                result = service.DefinitiveDeleteFile(id);
            }
            return result;
        }

        public bool DeleteFile(int id)
        {
            bool result = false;
            using (var service = new Services())
            {
                result = service.DeleteFile(id);
            }
            return result;
        }


        public Dictionary<string,string> GetFileProprieties(int id)
        {
            Dictionary<string,string> result = new Dictionary<string, string>();
            using (var service = new Services())
            {
                result = service.GetFileProprieties(id);
            }
            return result;
        }


        public void ModifyFile(int id, Dictionary<string, string> newProprieties)
        {
            using (var service = new Services())
            {
                service.ModifyFile(id,newProprieties);
            }
        }

        public bool MoveFilesToPath(string path, List<int> filesId)
        {
            bool result = false;
            using (var service = new Services())
            {
                result = service.MoveFilesToPath(path,filesId);
            }
            return result;
        }


        public void Restore(int id)
        {
            using (var service = new Services())
            {
                service.Restore(id);
            }
        }

        public (List<File>, List<File>) SearchFiles(Dictionary<string, string> proprieties)
        {
            (List<File>, List<File>) result = (new List<File>(), new List<File>());
            using (var service = new Services())
            {
                result = service.SearchFiles(proprieties);
            }
            return result;
        }


        public void SendEmail(string to, string from, string subject, string body, List<int> filesIds, string email, string emailPassword)
        {
            using (var service = new Services())
            {
                service.SendEmail(to,from,subject,body,filesIds,email,emailPassword);
            }
        }

    }
}
