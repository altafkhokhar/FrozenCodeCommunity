

using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace FrozenCode.Community.AppUI.Helper
{
    public class AppHelper
    {

        public static string GetCommunityName()
        {

            var titleValue = (string)FrozenCode.Community.AppUI.Properties.Settings.Default.Properties["CommunityTitle"].DefaultValue;

            return titleValue;
        }

        private static string ImageFilePath =  Application.StartupPath + Path.DirectorySeparatorChar + "Images" + Path.DirectorySeparatorChar;
        private static string ImageFileExtension = ".jpg";

        private static string KEY_IMAGELOCATION = "IMAGELOCATION";
        private static string KEY_ISDEVELOPMENT = "ISDEVELOPMENT";
        private static string DEFAULT_PROFILE_PIC = "DEFAULT_PROFILE_PIC";

        public static string GetMemberImageFullPathToSave()
        {
            var isDevelopment =  ConfigurationManager.AppSettings[KEY_ISDEVELOPMENT].ToLowerInvariant();
            if(isDevelopment ==  "true" )
                ImageFilePath = ConfigurationManager.AppSettings[KEY_IMAGELOCATION] + Path.DirectorySeparatorChar + "Images" + Path.DirectorySeparatorChar;
            else
                ImageFilePath = Application.StartupPath + Path.DirectorySeparatorChar + "Images" + Path.DirectorySeparatorChar;
            

            return ImageFilePath;
        }

        public static string GetMemberImageExtensionForSave()
        {

            return ImageFileExtension;
        }

        
    }
}