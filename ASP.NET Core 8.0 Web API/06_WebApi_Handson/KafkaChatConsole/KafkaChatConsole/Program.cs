using Confluent.Kafka;

Console.Write("Enter your name: ");
string userName = Console.ReadLine()!;

Console.Write("Run as Producer (P) or Consumer (C)? ");
string mode = Console.ReadLine()!.ToUpper();

string topic = "chat";

if (mode == "P")
{
    var config = new ProducerConfig
    {
        BootstrapServers = "localhost:9092"
    };

    using var producer = new ProducerBuilder<Null, string>(config).Build();

    Console.WriteLine("Type messages. Type 'exit' to quit.");

    while (true)
    {
        string message = Console.ReadLine()!;

        if (message.ToLower() == "exit")
            break;

        producer.Produce(topic,
            new Message<Null, string>
            {
                Value = $"{userName}: {message}"
            });

        producer.Flush(TimeSpan.FromSeconds(2));
    }
}
else
{
    var config = new ConsumerConfig
    {
        BootstrapServers = "localhost:9092",
        GroupId = Guid.NewGuid().ToString(),
        AutoOffsetReset = AutoOffsetReset.Earliest
    };

    using var consumer =
        new ConsumerBuilder<Ignore, string>(config).Build();

    consumer.Subscribe(topic);

    Console.WriteLine("Listening...");

    while (true)
    {
        var result = consumer.Consume();

        Console.WriteLine(result.Message.Value);
    }
}