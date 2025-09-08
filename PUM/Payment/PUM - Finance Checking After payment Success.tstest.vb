Imports Telerik.TestStudio.Translators.Common
Imports Telerik.TestingFramework.Controls.TelerikUI.Blazor
Imports Telerik.TestingFramework.Controls.KendoUI.Angular
Imports Telerik.TestingFramework.Controls.KendoUI
Imports Telerik.WebAii.Controls.Html
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Linq

Imports ArtOfTest.Common.UnitTesting
Imports ArtOfTest.WebAii.Core
Imports ArtOfTest.WebAii.Controls.HtmlControls
Imports ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts
Imports ArtOfTest.WebAii.Design
Imports ArtOfTest.WebAii.Design.Execution
Imports ArtOfTest.WebAii.ObjectModel
Imports ArtOfTest.WebAii.Silverlight
Imports ArtOfTest.WebAii.Silverlight.UI
Imports ArtOfTest.WebAii.DesktopAutomation
Imports ArtOfTest.WebAii.DesktopAutomation.Controls
Imports ArtOfTest.WebAii.DesktopAutomation.FindExpressions

Namespace Jifas

    Public Class PUM___Finance_Checking_After_payment_Success
        Inherits BaseWebAiiTest

#Region "[ Dynamic Pages Reference ]"

        Private _pages As Pages
        
        '''<summary>
        ''' Gets the Pages object that has references
        ''' to all the elements, frames or regions
        ''' in this project.
        '''</summary>
        Public ReadOnly Property Pages() As Pages
            Get
                If (_pages Is Nothing) Then
                    _pages = New Pages(Manager.Current)
                End If
                Return _pages
            End Get
        End Property
        
#End Region
        
        ' Add your test methods here...


        <CodedStep("Desktop command: Drag & Drop ActionLink to Window Target")> _
        Public Sub PUM__Finance_Checking_After_payment_Success_CodedStep()
            'Desktop command: Drag & Drop ActionLink to Window Target
            Pages.PaymentPUMJIFAS.ActionLink.Wait.ForExists(30000)
            ActiveBrowser.ResizeContent(0, 0, 1432, 774)
            ActiveBrowser.ScrollBy(0, 0)
            Pages.PaymentPUMJIFAS.ActionLink.DragToWindowLocation(ArtOfTest.Common.OffsetReference.TopLeftCorner, 50, 13, true, ArtOfTest.Common.OffsetReference.TopLeftCorner, 1360, 284, true)
            
        End Sub

        <CodedStep("Click 'Div'")> _
        Public Sub PUM__Finance_Checking_After_payment_Success_CodedStep1()
            ActiveBrowser.Actions.InvokeScript("document.querySelector('.k-window').scrollTop=300;")
        End Sub
    End Class
End Namespace