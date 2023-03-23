namespace PW3._2
{

    class SmsMessage
    {
        public string MessageText { get; set; }
        public int MessageTextLength { get; set; }
        public int MessageTextMax { get; set; }
        public double Price { get; set; }
        public double PriceAdd { get; set; }

       

        public SmsMessage(string messageText, int messageTextLength, int messageTextMax, double price, double priceAdd)
        {
            MessageText = messageText;
            MessageTextLength = messageTextLength;
            MessageTextMax = messageTextMax;
            Price = price;
            PriceAdd = priceAdd;
        }

        public string GetTextMsg()
        {
            if (MessageText.Length > MessageTextMax)
            {
                return MessageText.Substring(0, MessageTextMax);
            }
            return MessageText;
        }

        public double CalculatePrice()
        {
            if (MessageText.Length > MessageTextMax)
            {
                int extraChars = MessageText.Length - MessageTextMax;
                return Price + (extraChars * PriceAdd);
            }
            return Price;
        }
    }



    internal class Program
    {
        static void Main()
        {
            SmsMessage newMessage = new SmsMessage("Крестиненко Мавтей Евгеньевич Крутой мужик как и его крутой преподаватель Мерцалов Сергей Александрович", 50, 75, 2, 0.75);

            Console.WriteLine($"{newMessage.MessageText}\nКоличество символов в сообщении: {newMessage.MessageText.Length}");
            Console.WriteLine($"Ценна вашего сообщения: {newMessage.CalculatePrice()}");
        }
    }
}