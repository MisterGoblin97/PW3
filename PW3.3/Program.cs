namespace PW3._3
{
    class SQLCommand
    {
        public string commandText;

        public SQLCommand(string commantText)
        {
            this.commandText = commantText;
            SQLToUpper();
        }


        public void SQLToUpper()
        {
            string[] SQLCommand = commandText.Split(' ');
            for (int i = 0; i < SQLCommand.Length; i++)
            {
                if (SQLCommand[i] == "select" || SQLCommand[i] == "from" || SQLCommand[i] == "where")
                {
                    SQLCommand[i] = SQLCommand[i].ToUpper();
                }
            }
            string outputSQL = string.Join(" ", SQLCommand);
            Console.WriteLine(outputSQL);
        }

    }

    internal class Program
    {
        static void Main()
        {
            SQLCommand NewSQLQueryy = new SQLCommand("select group from OPK where name = \"ISP-20-4\"");
        }
    }
}
