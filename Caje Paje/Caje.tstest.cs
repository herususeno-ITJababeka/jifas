using Telerik.TestStudio.Translators.Common;
using Telerik.TestingFramework.Controls.TelerikUI.Blazor;
using Telerik.TestingFramework.Controls.KendoUI.Angular;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;
using ArtOfTest.WebAii.DesktopAutomation;
using ArtOfTest.WebAii.DesktopAutomation.Controls;
using ArtOfTest.WebAii.DesktopAutomation.FindExpressions;

namespace Jifas
{

    public class Caje_Paje : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"Click 'RequestLink'")]
        public void Caje_Paje_CodedStep()
        {
            // Click 'RequestLink'
            ActiveBrowser.Window.SetFocus();
            Pages.JournalTransactionJIFAS.RequestLink.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            Pages.JournalTransactionJIFAS.RequestLink.MouseClick(ArtOfTest.WebAii.Core.MouseClickType.LeftClick, 0, 0, ArtOfTest.Common.OffsetReference.AbsoluteCenter);
            
        }
    
        [CodedStep(@"Enter text 'fa' in 'Text'")]
        public void Caje_Paje_CodedStep1()
        {
            // Enter text 'fa' in 'Text'
            Actions.SetText(Pages.JournalTransactionJIFAS.Text, "");
            Pages.JournalTransactionJIFAS.Text.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            ActiveBrowser.Window.SetFocus();
            Pages.JournalTransactionJIFAS.Text.Focus();
            Pages.JournalTransactionJIFAS.Text.MouseClick();
            Manager.Desktop.KeyBoard.TypeText("fa", 50, 100, true);
            
        }
    }
}
