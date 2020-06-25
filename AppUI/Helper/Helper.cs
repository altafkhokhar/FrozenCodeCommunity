

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

        private static string ImageFilePath = Application.StartupPath + Path.DirectorySeparatorChar + "Images" + Path.DirectorySeparatorChar;
        private static string ImageFileExtension = ".jpg";

        public static string GetMemberImageFullPathToSave()
        {
            return ImageFilePath;
        }

        public static string GetMemberImageExtensionForSave()
        {
            return ImageFileExtension;
        }
    }
}