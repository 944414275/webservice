using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace readJsonFlieTest
{
    class Program
    {
        static int _tagsCount;
        static int _startNum;
        static int _endNum;
        //static List<string> _tagsList;
        static string[] _tagsList;

        static void Main(string[] args)
        {
            //List<string> a = new List<string>();
            StreamReader sr = new StreamReader(@"H:\Komla\webserviceTest\webServiceTest\readJsonFlieTest\数据类型示例.8 位设备.B 寄存器.json");
            string str = sr.ReadToEnd();
            //JObject jo = (JObject)JsonConvert.DeserializeObject(str);
            //string strJson = new JavaScriptSerializer().Serialize(str);
            //string iiiii = "{\"count\":\"4\",\"from\":\"1\",\"end\":\"4\",\"tagsName\":[\"数据类型示例.8 位设备.B 寄存器.Boolean1,数据类型示例.8 位设备.B 寄存器.Boolean2,数据类型示例.8 位设备.B 寄存器.Boolean3,数据类型示例.8 位设备.B 寄存器.Boolean4\"]}";
            Console.WriteLine(str);
            //Console.ReadLine();
            try
            {
                Rootobject groupObj = JsonConvert.DeserializeObject<Rootobject>(str);
                //int a = 1;
                _tagsCount = groupObj.count;
                _startNum = groupObj.from;
                _endNum = groupObj.end;
                _tagsList = groupObj.tagsName;
                //,"tagsName":["数据类型示例.8 位设备.B 寄存器.Boolean1","数据类型示例.8 位设备.B 寄存器.Boolean2","数据类型示例.8 位设备.B 寄存器.Boolean3","数据类型示例.8 位设备.B 寄存器.Boolean4"]
                //foreach(var temp in groupObj._tagsList)
                //{
                //    Console.WriteLine("");
                //}

                //_tagsCount = jo["count"].ToString();
                //_startNum = jo["from"].ToString();
                //_endNum = jo["end"].ToString();
                //_tagsList = jo["tagsName"].ToList();

            }
            catch (Exception)
            {
                throw;
            }
            Console.WriteLine("字符串{0}\r\n,数量：{1}\r\n,开始值：{2}\r\n,结束值：{3}", str, _tagsCount,_startNum,_endNum);
            Console.ReadLine();
        }
    }

    class groupObj
    {
        public int _count { get; set; }
        public int _start { get; set; }
        public int _end { get; set; }
        public List<string> _tagsList { get; set; }
        
        //private string Count;
        //public string _count
        //{
        //    get { return Count; }
        //    set { Count = value; }
        //}

        //private string Start;
        //public string _start
        //{
        //    get { return Start; }
        //    set { Start = value; }
        //}

        //private string End;
        //public string _end
        //{
        //    get { return End; }
        //    set { End = value; }
        //}

        //private List<string> TagsList;
        //public List<string> _tagsList
        //{
        //    get { return TagsList; }
        //    set { TagsList = value; }
        //}
    }

    public class Rootobject
    {
        public int count { get; set; }
        public int from { get; set; }
        public int end { get; set; }
        public string[] tagsName { get; set; }
    }
}
