﻿

#pragma checksum "E:\GitHub\cnblogs-UAP\CNBlogs.Windows\Pages\NewsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5B2DBF94111DD1D46D6E1B4ED07BED38"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNBlogs.Pages
{
    partial class NewsPage : global::CNBlogs.FlatNavigationPage
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::CNBlogs.FlatNavigationPage pageRoot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::CNBlogs.PageTitleControl TitleControl; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.SemanticZoom sz_News; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.GridView gv_News; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.GridView gv_SimpleNews; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton btn_Refresh; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton btn_ScrollToTop; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton btn_ZoomChange; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Pages/NewsPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            pageRoot = (global::CNBlogs.FlatNavigationPage)this.FindName("pageRoot");
            TitleControl = (global::CNBlogs.PageTitleControl)this.FindName("TitleControl");
            sz_News = (global::Windows.UI.Xaml.Controls.SemanticZoom)this.FindName("sz_News");
            gv_News = (global::Windows.UI.Xaml.Controls.GridView)this.FindName("gv_News");
            gv_SimpleNews = (global::Windows.UI.Xaml.Controls.GridView)this.FindName("gv_SimpleNews");
            btn_Refresh = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("btn_Refresh");
            btn_ScrollToTop = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("btn_ScrollToTop");
            btn_ZoomChange = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("btn_ZoomChange");
        }
    }
}



