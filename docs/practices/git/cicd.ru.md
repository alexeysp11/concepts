# CI/CD

CI/CD (Continuous Integration/Continuous Delivery or Continuous Deployment) - это набор практик и инструментов, которые автоматизируют процесс сборки, тестирования и развертывания программного обеспечения. 

**Continuous Integration (CI)**:

- Разработчики часто интегрируют код в общий репозиторий.
- Каждый коммит автоматически запускает сборку и тестирование.
- Это позволяет быстро обнаружить ошибки и повышает качество кода.

**Continuous Delivery (CD)**:

- После успешной сборки и тестирования код автоматически развертывается в тестовую среду.
- Это позволяет разработчикам получать обратную связь по качеству кода и видеть результат изменений.

**Continuous Deployment (CD)**:

- Код автоматически развертывается в продуктивную среду после успешной проверки в тестовой среде.
- Это позволяет выпускать обновления быстрее и чаще, а также реагировать на изменения рынка и пользовательских потребностей.

## Польза CI/CD

- **Повышение качества кода**: Ранняя интеграция и тестирование помогают найти ошибки раньше и снизить затраты на их исправление.
- **Ускорение разработки**: Автоматизация процесса сборки и развертывания позволяет разработчикам сосредоточиться на создании новых функций.
- **Частые обновления**: CI/CD позволяет выпускать обновления чаще, что повышает удовлетворенность пользователей и позволяет быстрее реагировать на изменения рынка.
- **Сокращение рисков**: Автоматизация процесса развертывания снижает риск ошибок и проблем при обновлении ПО.
- **Повышение прозрачности**: CI/CD позволяет отслеживать все изменения в коде и развертываниях.

## CI/CD в GitLab и GitHub

### GitLab CI/CD: Встроенный в платформу GitLab

Преимущества:

- Простота настройки и использования.
- Большое количество возможностей для настройки pipelines.
- Интеграция с другими инструментами GitLab.

### GitHub Actions: Отдельный сервис для CI/CD в GitHub

Преимущества:

- Гибкость и расширяемость.
- Большой выбор действий (actions) для различных задач.
- Интеграция с другими инструментами GitHub.

### Ключевые различия между GitLab CI/CD и GitHub Actions

- **GitLab CI/CD**: Встроенный, более интегрированный с другими функциями GitLab.
- **GitHub Actions**: Отдельный сервис, более гибкий и расширяемый.

## Package Registry

**GitLab Package Registry** - это репозиторий для хранения и управления пакетами, который встроен в GitLab. Он поддерживает различные типы пакетов, включая:

- NuGet
- Maven
- npm
- Helm
- Docker

Аналогичным инструментом в GitHub является **GitHub Packages**.

Эти решение хорошо интегрируется с CI/CD.

### Преимущества использования nuget пакетов

- **Повторное использование кода**: Пакеты позволяют повторно использовать код в разных проектах, сокращая дублирование.
- **Управление зависимостями**: Пакеты упрощают управление зависимостями, обеспечивая более устойчивую и стабильную систему.
- **Обновления**: Пакеты позволяют легко обновлять код в всех проектах, в которых он используется.
- **Увеличение производительности**: Пакеты могут увеличить производительность разработки, позволяя разработчикам быстрее создавать новые функции.

### Использование GitLab Package Registry в корпоративном GitLab

Возможно сделать nuget пакет доступным на уровне организации в корпоративном GitLab и запретить доступ из внешней сети. 

**Как это сделать**:

1. Создайте проект в корпоративном GitLab для хранения nuget пакета.
2. Используйте GitLab Package Registry для публикации пакета.
3. Настройте правила доступа к репозиторию пакета. 
    - Запретите доступ из внешней сети.
    - Разрешите доступ только пользователям и группам внутри организации.
4. Используйте `NuGet.Config` файл в проектах, которые должны использовать пакет.

**Дополнительные рекомендации**:

- Используйте токены доступа для управления доступом к репозиторию пакета.
- Регулярно обновляйте пакет.