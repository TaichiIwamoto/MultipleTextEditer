using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace MultipleTextEditor.Json
{
    class DataManager
    {
        [System.Runtime.Serialization.DataContract]
        public class SaveDataSubstance
        {
            [System.Runtime.Serialization.DataMember]
            public int Page { get; set; }

            [System.Runtime.Serialization.DataMember]
            public string Text { get; set; }
        }
        public void SaveData(int page, string text)
        {
            SaveDataSubstance data = new SaveDataSubstance {
                Page = page,
                Text = text
            };

            FileStream fs = new FileStream("SaveData.json", FileMode.Create);
            var serializer = new DataContractJsonSerializer(typeof(DataManager));
            serializer.WriteObject(fs, data);
        }
    }
}

