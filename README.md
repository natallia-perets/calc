calc
====

task by A. Anufriev
=====
Написать калькулятор.

Калькулятор имеет:

4 операции ( + - * /)

2 операнда (например 1 + 4)

возможность настроить точность вычисления

поддержку корректности работы (т.е. приложение не должно ломаться, если пользователь задумает выполнить ‘a’ + 2)

просмотр списка выполненных корректно операций 
(например пользователь пробовал выполнить 3 операции: 1 + 1, а - 4, 4 / 5. Хранить только 1ю и 2ю операции и их результат)

сохранение списка выполненных корректно операций в файл.



Предусмотреть возможность замены  механизма сохранения. Допустим через месяц новый заказчик захочет чтобы список операций сохранялся на удаленном сервере.



Подсказки:

UII не важен, подойдет консольное приложение

настройки приложения можно задавать в App.config и получать при помощи ConfigurationManager


Для выполнения задания использовать MS Visual Studio.
Очень желательно использовать git.
Также приветствуются модульные тесты.

