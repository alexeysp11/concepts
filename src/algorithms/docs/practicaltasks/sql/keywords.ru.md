# keywords

Ключевое слово COLLATE используется для указания правил сортировки при сравнении строк, а ключевое слово OPERATOR используется для определения новых операторов, которые могут быть использованы в запросах.

Сгенерированные столбцы (GENERATED ALWAYS AS) - это столбцы, значения которых вычисляются автоматически на основе других столбцов в таблице. Они могут использоваться для создания виртуальных столбцов, которые не хранятся в таблице, но могут быть использованы в запросах. Ключевое слово было внедрено в PostgreSQL 12.

CREATE FOREIGN TABLE используется для создания таблицы, которая ссылается на данные из другой базы данных или другой таблицы внутри этой базы данных. Это может быть полезно, если вы хотите объединить данные из нескольких источников в одном запросе. Ключевое слово было внедрено в PostgreSQL 7.4.

CHECK используется для создания ограничений на значения столбцов в таблице. Например, вы можете создать ограничение CHECK, чтобы убедиться, что значение столбца всегда больше нуля. Ключевое слово было внедрено в PostgreSQL 7.3.

EXCLUDE USING используется для создания ограничений на значения нескольких столбцов в таблице. Например, вы можете создать ограничение EXCLUDE USING, чтобы убедиться, что значения двух столбцов не пересекаются. Ключевое слово было внедрено в PostgreSQL 9.0.

Команда VALUES используется для создания временной таблицы, которая содержит одну или несколько строк значений. Это может быть полезно, если вы хотите выполнить запрос, который использует константы или временные данные.

## Задачи

Задачи для работы с ключевым словом COLLATE в PostgreSQL:

1. Создайте таблицу с текстовым столбцом и установите COLLATE на "C" для этого столбца. Вставьте несколько строк с разными регистрами букв в этот столбец и выполните SELECT запрос, чтобы убедиться, что строки сравниваются без учета регистра.

2. Создайте таблицу с текстовым столбцом и установите COLLATE на "ru_RU.utf8" для этого столбца. Вставьте несколько строк на русском языке в этот столбец и выполните SELECT запрос, чтобы убедиться, что строки сравниваются с учетом правил сортировки русского языка.

3. Создайте таблицу с текстовым столбцом и установите COLLATE на "es_ES.utf8" для этого столбца. Вставьте несколько строк на испанском языке в этот столбец и выполните SELECT запрос, чтобы убедиться, что строки сравниваются с учетом правил сортировки испанского языка.

4. Создайте таблицу с текстовым столбцом и установите COLLATE на "de_DE.utf8" для этого столбца. Вставьте несколько строк на немецком языке в этот столбец и выполните SELECT запрос, чтобы убедиться, что строки сравниваются с учетом правил сортировки немецкого языка.

5. Создайте таблицу с текстовым столбцом и установите COLLATE на "ja_JP.utf8" для этого столбца. Вставьте несколько строк на японском языке в этот столбец и выполните SELECT запрос, чтобы убедиться, что строки сравниваются с учетом правил сортировки японского языка.

6. Создайте таблицу с текстовым столбцом и установите COLLATE на "en_US.utf8" для этого столбца. Вставьте несколько строк на английском языке в этот столбец и выполните SELECT запрос, чтобы убедиться, что строки сравниваются с учетом правил сортировки английского языка.

7. Создайте таблицу с текстовым столбцом и установите COLLATE на "fr_FR.utf8" для этого столбца. Вставьте несколько строк на французском языке в этот столбец и выполните SELECT запрос, чтобы убедиться, что строки сравниваются с учетом правил сортировки французского языка.

8. Создайте таблицу с текстовым столбцом и установите COLLATE на "tr_TR.utf8" для этого столбца. Вставьте несколько строк на турецком языке в этот столбец и выполните SELECT запрос, чтобы убедиться, что строки сравниваются с учетом правил сортировки турецкого языка.

