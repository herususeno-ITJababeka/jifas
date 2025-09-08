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

    Public Class PUM___Payment_Pum
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


        <CodedStep("Desktop command: LeftClick on x4c768ba7Af6a4118A82c624dfb6b0144Div00")> _
        Public Sub PUM__Payment_Pum_CodedStep()
            'Desktop command: LeftClick on x4c768ba7Af6a4118A82c624dfb6b0144Div00
            Pages.PaymentPUMJIFAS.x4c768ba7Af6a4118A82c624dfb6b0144Div00.Wait.ForExists(30000)
            Pages.PaymentPUMJIFAS.x4c768ba7Af6a4118A82c624dfb6b0144Div00.MouseClick(ArtOfTest.WebAii.Core.MouseClickType.LeftClick, 0, 0, ArtOfTest.Common.OffsetReference.AbsoluteCenter)  
        End Sub
    End Class
End Namespace