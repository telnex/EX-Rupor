# EX-Ropor
##### ВЕРСИЯ 1.0.2.0
### Приложение предназначено для автоматизации процесса обновление списков оповещения системы "Рупор" (многоканальная система автоматического оповещения абонентов по телефонным линиям). 

![Иллюстрация к проекту](https://lh3.googleusercontent.com/-7EUrgoacWQ8/X-o2diV9VRI/AAAAAAAAGlM/uZrCvHXdaJcDsqN4N_hSnIIHvJCdBHnbgCLcBGAsYHQ/s16000/image.png)


Процесс эксплуатации: посредством кнопки **«Выбрать файл»** загружается файл *(.xlsx/.xls)* со списком отсутствующих, после чего нажимается кнопка **«Произвести анализ»**, программа производит сравнение списков отсутствующих и списков оповещения *(bookName.xlsx)*, в случае совпадения производит замену, с выгрузкой данных из основной базы контактов *(файл mainNumber.xlsx – выгрузка контактов из Рупор)*. 

Следующим этапом в папке **«Списки оповещения»** создаются 8 файлов Excel, по одному на каждый список оповещения. Нажатие кнопки **«Загрузить в Рупор»** производит перемещение выше указанных файлов в папку **«Автоматизация Рупор»**. 
Выполнение дальнейших каких-либо команд не требуется, Рупор *(сервер)* автоматически обновит списки оповещения согласно файлам в папке **«Автоматизация Рупор»**. В случае, если для пользователя не указана замена, система сформирует список оповещения с тем же пользователем.

Для работы программы необходимо: ОС Windows 7-10, 120 мб оперативной памяти *(RAM)*, а также установленный MS Excel *(активированный)* и .net framework 4.5. 
При работе приложение запускает процессы EXCEL.EXE, в связи с чем, при неправильном закрытии программы *(или в случае ошибки)* остаются остаточные процессы, которые необходимо закрыть вручную через Диспетчер задач или перезагрузить ПК.

Настройка списков
``` vb
'Максимальное кол-во отстутствующих и абонентов в списке оповещения
    Public count As Integer = 30
    'Список оповещения по умолчанию
    Public cell() As String = {"A", "B", "C", "D", "E", "F"}
```
При работе программа использует три файла Excel: справка отсутствующих, общая база контактов, списки оповещения. Каждый столбец соответствует определённому параметру и должен совпадать с приведенном ниже примером.

##### Список оповещения "по умолчанию"
![Список оповещения по умолчанию](https://lh3.googleusercontent.com/-1csEUbV7e0g/X-o0v6dZ_1I/AAAAAAAAGk0/gISi02tHUT4H5JbmjObZPt4KK-xpw0SQQCLcBGAsYHQ/s16000/image.png)

##### Основная база контактов
![Основная база контактов](https://lh3.googleusercontent.com/-yUUCjGYw_Wo/X-o0sDUZP7I/AAAAAAAAGkw/VnAUF8gSP78qF4EIaKt7IP_3_NFk_9w7wCLcBGAsYHQ/s16000/image.png)

##### Справка по отсутствующим
![Справка отсутствующих](https://lh3.googleusercontent.com/-21lxDBWUBgk/X-o0zGsF_gI/AAAAAAAAGk4/s-If7NMbKNMiBYwu-Im52Dd8Fy5hTkDfACLcBGAsYHQ/s16000/image.png)
