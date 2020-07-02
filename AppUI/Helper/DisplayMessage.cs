using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FrozenCode.Community.AppUI.Helper
{
    public class DisplayMessage
    {
        public const string DONE_TITLE = "DONE";
        public const string SAVE_TITLE = "SAVED";
        public const string ERROR_TITLE = "ERROR";
        public const string INFO_TITLE = "INFOS";
        public static void ShowSuccessMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowErrorMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInfoMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}