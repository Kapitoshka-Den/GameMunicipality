﻿#pragma checksum "..\..\..\..\..\Resources\Cards\ResourcesCard\ResourcesCard.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "43D4EE6A3E0EE476BEA0CDD50C08F1E25DF3D2422D0FF3203EC970FE9364954E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GameRANHIGS.Resources.Cards.ResourcesCard;
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


namespace GameRANHIGS.Resources.Cards.ResourcesCard {
    
    
    /// <summary>
    /// ResourcesCard
    /// </summary>
    public partial class ResourcesCard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\Resources\Cards\ResourcesCard\ResourcesCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GameRANHIGS.Resources.Cards.ResourcesCard.ResourcesCard ResourcesWindow;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Resources\Cards\ResourcesCard\ResourcesCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ResourcesImage;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\Resources\Cards\ResourcesCard\ResourcesCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ResourcesText;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GameRANHIGS;component/resources/cards/resourcescard/resourcescard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Resources\Cards\ResourcesCard\ResourcesCard.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ResourcesWindow = ((GameRANHIGS.Resources.Cards.ResourcesCard.ResourcesCard)(target));
            
            #line 14 "..\..\..\..\..\Resources\Cards\ResourcesCard\ResourcesCard.xaml"
            this.ResourcesWindow.Closing += new System.ComponentModel.CancelEventHandler(this.ResourcesWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ResourcesImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.ResourcesText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            
            #line 42 "..\..\..\..\..\Resources\Cards\ResourcesCard\ResourcesCard.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
