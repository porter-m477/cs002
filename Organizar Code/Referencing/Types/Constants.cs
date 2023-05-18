namespace Galileo.Space
{
    public class Constants
    {
        public static string connectionString;
        public static readonly string CONFIG_SERVER_NAME = "Server";
        public const string CONFIG_DB_NAME = "DatabaseName";

        public static int MyProperty { get; set; }
        public static DateTime GetDateTimeFromDateOnly(DateOnly input)
        {
            return new DateTime(input.Year, input.Month, input.Day);
        }
        static Constants()
        {
            connectionString = "Server=..."; //config
        }
    }
}
