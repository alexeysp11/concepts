# Indexes.FinancialTransactions_FinancialTransactions_Products

Задачи, направленные на закрепление практических навыков работы с индексами.

Конфигурация таблиц для закрепления практических навыков работы с PostgreSQL представлена в файле [Config_FinancialTransactions_FinancialTransactions_Products.sql](../../../src/algorithms/sql/postgresql/Config.FinancialTransactions_Products.sql). 
Аналогичную конфигурацию и определение таблиц можно использовать для других реляционных баз данных. 

## Задачи

1. Создание таблицы с использованием наследования:

Необходимо создать таблицу Customers, которая будет наследовать все поля и ограничения целостности таблицы FinancialTransactions_Users. Для этого необходимо использовать оператор CREATE TABLE с параметром INHERITS, указав имя родительской таблицы.

2. Создание дочерней таблицы на основе существующей таблицы:

Необходимо создать таблицу VIPCustomers, которая будет наследовать все поля и ограничения целостности таблицы Customers. Для этого необходимо использовать оператор CREATE TABLE с параметром INHERITS, указав имя родительской таблицы.

3. Использование наследования для хранения данных в разных таблицах в зависимости от условий:

Необходимо создать таблицу OrdersInProgress, которая будет наследовать все поля и ограничения целостности таблицы FinancialTransactions_Orders, но будет хранить только заказы, которые находятся в процессе обработки. Для этого необходимо использовать оператор CREATE TABLE с параметром INHERITS и добавить ограничение CHECK для выборки только нужных заказов.

4. Использование наследования для объединения данных из нескольких таблиц:

Необходимо создать таблицу AllOrders, которая будет наследовать все поля и ограничения целостности таблиц FinancialTransactions_Orders и FinancialTransactions_OrderDetails. Для этого необходимо использовать оператор CREATE TABLE с параметром INHERITS и добавить ограничение CHECK для объединения данных из двух таблиц.

5. Использование наследования для создания иерархической структуры данных:

Необходимо создать таблицы Animal и Cat, где Cat будет наследовать все поля и ограничения целостности таблицы Animal. Таким образом, можно создать иерархическую структуру данных, где Cat будет дочерней таблицей Animal.

6. Использование наследования для наследования свойств и методов из родительской таблицы:

Необходимо создать таблицу Employees, которая будет наследовать все поля и методы из родительской таблицы FinancialTransactions_Users. Таким образом, можно использовать свойства и методы из таблицы FinancialTransactions_Users в таблице Employees.

7. Использование наследования в сочетании с другими операциями, такими как JOIN, UNION и другие:

Необходимо создать запрос, который будет объединять данные из таблиц FinancialTransactions_Orders и FinancialTransactions_OrderDetails с использованием наследования. Для этого необходимо использовать оператор UNION ALL и указать дочерние таблицы вместо родительской.

8. Использование ограничений целостности при работе с таблицами, наследующими друг от друга:

Необходимо добавить ограничение CHECK для таблицы VIPCustomers, которое будет проверять, что пользователь является VIP-клиентом только в том случае, если его общая сумма заказов превышает определенную сумму.

9. Использование прав доступа для ограничения доступа к данным в таблицах, наследующих друг от друга:

Необходимо создать роль Manager и назначить ей права на чтение данных из таблицы OrdersInProgress. Затем необходимо создать роль Admin и назначить ей права на чтение данных из таблицы FinancialTransactions_Orders. Таким образом, можно ограничить доступ к данным в зависимости от роли пользователя.

10. Использование индексов для ускорения работы с таблицами, наследующими друг от друга:

Необходимо создать индекс для поля ProductId в таблице FinancialTransactions_OrderDetails, чтобы ускорить выборку данных из дочерних таблиц. Также необходимо создать индекс для поля UserId в таблице FinancialTransactions_Orders, чтобы ускорить выборку данных из родительской таблицы.
