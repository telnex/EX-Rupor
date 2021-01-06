Imports Microsoft.Office.Interop 'Для работы с Excel
Imports System.Text.RegularExpressions 'Регулярные выражения

Public Class Form
    'Максимальное кол-во отстутствующих и абонентов в списке оповещения
    Public count As Integer = My.Settings.count
    'Список оповещения по умолчанию
    Public cell(My.Settings.list - 1) As String

    'Заполнение массива 
    Public Sub DataLoad()
        Dim ABC() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"}
        For ID = 0 To cell.GetUpperBound(0)
            cell(ID) = ABC(ID)
        Next
    End Sub
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Process.GetProcessesByName("EXCEL").Length > 1 Then
            MsgBox("Найдены активные процессы EXCEL, возможно, предыдущий запуск данного приложения завершился ошибкой!" & vbCrLf & vbCrLf & "Используя ДИСПЕТЧЕР ЗАДАЧ завершите все процессы EXCEL.EXE", 0)
        End If
        TestBt.Enabled = False
        LoadBt.Enabled = False
        TextInfo.Text = "Нажмите кнопку " & Chr(34) & "Выбрать файл" & Chr(34) & " для загрузки файла Excel, затем нажмите " & Chr(34) & "Произвести анализ" & Chr(34) & ", чтобы узнать изменения в списках оповещения." & vbCrLf & vbCrLf
        TextInfo.Text += "Количество отсутствующих и абонентов в одном списке оповещения не должно превышать:  " & count & " чел." & vbCrLf
        TextInfo.Text += "Количество списков оповещения:  " & My.Settings.list & " ." & vbCrLf
    End Sub
    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.Width > 1000 Then
            Title.Font = New Font("Cambria", 17, FontStyle.Bold)
        Else
            Title.Font = New Font("Cambria", 11.25, FontStyle.Bold)
        End If
    End Sub

    Private Sub OpenBt_Click(sender As Object, e As EventArgs) Handles OpenBt.Click
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog.Filter = "Файлы Excel (*.xlsx; *.xls)|*.xlsx; *.xlsx"
        OpenFileDialog.FileName = ""

        'Если пользователь не выбрал файл, закрываем приложени
        If OpenFileDialog.ShowDialog <> DialogResult.OK Then Me.Close()

        TextInfo.Text += vbCrLf & vbCrLf & "Открыт файл " & OpenFileDialog.FileName & vbCrLf
        TestBt.Enabled = True
        AddSet.Enabled = False
    End Sub
    Private Sub TestBt_Click(sender As Object, e As EventArgs) Handles TestBt.Click
        DataLoad()
        Me.Cursor = Cursors.WaitCursor

        'Список отсутствующих
        Dim OFFname As New Excel.Application
        Dim OFFname_Sheet As Excel.Worksheet
        OFFname.Workbooks.Open(OpenFileDialog.FileName)
        OFFname_Sheet = OFFname.Workbooks(1).Worksheets(1)

        'Проверяем что открыли
        If OFFname_Sheet.Range("A1:F10").Find("Справка") Is Nothing Then
            MsgBox("Возможно, Вы выбрали не тот файл!", 0)
        End If

        'Массив СПИСОК ОТСУТСТВУЮЩИХ
        Dim Zamena(count - 1) As String
        Dim ZamenaNAME(count - 1) As String

        For index As Integer = 0 To count - 1
            If OFFname_Sheet.Range("B" & index + 3).Value IsNot Nothing Then
                If Regex.IsMatch(OFFname_Sheet.Range("B" & index + 3).Value, "\w") = True Then
                    Zamena(index) = Trim(OFFname_Sheet.Range("B" & index + 3).Value)

                    'Обработка на тот случай, если для руководителя не указана замена
                    If OFFname_Sheet.Range("E" & index + 3).Value IsNot Nothing Then
                        If Regex.IsMatch(OFFname_Sheet.Range("E" & index + 3).Value, "\w") = True Then
                            ZamenaNAME(index) = Trim(OFFname_Sheet.Range("E" & index + 3).Value)
                        Else
                            ZamenaNAME(index) = Zamena(index)
                        End If
                    Else
                        If My.Settings.action = True Then
                            ZamenaNAME(index) = Zamena(index)
                        Else
                            Zamena(index) = "ERROR"
                            ZamenaNAME(index) = "ERROR"
                        End If
                    End If
                End If
            Else
                'Костыль для заполнения пустых элементов массива
                Zamena(index) = "ERROR"
                ZamenaNAME(index) = "ERROR"
            End If
        Next

        'Прогресс Бар
        ProgressBar.Value += 5

        'Закрываем файл со списком отсутствующих
        OFFname.Quit()
        OFFname = Nothing
        OFFname_Sheet = Nothing

        'Открываем список оповещения "по умолчанию"
        If IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.Desktop & "\setrupor\bookName.xlsx") = False Then
            MsgBox("Файл Excel со списками оповещения не найден!")
            Me.Close()
            Exit Sub
        End If
        Dim ListAlert As New Excel.Application
        Dim ListAlert_Sheet As Excel.Worksheet
        ListAlert.Workbooks.Open(My.Computer.FileSystem.SpecialDirectories.Desktop & "\setrupor\bookName.xlsx")
        ListAlert_Sheet = ListAlert.Workbooks(1).Worksheets(1)

        'Открываем Общий список
        If IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.Desktop & "\setrupor\mainNumber.xlsx") = False Then
            'Закрываем файл со списком оповещения "по умолчанию"
            ListAlert.Quit()
            ListAlert_Sheet = Nothing
            ListAlert = Nothing

            MsgBox("Файл Excel с базой контактов не найден!", 0)

            Me.Close()
            Exit Sub
        End If

        Dim ListBaz As New Excel.Application
        Dim ListBaz_Sheet As Excel.Worksheet
        ListBaz.Workbooks.Open(My.Computer.FileSystem.SpecialDirectories.Desktop & "\setrupor\mainNumber.xlsx")
        ListBaz_Sheet = ListBaz.Workbooks(1).Worksheets(1)

        'Прогресс Бар
        ProgressBar.Value += 5

        'Удаляем все из папки СПИСКИ ОПОВЕЩЕНИЯ
        For Each deleteFile In IO.Directory.GetFiles(My.Computer.FileSystem.SpecialDirectories.Desktop & "\Списки оповещения\", "*.*", IO.SearchOption.TopDirectoryOnly)
            IO.File.Delete(deleteFile)
        Next


        'Настройки для работы цикла
        Dim marker As Boolean
        Dim link As String
        Dim Num As Integer = 0
        Dim tbArray() As TextBox = New TextBox() {ListBox_1, ListBox_2, ListBox_3, ListBox_4, ListBox_5, ListBox_6, ListBox_7, ListBox_8, ListBox_9, ListBox_10}


        'Создаем новый файл Excel
        Dim List As New Excel.Application
        Dim List_Sheet As Excel.Worksheet
        List.Workbooks.Add()
        List_Sheet = List.Workbooks(1).Worksheets(1)

        TextInfo.Text = "ПРОЦЕСС ЗАПУЩЕН"

        'ОСНОВНОЙ ПРОЦЕСС
        For ID As Integer = 0 To cell.GetUpperBound(0)

            TextInfo.Text += vbCrLf & vbCrLf & "В " & ID + 1 & " списке отсутствуют:" & vbCrLf & vbCrLf


            TabControl.SelectedIndex = ID 'Активная вкладка
            'Очищаем файл 
            List_Sheet.Range("A1:H50").Clear()

            'Форматируем поля
            List_Sheet.Columns("E").NumberFormat = "0"
            List_Sheet.Columns("F").NumberFormat = "0"
            List_Sheet.Columns("G").NumberFormat = "0"
            List_Sheet.Columns("H").NumberFormat = "0"

            For index As Integer = 2 To count + 1
                marker = True
                For key = 0 To Zamena.GetUpperBound(0) 'Индекс последнего элемента
                    If ListAlert_Sheet.Range(cell(ID) & index).Value IsNot Nothing And StrComp(ListAlert_Sheet.Range(cell(ID) & index).Value, Zamena(key), 1) = 0 Then

                        'Поиск фамилии в общей базе
                        If ListBaz_Sheet.Range("A2:A500").Find(ZamenaNAME(key)) Is Nothing Then
                            MsgBox("Ошибка #1. [" & ZamenaNAME(key) & "] Пользователь не найден!", 0)

                            List.Quit()
                            List_Sheet = Nothing
                            List = Nothing

                            'Закрываем общий список
                            ListBaz.Quit()
                            ListBaz_Sheet = Nothing
                            ListBaz = Nothing

                            'Закрываем файл со списком оповещения "по умолчанию"
                            ListAlert.Quit()
                            ListAlert_Sheet = Nothing
                            ListAlert = Nothing

                            Me.Close()
                            Exit Sub
                        Else
                            link = Mid(ListBaz_Sheet.Range("A2:A500").Find(ZamenaNAME(key)).Address, 4)

                            'Добавление записи в файл
                            List_Sheet.Range("A" & index).Value = ListBaz_Sheet.Range("A" & link).Value
                            List_Sheet.Range("E" & index).Value = ListBaz_Sheet.Range("E" & link).Value
                            List_Sheet.Range("F" & index).Value = ListBaz_Sheet.Range("F" & link).Value
                            List_Sheet.Range("G" & index).Value = ListBaz_Sheet.Range("G" & link).Value
                            List_Sheet.Range("H" & index).Value = ListBaz_Sheet.Range("H" & link).Value
                        End If

                        'Вывод в textBox
                        TextInfo.Text += "# " & ListAlert_Sheet.Range(cell(ID) & index).Value & " вместо него " & ListBaz_Sheet.Range("A" & link).Value & vbCrLf
                        tbArray(ID).Text += ListBaz_Sheet.Range("A" & link).Value & " -> " & ListAlert_Sheet.Range(cell(ID) & index).Value & vbCrLf
                        Num += 1

                        marker = False
                        Exit For
                    End If
                Next
                If marker = True And ListAlert_Sheet.Range(cell(ID) & index).Value IsNot Nothing Then

                    'Поиск фамилии в общей базе
                    If ListBaz_Sheet.Range("A2:A300").Find(ListAlert_Sheet.Range(cell(ID) & index).Value).Value Is Nothing Then
                        MsgBox("Ошибка #1. Пользователь не найден!", 0)
                        List.Quit()
                        List_Sheet = Nothing
                        List = Nothing

                        'Закрываем общий список
                        ListBaz.Quit()
                        ListBaz_Sheet = Nothing
                        ListBaz = Nothing

                        'Закрываем файл со списком оповещения "по умолчанию"
                        ListAlert.Quit()
                        ListAlert_Sheet = Nothing
                        ListAlert = Nothing

                        Me.Close()
                        Exit Sub
                    End If

                    link = Mid(ListBaz_Sheet.Range("A2:A300").Find(ListAlert_Sheet.Range(cell(ID) & index).Value).Address, 4)
                    List_Sheet.Range("A" & index).Value = ListBaz_Sheet.Range("A" & link).Value
                    List_Sheet.Range("E" & index).Value = ListBaz_Sheet.Range("E" & link).Value
                    List_Sheet.Range("F" & index).Value = ListBaz_Sheet.Range("F" & link).Value
                    List_Sheet.Range("G" & index).Value = ListBaz_Sheet.Range("G" & link).Value
                    List_Sheet.Range("H" & index).Value = ListBaz_Sheet.Range("H" & link).Value

                    'Вывод в textBox
                    tbArray(ID).Text += ListBaz_Sheet.Range("A" & link).Value & vbCrLf
                    Num += 1

                End If
            Next

            'Количество абонентов в списке
            tbArray(ID).Text += vbCrLf & "Всего: " & Num
            Num = 0

            ' Сохраняем и закрываем список
            List_Sheet.SaveAs(My.Computer.FileSystem.SpecialDirectories.Desktop & "\Списки оповещения\" & ID + 1 & "  список оповещения.xlsx")

            'Прогресс Бар
            ProgressBar.Value = ((ID + 1) / My.Settings.list) * 100
        Next

        'Закрываем новый список оповещения
        List.Quit()
        List_Sheet = Nothing
        List = Nothing

        'Закрываем общий список
        ListBaz.Quit()
        ListBaz_Sheet = Nothing
        ListBaz = Nothing

        'Закрываем файл со списком оповещения "по умолчанию"
        ListAlert.Quit()
        ListAlert_Sheet = Nothing
        ListAlert = Nothing

        LoadBt.Enabled = True
        TestBt.Enabled = False
        OpenBt.Enabled = False

        'Вывод инфы
        TextInfo.Text += vbCrLf & vbCrLf & "Процесс анализа завершен, нажмите кнопку " & Chr(34) & "Загрузить" & Chr(34) & "." & vbCrLf & vbCrLf
        TextInfo.SelectionStart = TextInfo.Text.Length
        TextInfo.ScrollToCaret()

        'Избавляемся от мусора принудительно
        GC.Collect()

        'Прогресс Бар
        ProgressBar.Value = 120
        Me.Cursor = Cursors.Default

    End Sub
    Private Sub LoadBt_Click(sender As Object, e As EventArgs) Handles LoadBt.Click
        'Отключаем все кнопки
        TestBt.Enabled = False
        LoadBt.Enabled = False
        OpenBt.Enabled = False

        'Удаляем все из папки Автоматизация рупор / чтобы не было ошибок
        For Each deleteFile In IO.Directory.GetFiles(My.Computer.FileSystem.SpecialDirectories.Desktop & "\Автоматизация рупор\", "*.*", IO.SearchOption.TopDirectoryOnly)
            IO.File.Delete(deleteFile)
        Next

        For ID As Integer = 0 To cell.GetUpperBound(0)
            My.Computer.FileSystem.MoveFile(My.Computer.FileSystem.SpecialDirectories.Desktop & "\Списки оповещения\" & ID + 1 & "  список оповещения.xlsx",
                                        My.Computer.FileSystem.SpecialDirectories.Desktop & "\Автоматизация РУПОР\" & ID + 1 & "  список оповещения.xlsx",
                                        FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
        Next

        MsgBox("Файлы скопированы в папку " & Chr(34) & "Автоматизация РУПОР" & Chr(34) & "." & vbCrLf & "В течение нескольких минут Система " & Chr(34) & "Рупор" & Chr(34) & " обновит списки оповещения!", 0)

    End Sub

    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title.DoubleClick
        MsgBox("Автор: Гранкин С.С." & vbCrLf & "E-mail: tel.nex@yandex.ru", 0)

    End Sub

    Private Sub AddSet_Click(sender As Object, e As EventArgs) Handles AddSet.Click
        Dim sApp As New SetApp
        sApp.ShowDialog()
    End Sub

    Private Sub TextInfo_TextChanged(sender As Object, e As EventArgs) Handles TextInfo.TextChanged

    End Sub
End Class
