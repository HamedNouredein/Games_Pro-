using Games_Pro.Controllers;
using static System.Net.Mime.MediaTypeNames;

namespace Games_Pro.Setting
{
    //ده لو عايز استخدم ملفات في اكتر من مكان في البروجكت ولو اتطريت اعدلفيه يبقااا هعدل في مكان ولحد
    public static class FileSettings
    {
        public const string  ImagePath="/assets/images/games";
        public const string  AllowwdExtensions=".jpg,.jpeg,.png";
        public const int  MaxFileSizeInMB=1;
        public const int MaxFileSizeInBytes = MaxFileSizeInMB * 1024 * 1024;
    }
}
