namespace PW3._2
{
    class smsMessage
    {
        public string MessageText;
        public double MessageTextMax = 65;
        public double Price = 1.5;
        public double PriceAdd = 0.5;

        public string TextMsg
        {
            get { return MessageText; }
            set { MessageText = value.Length > 250 ? value.Substring(0, 250) : value; } //спасибо chat gpt
        }

        //метод расчета стоимости
        public double CalculatePrice()
        {
            if (MessageText.Length > MessageTextMax)
            {
                double сhars = MessageText.Length - MessageTextMax;
                for (int i = 0; i < сhars; i++)
                {
                    Price += PriceAdd;
                }
            }
            return Price;
        }


        public smsMessage(string MessageText) 
        { 
            TextMsg = MessageText;
        }
    }

    internal class Program
    {
        static void Main()
        {
            smsMessage newMessage = new smsMessage("Lorem Ipsum - это текст-\"рыба\", часто используемый в печати и вэб-дизайне. Lorem Ipsum является стандартной \"рыбой\" для текстов на латинице с начала XVI века. В то время некий безымянный печатник создал большую коллекцию размеров и форм шрифтов, используя Lorem Ipsum для распечатки образцов.");

            Console.WriteLine($"{newMessage.MessageText}\nКоличество символов в сообщении: {newMessage.MessageText.Length}");
            Console.WriteLine($"Ценна вашего сообщения: {newMessage.CalculatePrice()}");
        }
    }
}