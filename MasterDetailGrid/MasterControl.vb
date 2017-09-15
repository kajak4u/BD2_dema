Imports System.Drawing
Imports System.Windows.Forms

Public Class MasterControl
    Inherits DataGridView
#Region "Variables"
    Friend rowCurrent As New List(Of Integer)
    Private _childView As New detailControl
    Private _myForeignKey As String
    Public Property childView As detailControl
        Get
            Return _childView
        End Get
        Set(value As detailControl)
            RemoveHandler _childView.SizeChanged, AddressOf Me.ResizeCurrentRow
            Me.Controls.Remove(_childView)
            value.Parent = Me
            _childView = value
            Me.Controls.Add(value)
            AddHandler value.SizeChanged, AddressOf Me.ResizeCurrentRow
        End Set
    End Property
    Friend rowDefaultHeight = 22
    Friend rowExpandedHeight = 300
    Friend rowDefaultDivider = 0
    Friend rowExpandedDivider = 300 - 22
    Friend rowDividerMargin = 5
    Friend collapseRow As Boolean
    'Public childView As New detailControl With {.Height = rowExpandedDivider - rowDividerMargin * 2, .Visible = False}
    '
    Friend WithEvents RowHeaderIconList As System.Windows.Forms.ImageList
    Private components As System.ComponentModel.IContainer
    '
    Dim _cDataset As DataSet
    Dim _filterFormat As String
    Enum rowHeaderIcons
        expand = 0
        collapse = 1
    End Enum
