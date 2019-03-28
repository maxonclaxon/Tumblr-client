using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Курсовая_работа
{
    public class Requests
    {
        /// <summary>
        /// Метод реализует GET-запрос
        /// </summary>
        /// <param name="method">Requests.RequestMethod.Метод</param>
        /// <returns></returns>
        public static async Task<string> GETrequest(string method)
        {
            string Url = RequestLink.url+method;
            WebRequest req = WebRequest.Create(Url + "?" +Api_Tools.api_key);
            try
            {
                WebResponse resp =  req.GetResponse();

                using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
                {
                    string Out = sr.ReadToEnd();
                    resp.Close();
                    resp.Dispose();
                    return Out;
                }
            }
            catch (Exception)
            {
                string Out = "Неверный логин!";
                return Out;
            }
        }
        /// <summary>
        /// Класс создаетссылку для GET запроса
        /// </summary>
        public class RequestLink
        {
            public static string url = Api_Tools.url + User.Username + Api_Tools.lastuser;

        }
        /// <summary>
        /// 
        /// </summary>
        public class RequestMethod
        {
            public static string info { get { return "/info"; } }
            public static string posts { get { return "/posts"; } }
        }
    }
}
