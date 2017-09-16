Imports System.Drawing
Imports System.Windows.Forms

Public Class detailControl
    Inherits TabControl
#Region "Variables"
    Friend childGrid As New List(Of DataGridView)
    Friend _cDataset As DataSet
    Public Sub New()
        AddHandler Me.Selected, AddressOf Me.RecalcHeight
        AddHandler Me.VisibleChanged, AddressOf Me.RecalcHeight
    End Sub

    Private Sub RecalcHeight(sender As Object, e As EventArgs)
        If Me.Visible Then
            RecalcHeight()
        End If
    End Sub
    Public Sub RecalcHeight()
        Dim currentPage As TabPage = Me.SelectedTab
        Dim grid As DataGridView
        For Each child In childGrid
            If child.Parent Is currentPage Then
                grid = child
                Exit For
            End If
        Next
        If grid Is Nothing Then
            Return
        End If
        Dim height As Integer = 0
        For Each row As DataGridViewRow In grid.Rows
            height += row.Height
        Next
        height += grid.ColumnHeadersHeight ' naglowki tabel
        height += Me.ItemSize.Height 'naglowki tabPages
        height += Me.Padding.Y * 2
        height += currentPage.Padding.Top + currentPage.Padding.Bottom
        Me.Size = New Size(Me.Parent.ClientSize.Width, height + 10)
    End Sub
#End Region
#Region "Populate Childview"
    Public Sub Add(ByVal tableName As String, ByVal pageCaption As String)
        Dim tPage As New TabPage With {.Text = pageCaption}
        Me.TabPages.Add(tPage)
        Dim newGrid As New DataGridView With {.Dock = DockStyle.Fill, .DataSource = New DataView(_cDataset.Tables(tableName))}
        tPage.Controls.Add(newGrid)
        applyGridTheme(newGrid)
        AddHandler newGrid.RowPostPaint, AddressOf rowPostPaint_HeaderCount
        childGrid.Add(newGrid)
    End Sub

    Public Sub RefreshTabs()
        childGrid.Clear()
        For Each page As TabPage In Me.Controls
            For Each child As Control In page.Controls
                If TypeOf child Is DataGridView Then
                    childGrid.Add(child)
                End If
            Next
        Next
    End Sub
#End Region

End Class
