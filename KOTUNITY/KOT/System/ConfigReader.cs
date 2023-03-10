using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using UnityEngine;

namespace KOT.System
{
    public static class ConfigReader
    {
        public static string ReadValue(string json, string key, string defaultValue = default)
        {
            JsonElement obj = JsonSerializer.Deserialize<JsonElement>(json);
            string result;

            try
            {
                string field = obj.GetProperty(key).GetRawText();

                result = field;

            }
            catch(Exception ex) 
            {
                throw ex;
                //Debug.LogException(ex);
            }
          

            return result;

        }

        public static string DeserializeConfig(string path)
        {
            using FileStream fileStream = new FileStream(path, FileMode.Open);
            using StreamReader streamReader = new StreamReader(fileStream); 

            try
            {
                string json = streamReader.ReadToEnd();

                if (!string.IsNullOrEmpty(json))
                    return json;
                else
                {
                    Debug.LogError($"{path} is not config (JSON) file or config is damaged. Check file.");
                    return string.Empty;
                }
            }
            catch(Exception e) 
            {
                Debug.LogError($"{e.Message}");
                return string.Empty;
            }

        }


    }
}
