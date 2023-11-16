using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQDashboard.Data;
using System.Net;
using System.Text;

namespace RabbitMQDashboard.Util
{
    public class RabbitMQManager
    {
        private static IModel channel;

        public static IModel GetChannel()
        {
            if (channel == null || channel.IsClosed)
            {
                var factory = new ConnectionFactory
                {
                    HostName = "localhost"
                };

                IConnection connection = factory.CreateConnection();
                channel = connection.CreateModel();
            }

            return channel;
        }

        public static List<T> GetInfos<T>(string baseUrl)
        {
            string username = "guest";
            string password = "guest";

            List<T> infos = new List<T>();
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
                    infos = JsonConvert.DeserializeObject<List<T>>(json);
                }
            }

            return infos;
        }

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

        public static void DeleteQueue(string queueName)
        {
            IModel channel = GetChannel();
            channel.QueueDelete(queueName);
        }

        public static void CreateQueue(string queueName)
        {
            GetChannel().QueueDeclare(queueName, true, false, false, null);
        }

        public static void CreateExchange(string exchangeName)
        {
            GetChannel().ExchangeDeclare(exchangeName, ExchangeType.Topic);
        }

        public static void DeleteExchange(string exchangeName)
        {
            GetChannel().ExchangeDelete(exchangeName);
        }
    }
}
