﻿

#pragma checksum "c:\Users\ealtyn\Documents\Sources\ATT.SampleApp\SmsControlPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "94148963074FD09877BD8E226B087932"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATT.SampleApp
{
    partial class SmsControlPage : global::ATT.SampleApp.Common.LayoutAwarePage
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::ATT.SampleApp.Common.LayoutAwarePage pageRoot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Data.CollectionViewSource itemsViewSource; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button backButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///SmsControlPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            pageRoot = (global::ATT.SampleApp.Common.LayoutAwarePage)this.FindName("pageRoot");
            itemsViewSource = (global::Windows.UI.Xaml.Data.CollectionViewSource)this.FindName("itemsViewSource");
            backButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("backButton");
        }
    }
}