9. Создайте таблицу с текстовым столбцом и установите COLLATE на "zh_CN.utf8" для этого столбца. Вставьте несколько строк на китайском языке в этот столбец и выполните SELECT запрос, чтобы убедиться, что строки сравниваются с учетом правил сортировки китайского языка.

10. Создайте таблицу с текстовым столбцом и установите COLLATE на "ko_KR.utf8" для этого столбца. Вставьте несколько строк на корейском языке в этот столбец и выполните SELECT запрос, чтобы убедиться, что строки сравниваются с учетом правил сортировки корейского языка.

Задачи для работы с ключевым словом OPERATOR в PostgreSQL:

1. Создайте новый оператор "+*" для конкатенации двух строк. Протестируйте оператор на нескольких строках.

2. Создайте новый оператор "|||" для объединения двух массивов. Протестируйте оператор на нескольких массивах.

3. Создайте новый оператор ">>>" для сравнения двух дат. Оператор должен возвращать true, если первая дата больше второй. Протестируйте оператор на нескольких датах.

4. Создайте новый оператор "<->" для вычисления расстояния между двумя точками на плоскости. Протестируйте оператор на нескольких парах точек.

5. Создайте новый оператор "   " для поиска подстроки в тексте. Оператор должен возвращать true, если подстрока найдена. Протестируйте оператор на нескольких строках.

6. Создайте новый оператор "!   " для поиска отсутствия подстроки в тексте. Оператор должен возвращать true, если подстрока не найдена. Протестируйте оператор на нескольких строках.

7. Создайте новый оператор "&&&" для сравнения двух битовых строк. Оператор должен возвращать true, если обе строки содержат единицы в одних и тех же позициях. Протестируйте оператор на нескольких битовых строках.

8. Создайте новый оператор "

9. Создайте новый оператор "^^^" для вычисления xor двух битовых строк. Протестируйте оператор на нескольких битовых строк
- ах.

10. Создайте новый оператор "###" для сравнения двух временных промежутков. Оператор должен возвращать true, если первый промежуток длиннее второго. Протестируйте оператор на нескольких временных промежутках.

Задачи для работы с ключевым словом CHECK в PostgreSQL:

1. Создайте таблицу с числовым столбцом и установите ограничение CHECK на положительные значения этого столбца. Вставьте несколько строк с отрицательными значениями и убедитесь, что они не проходят проверку ограничения.

2. Создайте таблицу с текстовым столбцом и установите ограничение CHECK на длину этого столбца. Вставьте несколько строк с длиной текста больше, чем разрешено ограничением, и убедитесь, что они не проходят проверку ограничения.

3. Создайте таблицу с датой и временем и установите ограничение CHECK на дату, которая должна быть в будущем. Вставьте несколько строк с датой, которая уже прошла, и убедитесь, что они не проходят проверку ограничения.

4. Создайте таблицу с числовым столбцом и установите ограничение CHECK на диапазон значений этого столбца. Вставьте несколько строк с значениями, которые не входят в этот диапазон, и убедитесь, что они не проходят проверку ограничения.

5. Создайте таблицу с текстовым столбцом и установите ограничение CHECK на определенное значение этого столбца. Вставьте несколько строк со значениями, которые не соответствуют этому значению, и убедитесь, что они не проходят проверку ограничения.

6. Создайте таблицу с числовым столбцом и установите ограничение CHECK на четность этого столбца. Вставьте несколько строк с нечетными значениями и убедитесь, что они не проходят проверку ограничения.

7. Создайте таблицу с текстовым столбцом и установите ограничение CHECK на определенный формат этого столбца. Вставьте несколько строк со значениями, которые не соответствуют этому формату, и убедитесь, что они не проходят проверку ограничения.

