# aspnetcore

ASP.NET и ASP.NET Core - это две разные версии фреймворка для создания веб-приложений на платформе .NET. 
ASP.NET Core является более легковесной и модульной версией, которая поддерживает работу на различных операционных системах.

### Middleware

Middleware - это компоненты, которые обрабатывают запросы и ответы в ASP.NET Core. 
Они могут выполнять какую-то общую функциональность, например, авторизацию или логирование.

Метод `Next()` используется для передачи управления следующему компоненту middleware в цепочке обработки запроса. 
Если не вызвать данный метод, то обработка запроса остановится на текущем компоненте.

Middleware - это компоненты, которые выполняются последовательно в цепочке обработки запроса, а pipeline - это совокупность middleware, которые обрабатывают запросы и ответы в ASP.NET Core.