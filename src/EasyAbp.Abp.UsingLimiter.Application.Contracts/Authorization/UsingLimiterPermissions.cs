using Volo.Abp.Reflection;

namespace EasyAbp.Abp.UsingLimiter.Authorization
{
    public class UsingLimiterPermissions
    {
        public const string GroupName = "UsingLimiter";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(UsingLimiterPermissions));
        }
    }
}