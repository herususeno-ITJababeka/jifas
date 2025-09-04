Imports Telerik.TestStudio.Translators.Common
Imports Telerik.TestingFramework.Controls.TelerikUI.Blazor
Imports Telerik.TestingFramework.Controls.KendoUI.Angular
Imports Telerik.TestingFramework.Controls.KendoUI
Imports Telerik.WebAii.Controls.Html
Imports System
Imports System.Collections.Generic
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

    Public Class Submenu_PUM___Head_Approval
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


        <CodedStep("Desktop command: Drag & Drop BtnApproveButtonTag to Window Target")> _
        Public Sub Submenu_PUM__Head_Approval_CodedStep()
            'Desktop command: Drag & Drop BtnApproveButtonTag to Window Target
            Pages.PUMHeadApprovalJIFAS.BtnApproveButtonTag.Wait.ForExists(30000)
            ActiveBrowser.ResizeContent(0, 0, 1432, 774)
            ActiveBrowser.ScrollBy(0, 500)
            Pages.PUMHeadApprovalJIFAS.BtnApproveButtonTag.DragToWindowLocation(ArtOfTest.Common.OffsetReference.TopLeftCorner, 52, 6, true, ArtOfTest.Common.OffsetReference.AbsoluteCenter, 0, 0, true)
            
        End Sub

        <CodedStep("New Coded Step")> _
        Public Sub Submenu_PUM__Head_Approval_CodedStep1()
            ActiveBrowser.Actions.InvokeScript("document.querySelector('.k-window-content').scrollTop=300;")
        End Sub
    End Class
End Namespace