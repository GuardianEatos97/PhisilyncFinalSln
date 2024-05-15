using PhisilyncFinal.Models;
using SQLite;
using System.Reflection;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using ThreadNetwork;

namespace PhisilyncFinal.Services
{
    public class LocalDb
    {

        public SQLiteConnection _dbConnection;

        public string GetDataBasePath()
        {
            string filename = "AppDataDB.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(pathToDb,filename);//pathToDb + filename;
        }

        

        private void ExtractDBEmbeddedResource()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(LocalDb)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("PhisilyncFinal.Services.AppDataDB.db");

            var path = GetDataBasePath();

            if (stream != null)
            {
                using (BinaryReader br = new BinaryReader(stream))
                {
                    using (FileStream fs = new FileStream(path, FileMode.Create))
                    {
                        BinaryWriter bw = new BinaryWriter(fs);
                        byte[] bytes = new byte[stream.Length];
                        stream.Read(bytes, 0, bytes.Length);
                        bw.Write(bytes);
                    }
                }
            }

        }

        public LocalDb()
        {
            if(!File.Exists(GetDataBasePath()))
            {
                ExtractDBEmbeddedResource();
            }

            _dbConnection = new SQLiteConnection(GetDataBasePath());

            _dbConnection.CreateTable<User>();
        }

        public void SaveUser(User user)
        {
            try
            {
                _dbConnection.Insert(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
