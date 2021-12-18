using System;
using System.Collections.Generic;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RabbitMqDemo
{
    public class Consumer
    {
        private readonly RabbitMQService _rabbitMQService;

        public Consumer(string queuName)
        {
            _rabbitMQService = new RabbitMQService();
            using (var connection = _rabbitMQService.GetRabbitMQConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        var body = ea.Body.ToArray(); //or ea.Body.ToArray();
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine("{0} isimli queue üzerinden gelen mesaj: \"{1}\"", queuName, message);
                    };
                    channel.BasicConsume(queuName, true, consumer);
                    Console.ReadKey();
                }
            }
        }

    }
}
