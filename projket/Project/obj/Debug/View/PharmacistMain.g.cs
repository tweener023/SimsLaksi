// Updated by XamlIntelliSenseFileGenerator 13.8.2021. 11:45:41
#pragma checksum "..\..\..\View\PharmacistMain.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B154FB3D6BF631DE5BB04C2D7C62C4CB5964DA7FDFBD2F89BFFB0C17A5E439D4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Project.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Project.View
{


    /// <summary>
    /// PharmacistMain
    /// </summary>
    public partial class PharmacistMain : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 46 "..\..\..\View\PharmacistMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid medicineDataGrid;

#line default
#line hidden


#line 88 "..\..\..\View\PharmacistMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ingerdientsDataGrid;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Project;component/view/pharmacistmain.xaml", System.UriKind.Relative);

#line 1 "..\..\..\View\PharmacistMain.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.medicineDataGrid = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 2:
                    this.ingerdientsDataGrid = ((System.Windows.Controls.DataGrid)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox registerCodeBox;
        internal System.Windows.Controls.TextBox registerNameBox;
        internal System.Windows.Controls.TextBox registerManufacturerBox;
        internal System.Windows.Controls.TextBox registerPriceBox;
        internal System.Windows.Controls.TextBox registerAmountBox;
        internal System.Windows.Controls.TextBox registerIngredientsBox;
    }
}

