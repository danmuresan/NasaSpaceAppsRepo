﻿#pragma checksum "E:\Projects\NasaSpaceAppsRepo\NasaSpaceApp\NasaSpaceApp\UI\LoginPageView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0983DB2DB50FB9AE0BF4CACC9C9509A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NasaSpaceApp.UI
{
    partial class LoginPageView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
        };

        private class LoginPageView_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ILoginPageView_Bindings
        {
            private global::NasaSpaceApp.UI.LoginPageView dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj2;
            private global::Windows.UI.Xaml.Controls.TextBox obj3;
            private global::Windows.UI.Xaml.Controls.Image obj4;
            private global::Windows.UI.Xaml.Controls.Image obj6;

            private LoginPageView_obj1_BindingsTracking bindingsTracking;

            public LoginPageView_obj1_Bindings()
            {
                this.bindingsTracking = new LoginPageView_obj1_BindingsTracking(this);
            }

            ~LoginPageView_obj1_Bindings()
            {
                StopTracking();
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj3).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.Vm.UserName = (this.obj3).Text;
                                }
                            };
                        break;
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    default:
                        break;
                }
            }

            // ILoginPageView_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // LoginPageView_obj1_Bindings

            public void SetDataRoot(global::NasaSpaceApp.UI.LoginPageView newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::NasaSpaceApp.UI.LoginPageView obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Vm(obj.Vm, phase);
                    }
                }
            }
            private void Update_Vm(global::NasaSpaceApp.UI.LoginPageViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Vm(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Vm_LoginCommand(obj.LoginCommand, phase);
                        this.Update_Vm_UserName(obj.UserName, phase);
                        this.Update_Vm_ErrorVisibility(obj.ErrorVisibility, phase);
                    }
                }
            }
            private void Update_Vm_LoginCommand(global::GalaSoft.MvvmLight.Command.RelayCommand<global::System.Object> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj2, obj, null);
                }
            }
            private void Update_Vm_UserName(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj3, obj, null);
                }
            }
            private void Update_Vm_ErrorVisibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj4, obj);
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj6, obj);
                }
            }

            private class LoginPageView_obj1_BindingsTracking
            {
                global::System.WeakReference<LoginPageView_obj1_Bindings> WeakRefToBindingObj; 

                public LoginPageView_obj1_BindingsTracking(LoginPageView_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<LoginPageView_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_Vm(null);
                }

                public void PropertyChanged_Vm(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    LoginPageView_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::NasaSpaceApp.UI.LoginPageViewModel obj = sender as global::NasaSpaceApp.UI.LoginPageViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_Vm_LoginCommand(obj.LoginCommand, DATA_CHANGED);
                                    bindings.Update_Vm_UserName(obj.UserName, DATA_CHANGED);
                                    bindings.Update_Vm_ErrorVisibility(obj.ErrorVisibility, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "LoginCommand" :
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Vm_LoginCommand(obj.LoginCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "UserName" :
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Vm_UserName(obj.UserName, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ErrorVisibility" :
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Vm_ErrorVisibility(obj.ErrorVisibility, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
                private global::NasaSpaceApp.UI.LoginPageViewModel cache_Vm = null;
                public void UpdateChildListeners_Vm(global::NasaSpaceApp.UI.LoginPageViewModel obj)
                {
                    if (obj != cache_Vm)
                    {
                        if (cache_Vm != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_Vm).PropertyChanged -= PropertyChanged_Vm;
                            cache_Vm = null;
                        }
                        if (obj != null)
                        {
                            cache_Vm = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_Vm;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 5:
                {
                    this.PasswordBox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    LoginPageView_obj1_Bindings bindings = new LoginPageView_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
