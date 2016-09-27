using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;
using Ninject;
using Toci.HornetsTraining.Training2.HomeWork.Common_Michal.Const;
using Toci.HornetsTraining.Training2.HomeWork.Common_Michal.Secure;

namespace Toci.HornetsTraining.Training2.HomeWork.Common_Michal
{
    public static class Serializer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="fileName"></param>
        public static void ObjectToXmlFile<T>(T obj, string fileName)
        {
            IKernel kernel = Infrastructure.Factory.GetInstance();
            ICrypt AES = kernel.Get<ICrypt>();

            string folderPath = Path.Combine(Environment.CurrentDirectory, AppConst.HomeworkPath);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fullPath = Path.Combine(folderPath, fileName) + ".xml";
            if (!File.Exists((fullPath)))
            {
                File.Create(fullPath);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(string));
            var content = AES.Encrypt(ObjectToXmlString(obj));

            File.WriteAllText(fullPath, content, Encoding.UTF8);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static T XmlFileToObject<T>(string fileName)
        {
            try
            {
                IKernel kernel = Infrastructure.Factory.GetInstance();
                ICrypt AES = kernel.Get<ICrypt>();

                var xmlString = FileToString(fileName);
                return XmlStringToObject<T>(AES.Decrypt(xmlString));

            }
            catch (Exception ex)
            {
                return default(T);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ObjectToXmlString<T>(T obj)
        {
            IKernel kernel = Infrastructure.Factory.GetInstance();
            ICrypt crypter = kernel.Get<ICrypt>();
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            var stringWriter = new System.IO.StringWriter();
            serializer.Serialize(stringWriter, obj);
            return stringWriter.ToString();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fullPath"></param>
        /// <returns></returns>
        public static string FileToString(string fileName)
        {
            try
            {
                IKernel kernel = Infrastructure.Factory.GetInstance();
                ICrypt AES = kernel.Get<ICrypt>();
                var folderPath = Path.Combine(Environment.CurrentDirectory, AppConst.HomeworkPath);
                var fullPath = Path.Combine(folderPath, fileName) + ".xml";

                return File.ReadAllText(fullPath, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        public static T XmlStringToObject<T>(string xmlString)
        {
            try
            {
                IKernel kernel = Infrastructure.Factory.GetInstance();
                ICrypt crypter = kernel.Get<ICrypt>();
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                var reader = new StringReader(xmlString);
                var result = serializer.Deserialize(reader);
                return (T)result;
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }
}