<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetApp
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupSet = New System.Windows.Forms.GroupBox()
        Me.ListNum = New System.Windows.Forms.NumericUpDown()
        Me.MAX = New System.Windows.Forms.NumericUpDown()
        Me.R_NO = New System.Windows.Forms.RadioButton()
        Me.R_YES = New System.Windows.Forms.RadioButton()
        Me.LAction = New System.Windows.Forms.Label()
        Me.LabelMlist = New System.Windows.Forms.Label()
        Me.LabelMax = New System.Windows.Forms.Label()
        Me.SaveSet = New System.Windows.Forms.Button()
        Me.GroupType = New System.Windows.Forms.GroupBox()
        Me.type1 = New System.Windows.Forms.RadioButton()
        Me.type2 = New System.Windows.Forms.RadioButton()
        Me.GroupSet.SuspendLayout()
        CType(Me.ListNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupType.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupSet
        '
        Me.GroupSet.Controls.Add(Me.ListNum)
        Me.GroupSet.Controls.Add(Me.MAX)
        Me.GroupSet.Controls.Add(Me.R_NO)
        Me.GroupSet.Controls.Add(Me.R_YES)
        Me.GroupSet.Controls.Add(Me.LAction)
        Me.GroupSet.Controls.Add(Me.LabelMlist)
        Me.GroupSet.Controls.Add(Me.LabelMax)
        Me.GroupSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupSet.Location = New System.Drawing.Point(12, 12)
        Me.GroupSet.Name = "GroupSet"
        Me.GroupSet.Size = New System.Drawing.Size(215, 140)
        Me.GroupSet.TabIndex = 0
        Me.GroupSet.TabStop = False
        Me.GroupSet.Text = "Основные настройки"
        '
        'ListNum
        '
        Me.ListNum.Location = New System.Drawing.Point(154, 57)
        Me.ListNum.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ListNum.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ListNum.Name = "ListNum"
        Me.ListNum.Size = New System.Drawing.Size(55, 20)
        Me.ListNum.TabIndex = 11
        Me.ListNum.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'MAX
        '
        Me.MAX.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.MAX.Location = New System.Drawing.Point(154, 30)
        Me.MAX.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.MAX.Minimum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.MAX.Name = "MAX"
        Me.MAX.Size = New System.Drawing.Size(55, 20)
        Me.MAX.TabIndex = 10
        Me.MAX.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'R_NO
        '
        Me.R_NO.AutoSize = True
        Me.R_NO.Location = New System.Drawing.Point(114, 109)
        Me.R_NO.Name = "R_NO"
        Me.R_NO.Size = New System.Drawing.Size(68, 17)
        Me.R_NO.TabIndex = 9
        Me.R_NO.Text = "Удалить"
        Me.R_NO.UseVisualStyleBackColor = True
        '
        'R_YES
        '
        Me.R_YES.AutoSize = True
        Me.R_YES.Checked = True
        Me.R_YES.Location = New System.Drawing.Point(9, 109)
        Me.R_YES.Name = "R_YES"
        Me.R_YES.Size = New System.Drawing.Size(73, 17)
        Me.R_YES.TabIndex = 8
        Me.R_YES.TabStop = True
        Me.R_YES.Text = "Оставить"
        Me.R_YES.UseVisualStyleBackColor = True
        '
        'LAction
        '
        Me.LAction.AutoSize = True
        Me.LAction.Location = New System.Drawing.Point(6, 86)
        Me.LAction.Name = "LAction"
        Me.LAction.Size = New System.Drawing.Size(183, 13)
        Me.LAction.TabIndex = 4
        Me.LAction.Text = "Действие, при отсутствии замены"
        '
        'LabelMlist
        '
        Me.LabelMlist.AutoSize = True
        Me.LabelMlist.Location = New System.Drawing.Point(6, 59)
        Me.LabelMlist.Name = "LabelMlist"
        Me.LabelMlist.Size = New System.Drawing.Size(86, 13)
        Me.LabelMlist.TabIndex = 2
        Me.LabelMlist.Text = "Кол-во списков"
        '
        'LabelMax
        '
        Me.LabelMax.AutoSize = True
        Me.LabelMax.Location = New System.Drawing.Point(6, 32)
        Me.LabelMax.Name = "LabelMax"
        Me.LabelMax.Size = New System.Drawing.Size(122, 13)
        Me.LabelMax.TabIndex = 0
        Me.LabelMax.Text = "MAX кол-во абонентов"
        '
        'SaveSet
        '
        Me.SaveSet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveSet.Location = New System.Drawing.Point(103, 239)
        Me.SaveSet.Name = "SaveSet"
        Me.SaveSet.Size = New System.Drawing.Size(124, 23)
        Me.SaveSet.TabIndex = 1
        Me.SaveSet.Text = "Сохранить и выйти"
        Me.SaveSet.UseVisualStyleBackColor = True
        '
        'GroupType
        '
        Me.GroupType.Controls.Add(Me.type2)
        Me.GroupType.Controls.Add(Me.type1)
        Me.GroupType.Location = New System.Drawing.Point(12, 158)
        Me.GroupType.Name = "GroupType"
        Me.GroupType.Size = New System.Drawing.Size(215, 75)
        Me.GroupType.TabIndex = 2
        Me.GroupType.TabStop = False
        Me.GroupType.Text = "Режим работы"
        '
        'type1
        '
        Me.type1.AutoSize = True
        Me.type1.Location = New System.Drawing.Point(9, 19)
        Me.type1.Name = "type1"
        Me.type1.Size = New System.Drawing.Size(101, 17)
        Me.type1.TabIndex = 0
        Me.type1.Text = "Только анализ"
        Me.type1.UseVisualStyleBackColor = True
        '
        'type2
        '
        Me.type2.AutoSize = True
        Me.type2.Checked = True
        Me.type2.Location = New System.Drawing.Point(9, 42)
        Me.type2.Name = "type2"
        Me.type2.Size = New System.Drawing.Size(162, 17)
        Me.type2.TabIndex = 1
        Me.type2.TabStop = True
        Me.type2.Text = "Анализ и загрузка в Рупор"
        Me.type2.UseVisualStyleBackColor = True
        '
        'SetApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 270)
        Me.Controls.Add(Me.GroupType)
        Me.Controls.Add(Me.SaveSet)
        Me.Controls.Add(Me.GroupSet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetApp"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EX-Rupor"
        Me.GroupSet.ResumeLayout(False)
        Me.GroupSet.PerformLayout()
        CType(Me.ListNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupType.ResumeLayout(False)
        Me.GroupType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupSet As GroupBox
    Friend WithEvents LabelMax As Label
    Friend WithEvents R_NO As RadioButton
    Friend WithEvents R_YES As RadioButton
    Friend WithEvents LAction As Label
    Friend WithEvents LabelMlist As Label
    Friend WithEvents SaveSet As Button
    Friend WithEvents ListNum As NumericUpDown
    Friend WithEvents MAX As NumericUpDown
    Friend WithEvents GroupType As GroupBox
    Friend WithEvents type2 As RadioButton
    Friend WithEvents type1 As RadioButton
End Class
