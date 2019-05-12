using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace creatSln
{
    /// <summary>
    /// Summary description for helloworld
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]

    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class helloworld : System.Web.Services.WebService
    {
        [WebMethod(Description ="hello ")]
        public string HelloWorld(string name)
        {
            return "Hello"+name;
        }
        [WebMethod(Description ="加")]
        public int add(int a,int b)
        {
            int c = a+b;
            return c;
        }
        [WebMethod(Description ="减")]
        public int subtract(int a,int b)
        {
            int c = a - b;
            return c;
        }
        [WebMethod(Description ="乘")]
        public double multiply(double a,double b)
        {
            double c = a * b;
            return c;
        }
        [WebMethod(Description ="除")]
        public double divide(double a,double b)
        {
            double c = a / b;
            return c;
        }
    }
}
