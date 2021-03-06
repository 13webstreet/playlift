﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using WebService;

namespace MusicManager
{
    public static class MusicManagerBase
    {
        public static string StreamingUrl
        {
            get
            {
#if DEBUG
                return ConfigurationManager.AppSettings["AWSS3UrlTest"];
#else
                return ConfigurationManager.AppSettings["AWSS3Url"];
#endif
            }
        }

        public static string LocalTempDestinationPath
        {
            get
            {
                return ConfigurationManager.AppSettings["LocalTempFilePath"].ToString(CultureInfo.InvariantCulture);
            }
        }

        public static string CloudfrontUrl
        {
            get
            {
#if DEBUG
                return ConfigurationManager.AppSettings["AWSStreamUrlTest"].ToString(CultureInfo.InvariantCulture);
#else
                return ConfigurationManager.AppSettings["AWSStreamUrl"].ToString(CultureInfo.InvariantCulture);
#endif
            }
        }

        public static string CloudfrontMasterUrl
        {
            get
            {
#if DEBUG
                return ConfigurationManager.AppSettings["AWSMasterUrlTest"].ToString(CultureInfo.InvariantCulture);
#else
                return ConfigurationManager.AppSettings["AWSMasterUrl"].ToString(CultureInfo.InvariantCulture);
#endif
            }
        }

        public static string GoogleMapsAPIKey
        {
            get
            {
#if DEBUG
                return ConfigurationManager.AppSettings["APIKeyTest"].ToString(CultureInfo.InvariantCulture);
#else
                return ConfigurationManager.AppSettings["APIKey"].ToString(CultureInfo.InvariantCulture);
#endif
            }
        }

        public static string DefaultLat
        {
            get
            {
                return ConfigurationManager.AppSettings["DefaultLat"].ToString(CultureInfo.InvariantCulture);
            }
        }

        public static string DefaultLong
        {
            get
            {
                return ConfigurationManager.AppSettings["DefaultLong"].ToString(CultureInfo.InvariantCulture);
            }
        }

        public static string SaveFileLocally(System.Web.HttpPostedFileBase sourceFile)
        {
            if (!Directory.Exists(LocalTempDestinationPath))
            {
                Directory.CreateDirectory(LocalTempDestinationPath);
            }

            var localFile = Path.Combine(LocalTempDestinationPath, sourceFile.FileName);

            if (!File.Exists(localFile))
            {
                sourceFile.SaveAs(localFile);
            }

            return localFile;
        }

        public static string SerializeObjectToJson(object obj)
        {
            var serializer = new JavaScriptSerializer();

            var json = serializer.Serialize(obj);
            return json;
        }

        public static string ReturnFormItemValue(string[] form, string key)
        {
            string value = string.Empty;
            if (!string.IsNullOrEmpty(form.FirstOrDefault(x => x.ToString().Contains(key))))
            {
                value = form.FirstOrDefault(x => x.ToString().Contains(key)).ToString().Split('=')[1];
            }

            return value.Replace("+", " ").Replace("%2F", "/").Replace("%3F", "?").Replace("%3D", "=").Replace("%40", "@").Replace("%3A", ":")
                .Replace("%2C", ",").Replace("%5C", "\\").Replace("%3B", ";").Replace("%0D", "").Replace("%0A", "");
        }

        public static bool ReturnFormBooleanValue(string[] form, string key)
        {
            bool value = false;
            if (!string.IsNullOrEmpty(form.FirstOrDefault(x => x.ToString().Contains(key))))
            {
                if (form.FirstOrDefault(x => x.ToString().Contains(key)).ToString().Split('=')[1] == "true")
                {
                    return true;
                }
            }

            return value;
        }
    }
}