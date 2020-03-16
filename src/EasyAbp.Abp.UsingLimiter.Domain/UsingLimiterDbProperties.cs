namespace EasyAbp.Abp.UsingLimiter
{
    public static class UsingLimiterDbProperties
    {
        public static string DbTablePrefix { get; set; } = "UsingLimiter";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "UsingLimiter";
    }
}
