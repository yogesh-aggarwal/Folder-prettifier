﻿#pragma checksum "A:\UWP\Folder Prettifier\Folder Prettifier\Dialogs\SignupDialog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "27FA7C6812CE995977762DBBC0CD3DCA522C006B14CC2EFCDFCA5204E46FCE4F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Folder_Prettifier.Dialogs
{
    partial class SignupDialog : 
        global::Windows.UI.Xaml.Controls.ContentDialog, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Dialogs\SignupDialog.xaml line 1
                {
                    this.signupDialog = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)this.signupDialog).PrimaryButtonClick += this.SignupUser;
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)this.signupDialog).SecondaryButtonClick += this.LoginUser;
                }
                break;
            case 2: // Dialogs\SignupDialog.xaml line 20
                {
                    this.nameBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // Dialogs\SignupDialog.xaml line 21
                {
                    this.emailBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Dialogs\SignupDialog.xaml line 22
                {
                    this.passwordBox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 5: // Dialogs\SignupDialog.xaml line 17
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element5 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element5).Click += this.UserBenefits;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