8. Создайте таблицу с числовым столбцом и установите ограничение CHECK на нечетные значения этого столбца. Вставьте несколько строк с четными значениями и убедитесь, что они не проходят проверку ограничения.

9. Создайте таблицу с текстовым столбцом и установите ограничение CHECK на наличие определенного слова в этом столбце. Вставьте несколько строк без этого слова и убедитесь, что они не проходят проверку ограничения.

10. Создайте таблицу с датой и временем и установите ограничение CHECK на дату, которая должна быть в прошлом. Вставьте несколько строк с датой в будущем и убедитесь, что они не проходят проверку ограничения.

Задачи для работы с ключевым словом CREATE FOREIGN TABLE в PostgreSQL:

1. Создайте внешнюю таблицу, которая будет ссылаться на таблицу из другой базы данных. Убедитесь, что вы можете получить доступ к данным из этой таблицы.

2. Создайте внешнюю таблицу, которая будет ссылаться на файл CSV. Убедитесь, что вы можете получить доступ к данным из этой таблицы.

3. Создайте внешнюю таблицу, которая будет ссылаться на файл Excel. Убедитесь, что вы можете получить доступ к данным из этой таблицы.

4. Создайте внешнюю таблицу, которая будет ссылаться на файл JSON. Убедитесь, что вы можете получить доступ к данным из этой таблицы.

5. Создайте внешнюю таблицу, которая будет ссылаться на файл XML. Убедитесь, что вы можете получить доступ к данным из этой таблицы.

6. Создайте внешнюю таблицу, которая будет ссылаться на таблицу из другой базы данных с использованием дополнительных опций, таких как USER и PASSWORD.

7. Создайте внешнюю таблицу, которая будет ссылаться на файл CSV с использованием дополнительных опций, таких как разделитель столбцов и строки заголовка.

8. Создайте внешнюю таблицу, которая будет ссылаться на файл Excel с использованием дополнительных опций, таких как имя листа и диапазон ячеек.

9. Создайте внешнюю таблицу, которая будет ссылаться на файл JSON с использованием дополнительных опций, таких как путь к данным.

10. Создайте внешнюю таблицу, которая будет ссылаться на файл XML с использованием дополнительных опций, таких как путь к данным и схема.

Задачи для работы с ключевым словом EXCLUDE USING в PostgreSQL:

1. Создайте таблицу с двумя числовыми столбцами и установите ограничение EXCLUDE USING, чтобы значения в этих столбцах не могли быть одинаковыми.

2. Создайте таблицу с двумя текстовыми столбцами и установите ограничение EXCLUDE USING, чтобы значения в этих столбцах не могли быть одинаковыми.

3. Создайте таблицу с двумя столбцами типа point и установите ограничение EXCLUDE USING, чтобы значения в этих столбцах не могли быть одинаковыми.

4. Создайте таблицу с двумя столбцами типа timestamp и установите ограничение EXCLUDE USING, чтобы значения в этих столбцах не могли быть одинаковыми.

5. Создайте таблицу с двумя столбцами типа interval и установите ограничение EXCLUDE USING, чтобы значения в этих столбцах не могли быть одинаковыми.

6. Создайте таблицу с двумя столбцами типа circle и установите ограничение EXCLUDE USING, чтобы значения в этих столбцах не могли быть одинаковыми.

7. Создайте таблицу с двумя столбцами типа money и установите ограничение EXCLUDE USING, чтобы значения в этих столбцах не могли быть одинаковыми.

8. Создайте таблицу с двумя столбцами типа macaddr и установите ограничение EXCLUDE USING, чтобы значения в этих столбцах не могли быть одинаковыми.

9. Создайте таблицу с двумя столбцами типа inet и установите ограничение EXCLUDE USING, чтобы значения в этих столбцах не могли быть одинаковыми.

10. Создайте таблицу с двумя столбцами типа box и установите ограничение EXCLUDE USING, чтобы значения в этих столбцах не могли быть одинаковыми.