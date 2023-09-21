using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAutomation.Framework.JsonTestData
{
    public static class JsonDataReader
    {
        public static object GetJsonData(string ProjectName)
        {
            object jsonObjects = null;
            string sJsonFileName = "";
            string jsonString = "";
            try
            {
                string sBaseDirectory = (AppDomain.CurrentDomain.BaseDirectory).Replace(@"\\bin\\Debug\\net6.0\\", "");
                sBaseDirectory = sBaseDirectory.Replace(@"\\bin\\Debug\\net6.0\\", "");
                sBaseDirectory = sBaseDirectory.Replace(@"\bin\Debug\net6.0", "");

                if (ProjectName == "Acutis")
                {
                    sJsonFileName = sBaseDirectory + @"\TestData\AcutisTestData.json";
                    jsonString = System.IO.File.ReadAllText(sJsonFileName);
                    jsonObjects = JsonConvert.DeserializeObject<AcutisJsonDataObjects>(jsonString.ToString());

                }
                 

            }
            catch (Exception ex)
            {

            }


            return jsonObjects;
        }

    }

}
