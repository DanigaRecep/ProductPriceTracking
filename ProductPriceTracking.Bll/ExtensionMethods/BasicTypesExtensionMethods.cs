﻿namespace ProductPriceTracking.Bll.ExtensionMethods
{
    public static class BasicTypesExtensionMethods
    {
        public static bool EmptyCheck(this string str)
        {
            return string.IsNullOrWhiteSpace(str) || string.IsNullOrEmpty(str);
        }
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }
    }
}
