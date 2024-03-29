# dicontainer

## Преимущества использования подхода Dependency Injection (внедрение зависимостей)

- Упрощение тестирования: позволяет легко подменять зависимости на макеты (mocks) или заглушки (stubs) во время тестирования.
- Уменьшение связанности (coupling): классы становятся более независимыми друг от друга, что улучшает читаемость, поддерживаемость и расширяемость кода.
- Улучшение переиспользования: компоненты становятся более переносимыми и могут быть повторно использованы в различных частях приложения.
- Облегчение конфигурирования: позволяет централизованно управлять зависимостями и их конфигурацией.

## Обеспечение ограничения доступа на уровне DI-контейнера в ASP.NET Core

В ASP.NET Core можно использовать средства контроля доступа, такие как политики авторизации (authorization policies) и требования авторизации (authorization requirements), чтобы ограничить доступ к сервисам, основываясь на ролях пользователя или других параметрах.

## Проблема с временем жизни компонентов в DI

Когда компонент с более **коротким** временем жизни (например, transient) внедряется в компонент с более **длинным** временем жизни (например, scoped), может возникнуть проблема утечки ресурсов или неправильного использования зависимостей.

Если компонент с более **длинным** временем жизни внедряется в компонент с более **коротким** временем жизни, это может привести к неправильному использованию зависимостей или потенциальным утечкам памяти.

## singleton

### Отличие статического класса от класса, реализующего singleton

- Статический класс не может быть инстанциирован и содержит только статические члены. Тогда как класс, реализующий singleton, может иметь состояние и позволяет создавать только один экземпляр.
- Статический класс обеспечивает глобальный доступ к его членам. В то время как singleton может иметь контроль над созданием своего единственного экземпляра.

### Отличие регистрации singleton через DI-контейнер и статического конструктора

- Регистрация через DI-контейнер позволяет управлять зависимостями и жизненным циклом singleton, а также обеспечивает возможность тестирования и замены зависимостей.
- Использование статического конструктора ограничивает возможности управления зависимостями и усложняет тестирование.
