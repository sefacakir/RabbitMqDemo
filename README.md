# RabbitMqDemo

RabbitMq is a message queue system. It works under the logic of Publish and Subscribe.
It receives a message from one application and forwards it to another application when it is their turn.
- **Publisher:** It is the structure that sends the message to the queue.
- **Exchange:** Forwards the message to the corresponding queue according to the corresponding routing key.
- **Queue:** It is the queue where the messages are kept.
- **Consumer:** It is the structure that will listen and read the message in the queue.

![Ekran Alıntısı](https://user-images.githubusercontent.com/55946046/146638262-ff9f18b1-85c5-4e31-9195-b980113aec00.PNG)
