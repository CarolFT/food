﻿
namespace food.Helpers
{
    using Plugin.Settings;
    using Plugin.Settings.Abstractions;
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string tokenType = "TokenType";
        private const string accessTokenpe = "AccessToken";
        private const string isRemembered = "IsRemembered";
        private static readonly string stringDefault = string.Empty;
        private static readonly bool booleanDefault = false;
        #endregion


        public static string TokenType
        {
            get
            {
                return AppSettings.GetValueOrDefault(tokenType, stringDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(tokenType, value);
            }
        }
        public static string AccessToken
        {
            get
            {
                return AppSettings.GetValueOrDefault(accessTokenpe, stringDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(accessTokenpe, value);
            }
        }
        public static bool IsRemembered
        {
            get
            {
                return AppSettings.GetValueOrDefault(isRemembered, booleanDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(isRemembered, value);
            }
        }

    }
}

