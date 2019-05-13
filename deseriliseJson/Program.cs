using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
//using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace deseriliseJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "{\"ID\":2,\"Name\":\"鲁智深\",\"Age\":230,\"Sex\":\"男\"}";
            Student two = JsonConvert.DeserializeObject<Student>(str);
            Console.WriteLine(string.Format("学生信息  ID:{0},姓名:{1},年龄:{2},性别:{3}",
            two.ID, two.Name, two.Age, two.Sex));//显示结果
            Console.ReadLine();
        }
    }

    public class Student
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Sex { get; set; }
    }

    public class Rootobject
    {
        public int count { get; set; }
        public int from { get; set; }
        public int end { get; set; }
        public string[] tagsName { get; set; }
    }

}