#End Region
#Region "Initialze and Display"
    Sub New()
        childView.Visible = False
        Me.Controls.Add(childView)
        InitializeComponent()
        AddHandler Me.DataBindingComplete, AddressOf Me.Handler_DataSourceChanged
        AddHandler childView.SizeChanged, AddressOf Me.ResizeCurrentRow
        Debug.Print("I'm alive!!!")
    End Sub

    Private Sub ResizeCurrentRow(sender As Object, e As EventArgs)
        If Me.CurrentRow IsNot Nothing Then
            Me.CurrentRow.Height = childView.Size.Height + rowDefaultHeight + 10
            Me.CurrentRow.DividerHeight = childView.Size.Height
        End If
    End Sub

    Private Sub Handler_DataSourceChanged(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        RefreshFilters()
    End Sub

    Public Property dataset() As DataSet
        Get
            Return _cDataset
        End Get
        Set(value As DataSet)
            _cDataset = value
            childView._cDataset = value
        End Set
    End Property
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterControl))
        Me.RowHeaderIconList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RowHeaderIconList
        '
        Me.RowHeaderIconList.ImageStream = CType(resources.GetObject("RowHeaderIconList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.RowHeaderIconList.TransparentColor = System.Drawing.Color.Transparent
        Me.RowHeaderIconList.Images.SetKeyName(0, "expand.png")
        Me.RowHeaderIconList.Images.SetKeyName(1, "collapse.png")
        '
        'MasterControl
        '
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "DataControl"
    Public Property foreignKey() As String
        Get
            Return _myForeignKey
        End Get
        Set(ByVal value As String)
            _myForeignKey = value
        End Set
    End Property
    Private Sub RefreshFilters()
        Debug.Print("RefreshFilters")
        Dim ds As DataSet
        Dim table As DataTable
        Dim runtimeTable As Boolean
        Dim runtimeIntField As Boolean
        runtimeTable = False
        table = Nothing
        If TypeOf Me.DataSource Is BindingSource Then
            If TypeOf Me.DataSource.DataSource Is DataSet Then
                ds = Me.DataSource.DataSource
                table = ds.Tables.Item(Me.DataSource.DataMember)
            ElseIf TypeName(Me.DataSource.DataSource) = "RuntimeType" Then
                runtimeTable = True
                For Each field As System.Reflection.PropertyInfo In Me.DataSource.DataSource.DeclaredProperties
                    If field.Name = foreignKey Then
                        runtimeIntField = field.PropertyType.FullName = "System.Int32"
                    End If
                Next

            Else
                'table = Me.DataSource.DataSource
            End If
            '        ElseIf TypeOf Me.DataSource Is DataView Then
            '            dataview = Me.DataSource
        Else
            table = Me.DataSource
        End If
        MessageBox.Show("Refresh Filters" & (table Is Nothing) & runtimeTable & runtimeIntField)
        If (runtimeTable AndAlso runtimeIntField) _
        OrElse (table IsNot Nothing AndAlso table.Columns(foreignKey).DataType.Equals(GetType(Integer))) _
        OrElse (table IsNot Nothing AndAlso table.Columns(foreignKey).DataType.Equals(GetType(Double))) _
        OrElse (table IsNot Nothing AndAlso table.Columns(foreignKey).DataType.Equals(GetType(Decimal))) _
        Then
            _filterFormat = foreignKey & "={0}"
        Else
            _filterFormat = foreignKey & "='{0}'"
        End If
        childView.RefreshTabs()
        MessageBox.Show("FINITO")
    End Sub
#End Region
#Region "GridEvents"
    Private Sub MasterControl_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MyBase.RowHeaderMouseClick
        Dim rect As Rectangle = New Rectangle((rowDefaultHeight - 16) / 2, (rowDefaultHeight - 16) / 2, 16, 16)
        If rect.Contains(e.Location) Then
            If rowCurrent.Contains(e.RowIndex) Then
                rowCurrent.Clear()
                Me.Rows(e.RowIndex).Height = rowDefaultHeight
                Me.Rows(e.RowIndex).DividerHeight = rowDefaultDivider
            Else
                If Not rowCurrent.Count = 0 Then
                    Dim eRow = rowCurrent(0)
                    rowCurrent.Clear()
                    Me.Rows(eRow).Height = rowDefaultHeight
                    Me.Rows(eRow).DividerHeight = rowDefaultDivider
                    Me.ClearSelection()
                    collapseRow = True
                    Me.Rows(eRow).Selected = True
                End If
                rowCurrent.Add(e.RowIndex)
                'Me.Rows(e.RowIndex).Height = rowExpandedHeight
                'Me.Rows(e.RowIndex).DividerHeight = rowExpandedDivider
            End If
            Me.ClearSelection()
            collapseRow = True
            Me.Rows(e.RowIndex).Selected = True
        Else
            collapseRow = False
        End If
    End Sub
    Private Sub MasterControl_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles MyBase.RowPostPaint
        'set childview control
        Dim rect = New Rectangle(e.RowBounds.X + ((rowDefaultHeight - 16) / 2), e.RowBounds.Y + ((rowDefaultHeight - 16) / 2), 16, 16)
        If collapseRow Then
            If rowCurrent.Contains(e.RowIndex) Then
                sender.Rows(e.RowIndex).DividerHeight = sender.Rows(e.RowIndex).height - rowDefaultHeight
                e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.collapse), rect)
                childView.Location = New Point(e.RowBounds.Left + sender.RowHeadersWidth, e.RowBounds.Top + rowDefaultHeight + 5)
                childView.Width = e.RowBounds.Right - sender.rowheaderswidth
                'childView.Height = sender.Rows(e.RowIndex).DividerHeight - 10
                childView.Visible = True
            Else
                childView.Visible = False
                e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.expand), rect)
            End If
            collapseRow = False
        Else
            If rowCurrent.Contains(e.RowIndex) Then
                sender.Rows(e.RowIndex).DividerHeight = sender.Rows(e.RowIndex).height - rowDefaultHeight
                e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.collapse), rect)
                childView.Location = New Point(e.RowBounds.Left + sender.RowHeadersWidth, e.RowBounds.Top + rowDefaultHeight + 5)
                childView.Width = e.RowBounds.Right - sender.rowheaderswidth
                'childView.Height = sender.Rows(e.RowIndex).DividerHeight - 10
                childView.Visible = True
            Else
                e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.expand), rect)
            End If
        End If
        rowPostPaint_HeaderCount(sender, e)
    End Sub
    Private Sub MasterControl_Scroll(sender As Object, e As ScrollEventArgs) Handles MyBase.Scroll
        If Not rowCurrent.Count = 0 Then
            collapseRow = True
            Me.ClearSelection()
            Me.Rows(rowCurrent(0)).Selected = True
        End If
    End Sub
    Private Sub MasterControl_SelectionChanged(sender As Object, e As EventArgs) Handles MyBase.SelectionChanged
        Debug.Print("In selectionChanged")
        If Not Me.RowCount = 0 Then
            If rowCurrent.Contains(Me.CurrentRow.Index) Then
                '''''''''' childGrid - to jest puste!!! - tu jest pies pogrzebany...
                For Each cGrid As DataGridView In childView.childGrid
                    CType(cGrid.DataSource, BindingSource).Filter = String.Format(_filterFormat, Me(_myForeignKey, Me.CurrentRow.Index).Value)
                    Debug.Print("Set filter to " & String.Format(_filterFormat, Me(_myForeignKey, Me.CurrentRow.Index).Value))
                Next
                childView.RecalcHeight()
                'Me.CurrentRow.Height = childView.Size.Height + rowDefaultHeight
                'Me.CurrentRow.DividerHeight = childView.Size.Height
            End If
        End If
    End Sub
#End Region
End Class
