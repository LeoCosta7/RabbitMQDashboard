using Newtonsoft.Json;
using RabbitMQDashboard.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQDashboard.Util
{
    public class RabbitMQManager
    {
        public static List<QueueInfo> GetQueueInfos()
        {
            string baseUrl = "http://localhost:15672/api/queues";
            string username = "guest";
            string password = "guest";

            List<QueueInfo> queueInfos = new List<QueueInfo>();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl);
            request.Method = "GET";
            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string json = reader.ReadToEnd();
                    queueInfos = JsonConvert.DeserializeObject<List<QueueInfo>>(json);
                }
            }

            return queueInfos;
        }
    }
}
