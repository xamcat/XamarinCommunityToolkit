﻿using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

using XF = Xamarin.Forms;

namespace Microsoft.Toolkit.Xamarin.Forms.Sample.Pages
{
    public class BaseNavigationPage : XF.NavigationPage
    {
        public BaseNavigationPage(XF.Page root) : base(root)
        {
            On<iOS>().SetModalPresentationStyle(UIModalPresentationStyle.FormSheet);
            On<iOS>().DisableTranslucentNavigationBar();
            On<iOS>().SetHideNavigationBarSeparator(true);
        }
    }
}