﻿

#pragma checksum "E:\bim 6\app_dev\quad\quad\smashgamepage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "46A10CCA6EFA822B5A6F6F2E3A7C5B7A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace quad
{
    partial class smashgamepage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 9 "..\..\smashgamepage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.Grid_Loaded;
                 #line default
                 #line hidden
                #line 9 "..\..\smashgamepage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyDown += this.Grid_KeyDown;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 34 "..\..\smashgamepage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyDown += this.TextBox_KeyDown;
                 #line default
                 #line hidden
                #line 34 "..\..\smashgamepage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyUp += this.TextBox_KeyUp;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


