

using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FrozenCode.Community.AppUI.Helper
{
    public class AppHelper
    {

        public static string GetCommunityName()
        {

            var titleValue = "";//(string)FrozenCode.Community.AppUI.Properties.Settings.Default.Properties["CommunityTitle"].DefaultValue;

            return titleValue;
        }

        private static string ImageFilePath =  Application.StartupPath + Path.DirectorySeparatorChar + "Images" + Path.DirectorySeparatorChar;
        private static string ImageFileExtension = ".jpg";

        private static string KEY_IMAGELOCATION = "IMAGELOCATION";
        private static string KEY_ISDEVELOPMENT = "ISDEVELOPMENT";
        private static string DEFAULT_PROFILE_PIC = "DEFAULT_PROFILE_PIC";

        private static string DATA_DIRECTORY = "DATA";

        private static string DATABASE_FILE = "Community.mdf";

        public static string GetMemberImageFullPathToSave()
        {
            var isDevelopment =  ConfigurationManager.AppSettings[KEY_ISDEVELOPMENT].ToLowerInvariant();
            if(isDevelopment ==  "true" )
                ImageFilePath = ConfigurationManager.AppSettings[KEY_IMAGELOCATION] + Path.DirectorySeparatorChar + "Images" + Path.DirectorySeparatorChar;
            else
                ImageFilePath = Application.StartupPath + Path.DirectorySeparatorChar + "Images" + Path.DirectorySeparatorChar;
            

            return ImageFilePath;
        }

        public static string GetApplicationRootPath()
        {
            return Application.StartupPath;
        }

        public static string GetDatabasePath()
        {
            return Application.StartupPath + Path.DirectorySeparatorChar + DATA_DIRECTORY + Path.DirectorySeparatorChar;
        }

        public static string GetDatabaseFileWithPath()
        {
            return Application.StartupPath + Path.DirectorySeparatorChar + DATA_DIRECTORY + Path.DirectorySeparatorChar + DATABASE_FILE;
        }

        public static string GetDatabaseFileName()
        {
            return DATABASE_FILE;
        }

        public static string GetBackupFileName()
        {
            return DateTime.Now.ToShortDateString().Replace("/","_") + "_" + DateTime.Now.ToShortTimeString() + ".mdf";
        }

        public static string GetMemberImageExtensionForSave()
        {

            return ImageFileExtension;
        }


        public static int ExecuteCommand(string commnd, int timeout)
        {
            var pp = new ProcessStartInfo("cmd.exe", "/C" + commnd)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = "C:\\",
            };
            var process = Process.Start(pp);
            process.WaitForExit(timeout);
            process.Close();
            return 0;
        }


    }
}