using System;

namespace RabbitMqDemo
{
    class Program
    {
        private static readonly string _queueName = "TESTQUEUE";
        private static Consumer _consumer;
        private static Publisher _publisher;

        static void Main(string[] args)
        {
            _publisher = new Publisher(_queueName, "Hello RabbitMQ World!");

            _consumer = new Consumer(_queueName);
        }
    }
}
