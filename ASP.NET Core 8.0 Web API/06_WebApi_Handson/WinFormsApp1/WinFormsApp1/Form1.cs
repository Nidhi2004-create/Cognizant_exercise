using Confluent.Kafka;
using System;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly string topic = "chat";

        ProducerConfig producerConfig = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        ConsumerConfig consumerConfig = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = Guid.NewGuid().ToString(),
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(ReceiveMessages);
            t.IsBackground = true;
            t.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var producer = new ProducerBuilder<Null, string>(producerConfig).Build();

            producer.Produce(topic, new Message<Null, string>
            {
                Value = textBox1.Text + ": " + textBox2.Text
            });

            producer.Flush(TimeSpan.FromSeconds(2));
            textBox2.Clear();
        }

        private void ReceiveMessages()
        {
            using var consumer = new ConsumerBuilder<Ignore, string>(consumerConfig).Build();

            consumer.Subscribe(topic);

            while (true)
            {
                var result = consumer.Consume();

                Invoke(new Action(() =>
                {
                    lstMessages.Items.Add(result.Message.Value);
                }));
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}