using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAutomation.Framework
{
    public static class CommonVariable
    {
        public static class Browser
        {
            public const string Chrome = "Chrome";
            public const string Firefox = "Firefox";
            public const string IE = "IE";
            public const string Edge = "Edge";
        }

        public static class DefaultValue
        {
            public const string Empty = "";
            public const string Select = "Select";
            public const string ScenarioId = nameof(ScenarioId);
            public const string ScreenShots = nameof(ScreenShots);
            public const string ScreenShotFormat = ".png";
        }
        public static class XPath_Button
        {
            public const string btnSave = nameof(btnSave);
            public const string btnSaveNew = nameof(btnSaveNew);
            public const string btnSaveEdit = nameof(btnSaveEdit);
            public const string btnCancel = nameof(btnCancel);
            public const string btnAdd = nameof(btnAdd);
            public const string btnUpdate = nameof(btnUpdate);
            public const string btnAddUser = nameof(btnAddUser);
            public const string btnEdit = nameof(btnEdit);
            public const string btnDelete = nameof(btnDelete);
            public const string Login = nameof(Login);
            public const string btnLogin = nameof(btnLogin);
            public const string btnLogout = nameof(btnLogout);
            public const string liSignOut = nameof(liSignOut);
        }
    }
}
