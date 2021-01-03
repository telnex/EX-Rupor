<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.GroupBoxInfo = New System.Windows.Forms.GroupBox()
        Me.TextInfo = New System.Windows.Forms.TextBox()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.BoxList = New System.Windows.Forms.GroupBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListBox_1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListBox_2 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ListBox_3 = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ListBox_4 = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ListBox_5 = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.ListBox_6 = New System.Windows.Forms.TextBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.ListBox_7 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.OpenBt = New System.Windows.Forms.Button()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.LoadBt = New System.Windows.Forms.Button()
        Me.TestBt = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBoxInfo.SuspendLayout()
        Me.BoxList.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxInfo
        '
        Me.GroupBoxInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxInfo.Controls.Add(Me.TextInfo)
        Me.GroupBoxInfo.Controls.Add(Me.ProgressBar)
        Me.GroupBoxInfo.Location = New System.Drawing.Point(12, 78)
        Me.GroupBoxInfo.Name = "GroupBoxInfo"
        Me.GroupBoxInfo.Size = New System.Drawing.Size(377, 360)
        Me.GroupBoxInfo.TabIndex = 0
        Me.GroupBoxInfo.TabStop = False
        Me.GroupBoxInfo.Text = "Информация"
        '
        'TextInfo
        '
        Me.TextInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextInfo.BackColor = System.Drawing.Color.White
        Me.TextInfo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextInfo.Location = New System.Drawing.Point(7, 20)
        Me.TextInfo.Multiline = True
        Me.TextInfo.Name = "TextInfo"
        Me.TextInfo.ReadOnly = True
        Me.TextInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextInfo.Size = New System.Drawing.Size(364, 311)
        Me.TextInfo.TabIndex = 500
        Me.TextInfo.TabStop = False
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(7, 337)
        Me.ProgressBar.Maximum = 300
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(364, 16)
        Me.ProgressBar.TabIndex = 1
        '
        'BoxList
        '
        Me.BoxList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoxList.Controls.Add(Me.TabControl)
        Me.BoxList.Location = New System.Drawing.Point(395, 78)
        Me.BoxList.Name = "BoxList"
        Me.BoxList.Size = New System.Drawing.Size(393, 360)
        Me.BoxList.TabIndex = 1
        Me.BoxList.TabStop = False
        Me.BoxList.Text = "Списки оповещения"
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Controls.Add(Me.TabPage4)
        Me.TabControl.Controls.Add(Me.TabPage5)
        Me.TabControl.Controls.Add(Me.TabPage6)
        Me.TabControl.Controls.Add(Me.TabPage7)
        Me.TabControl.Controls.Add(Me.TabPage8)
        Me.TabControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl.Location = New System.Drawing.Point(7, 19)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(380, 334)
        Me.TabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListBox_1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(372, 308)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "1 список"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListBox_1
        '
        Me.ListBox_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox_1.BackColor = System.Drawing.Color.White
        Me.ListBox_1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox_1.Multiline = True
        Me.ListBox_1.Name = "ListBox_1"
        Me.ListBox_1.ReadOnly = True
        Me.ListBox_1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ListBox_1.Size = New System.Drawing.Size(372, 308)
        Me.ListBox_1.TabIndex = 501
        Me.ListBox_1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListBox_2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(372, 308)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "2 список"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListBox_2
        '
        Me.ListBox_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox_2.BackColor = System.Drawing.Color.White
        Me.ListBox_2.Location = New System.Drawing.Point(0, 0)
        Me.ListBox_2.Multiline = True
        Me.ListBox_2.Name = "ListBox_2"
        Me.ListBox_2.ReadOnly = True
        Me.ListBox_2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ListBox_2.Size = New System.Drawing.Size(372, 308)
        Me.ListBox_2.TabIndex = 502
        Me.ListBox_2.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ListBox_3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(372, 308)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "3 список"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ListBox_3
        '
        Me.ListBox_3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox_3.BackColor = System.Drawing.Color.White
        Me.ListBox_3.Location = New System.Drawing.Point(0, 0)
        Me.ListBox_3.Multiline = True
        Me.ListBox_3.Name = "ListBox_3"
        Me.ListBox_3.ReadOnly = True
        Me.ListBox_3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ListBox_3.Size = New System.Drawing.Size(372, 308)
        Me.ListBox_3.TabIndex = 503
        Me.ListBox_3.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ListBox_4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(372, 308)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "4 список"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ListBox_4
        '
        Me.ListBox_4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox_4.BackColor = System.Drawing.Color.White
        Me.ListBox_4.Location = New System.Drawing.Point(0, 0)
        Me.ListBox_4.Multiline = True
        Me.ListBox_4.Name = "ListBox_4"
        Me.ListBox_4.ReadOnly = True
        Me.ListBox_4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ListBox_4.Size = New System.Drawing.Size(372, 308)
        Me.ListBox_4.TabIndex = 504
        Me.ListBox_4.TabStop = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ListBox_5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(372, 308)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "5 список"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ListBox_5
        '
        Me.ListBox_5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox_5.BackColor = System.Drawing.Color.White
        Me.ListBox_5.Location = New System.Drawing.Point(0, 0)
        Me.ListBox_5.Multiline = True
        Me.ListBox_5.Name = "ListBox_5"
        Me.ListBox_5.ReadOnly = True
        Me.ListBox_5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ListBox_5.Size = New System.Drawing.Size(372, 308)
        Me.ListBox_5.TabIndex = 502
        Me.ListBox_5.TabStop = False
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.ListBox_6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(372, 308)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "6 список"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'ListBox_6
        '
        Me.ListBox_6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox_6.BackColor = System.Drawing.Color.White
        Me.ListBox_6.Location = New System.Drawing.Point(0, 0)
        Me.ListBox_6.Multiline = True
        Me.ListBox_6.Name = "ListBox_6"
        Me.ListBox_6.ReadOnly = True
        Me.ListBox_6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ListBox_6.Size = New System.Drawing.Size(372, 308)
        Me.ListBox_6.TabIndex = 502
        Me.ListBox_6.TabStop = False
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.ListBox_7)
        Me.TabPage7.Controls.Add(Me.TextBox3)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(372, 308)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "7 список"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'ListBox_7
        '
        Me.ListBox_7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox_7.BackColor = System.Drawing.Color.White
        Me.ListBox_7.Location = New System.Drawing.Point(0, 0)
        Me.ListBox_7.Multiline = True
        Me.ListBox_7.Name = "ListBox_7"
        Me.ListBox_7.ReadOnly = True
        Me.ListBox_7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ListBox_7.Size = New System.Drawing.Size(372, 308)
        Me.ListBox_7.TabIndex = 503
        Me.ListBox_7.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(0, 0)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(372, 308)
        Me.TextBox3.TabIndex = 502
        Me.TextBox3.TabStop = False
        '
        'TabPage8
        '
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(372, 308)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "8 список"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'OpenBt
        '
        Me.OpenBt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OpenBt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.OpenBt.Location = New System.Drawing.Point(12, 13)
        Me.OpenBt.Name = "OpenBt"
        Me.OpenBt.Size = New System.Drawing.Size(125, 37)
        Me.OpenBt.TabIndex = 699
        Me.OpenBt.Text = "Выбрать файл"
        Me.OpenBt.UseVisualStyleBackColor = True
        '
        'Panel
        '
        Me.Panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel.Controls.Add(Me.Title)
        Me.Panel.Controls.Add(Me.LoadBt)
        Me.Panel.Controls.Add(Me.TestBt)
        Me.Panel.Controls.Add(Me.OpenBt)
        Me.Panel.Location = New System.Drawing.Point(0, 1)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(800, 65)
        Me.Panel.TabIndex = 6
        '
        'Title
        '
        Me.Title.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Title.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Title.Location = New System.Drawing.Point(395, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(393, 65)
        Me.Title.TabIndex = 7
        Me.Title.Text = "Программа автоматического обновления списков оповещения системы «Рупор»"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoadBt
        '
        Me.LoadBt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoadBt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LoadBt.Location = New System.Drawing.Point(264, 13)
        Me.LoadBt.Name = "LoadBt"
        Me.LoadBt.Size = New System.Drawing.Size(125, 37)
        Me.LoadBt.TabIndex = 698
        Me.LoadBt.Text = "Загрузить в ""Рупор"""
        Me.LoadBt.UseVisualStyleBackColor = True
        '
        'TestBt
        '
        Me.TestBt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TestBt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TestBt.Location = New System.Drawing.Point(143, 13)
        Me.TestBt.Name = "TestBt"
        Me.TestBt.Size = New System.Drawing.Size(115, 37)
        Me.TestBt.TabIndex = 700
        Me.TestBt.Text = "Произвести анализ"
        Me.TestBt.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFile"
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BoxList)
        Me.Controls.Add(Me.GroupBoxInfo)
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form"
        Me.Text = "Обновление списков оповещения"
        Me.GroupBoxInfo.ResumeLayout(False)
        Me.GroupBoxInfo.PerformLayout()
        Me.BoxList.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxInfo As GroupBox
    Friend WithEvents BoxList As GroupBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents OpenBt As Button
    Friend WithEvents Panel As Panel
    Friend WithEvents LoadBt As Button
    Friend WithEvents TestBt As Button
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents Title As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents TextInfo As TextBox
    Friend WithEvents ListBox_1 As TextBox
    Friend WithEvents ListBox_2 As TextBox
    Friend WithEvents ListBox_3 As TextBox
    Friend WithEvents ListBox_4 As TextBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents ListBox_5 As TextBox
    Friend WithEvents ListBox_6 As TextBox
    Friend WithEvents ListBox_7 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
