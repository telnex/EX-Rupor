# EX-Ropor
###Данное приложение предназначено для автоматизации процесса обновление списков оповещения системы "Рупор" (многоканальная система автоматического оповещения абонентов по телефонным линиям). 

![Иллюстрация к проекту](https://lh3.googleusercontent.com/-l9dXONbnLog/X-o2PqGkmWI/AAAAAAAAGlI/VntZWOuXzJonjqyPYlNdLgmE7-FxZ6Y3gCLcBGAsYHQ/image.png)


Процесс эксплуатации: посредством кнопки «Выбрать файл» загружается файл (.xlsx/.xls) со списком отсутствующих, после чего нажимается кнопка «Произвести анализ», программа производит сравнение списков отсутствующих и списков оповещения (bookName.xlsx), в случае совпадения производит замену, с выгрузкой данных из основной базы контактов (файл mainNumber.xlsx – выгрузка контактов из Рупор). Следующим этапом в папке «Списки оповещения» создаются 8 файлов Excel, по одному на каждый список оповещения. Нажатие кнопки «Загрузить в Рупор» производит перемещение выше указанных файлов в папку «Автоматизация Рупор». Выполнение дальнейших каких-либо команд не требуется, Рупор (сервер) автоматически обновит списки оповещения согласно файлам в папке «Автоматизация Рупор». В случае, если для пользователя не указана замена, система сформирует список оповещения с тем же пользователем.
Для работы программы необходимо: ОС Windows 7-10, 120 мб оперативной памяти (RAM), а также установленный MS Excel (активированный) и .net framework 4.5. При работе приложение запускает процессы EXCEL.EXE, в связи с чем, при неправильном закрытии программы (или в случае ошибки) остаются остаточные процессы, которые необходимо закрыть вручную через Диспетчер задач или перезагрузить ПК.
При работе программа использует три файла Excel: справка отсутствующих, общая база контактов, списки оповещения. Каждый столбец соответствует определённому параметру и должен совпадать с приведенном ниже примером.
