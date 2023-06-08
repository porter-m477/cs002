
namespace Galileo.Space
{
    static class Constance
    {
        private static string connectionSting;
        public static readonly string CONFIG_SERVER_NAME = "AWSServer";
        public const string CONFIG_DB_NAME = "DBName";
        public static int MyProperty { get; set; }
        public static DateTime GetDate(DateOnly input)
        {
            return new DateTime(input.Year, input.Month, input.Day);
        }
        static Constance()
        {
            connectionSting = "Server=..."; //configuraciones
        }

    }
}