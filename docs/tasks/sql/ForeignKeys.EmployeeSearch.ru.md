# ForeignKeys.EmployeeSearch

Задачи, направленные на закрепление практических навыков работы с foreign key.

Конфигурация таблиц для закрепления практических навыков работы с PostgreSQL представлена в файле [Config.EmployeeSearch.sql](../../../src/algorithms/sql/postgresql/Config.EmployeeSearch.sql).
Аналогичную конфигурацию и определение таблиц можно использовать для других реляционных баз данных. 

## Задачи

Для улучшения понимания foreign key в PostgreSQL рекомендуется выполнить практические задания, которые позволят закрепить теоретические знания на практике. Например, создание таблиц с foreign key, выполнение операций INSERT, UPDATE и DELETE с использованием foreign key, использование ON DELETE CASCADE и другие.

### Создание таблиц с foreign key

1. Таблица "Компании" (Companies) хранит информацию о компаниях, которые нанимают специалистов. Содержит поля: ID компании, название компании, адрес, телефон, электронная почта.
2. Таблица "Подразделения" (Departments) хранит информацию о подразделениях компаний. Содержит поля: ID подразделения, название подразделения, ID компании.
3. Таблица "Должности" (Positions) хранит информацию о должностях, на которые можно нанять специалистов. Содержит поля: ID должности, название должности, зарплата.
4. Таблица "Специалисты" (Specialists) хранит информацию о специалистах, доступных для найма. Содержит поля: ID специалиста, имя, фамилия, возраст, контактная информация.
5. Таблица "Резюме" (Resumes) хранит информацию о резюме специалистов. Содержит поля: ID резюме, ID специалиста, квалификация, опыт работы, образование.
6. Таблица "Вакансии" (Vacancies) хранит информацию о вакансиях на должности в компаниях. Содержит поля: ID вакансии, ID должности, ID подразделения, количество вакансий.
7. Таблица "Собеседования" (Interviews) хранит информацию о собеседованиях со специалистами на вакансии. Содержит поля: ID собеседования, ID вакансии, ID специалиста, дата собеседования, статус (пройдено/не пройдено).
8. Таблица "Офферы" (Offers) хранит информацию о предложениях компаний специалистам на работу. Содержит поля: ID оффера, ID вакансии, ID специалиста, дата предложения, зарплата, статус (принято/отклонено).
9. Таблица "Контракты" (Contracts) хранит информацию о заключенных контрактах между компаниями и специалистами. Содержит поля: ID контракта, ID оффера, дата начала работы, дата окончания работы.
10. Таблица "Отзывы" (Feedbacks) хранит информацию об отзывах компаний и специалистов друг о друге. Содержит поля: ID отзыва, ID контракта, оценка (от 1 до 5), комментарий.

### Задачи для операции INSERT

1. Добавить новую компанию в таблицу "Компании".
2. Добавить новое подразделение в таблицу "Подразделения" с указанием ID компании.
3. Добавить новую должность в таблицу "Должности".
4. Добавить нового специалиста в таблицу "Специалисты".
5. Добавить новое резюме в таблицу "Резюме" с указанием ID специалиста.
6. Добавить новую вакансию в таблицу "Вакансии" с указанием ID должности и ID подразделения.
7. Добавить новое собеседование в таблицу "Собеседования" с указанием ID вакансии и ID специалиста.
8. Добавить новый оффер в таблицу "Офферы" с указанием ID вакансии и ID специалиста.
9. Добавить новый контракт в таблицу "Контракты" с указанием ID оффера.
10. Добавить новый отзыв в таблицу "Отзывы" с указанием ID контракта и оценкой.

### Задачи для операции UPDATE

1. Изменить существующую компанию в таблицу "Компании".
2. Изменить существующее подразделение в таблицу "Подразделения" с указанием ID компании.
3. Изменить существующую должность в таблицу "Должности".
4. Изменить существующго специалиста в таблицу "Специалисты".
5. Изменить существующее резюме в таблицу "Резюме" с указанием ID специалиста.
6. Изменить существующую вакансию в таблицу "Вакансии" с указанием ID должности и ID подразделения.
7. Изменить существующее собеседование в таблицу "Собеседования" с указанием ID вакансии и ID специалиста.
8. Изменить существующий оффер в таблицу "Офферы" с указанием ID вакансии и ID специалиста.
9. Изменить существующий контракт в таблицу "Контракты" с указанием ID оффера.
10. Изменить существующий отзыв в таблицу "Отзывы" с указанием ID контракта и оценкой.

### Задачи для операции DELETE и ON DELETE CASCADE

1. Удалить существующую запись в таблице "Компании" (Companies). 
2. Удалить существующую запись в таблице "Подразделения" (Departments). 
3. Удалить существующую запись в таблице "Должности" (Positions). 
4. Удалить существующую запись в таблице "Специалисты" (Specialists). 
5. Удалить существующую запись в таблице "Резюме" (Resumes). 
6. Удалить существующую запись в таблице "Вакансии" (Vacancies). 
7. Удалить существующую запись в таблице "Собеседования" (Interviews). 
8. Удалить существующую запись в таблице "Офферы" (Offers). 
9. Удалить существующую запись в таблице "Контракты" (Contracts). 
10. Удалить существующую запись в таблице "Отзывы" (Feedbacks). 
