# Лабораторная работа №7 — Тестирование в CI/CD

Проект из лабораторной работы №1 (модульные тесты на C# / MSTest), подключённый
к конвейеру непрерывной интеграции GitHub Actions.

## Структура

```
Lab1Tests.sln
├── MyApp/                 — библиотека с реализацией 8 алгоритмов (Lab1Methods)
├── MyApp.Tests/           — 36 модульных тестов на MSTest
└── .github/workflows/ci.yml — конвейер CI/CD
```

## Локальный запуск

```bash
dotnet restore Lab1Tests.sln
dotnet build Lab1Tests.sln --configuration Release
dotnet test Lab1Tests.sln --configuration Release
```

## Конвейер

Запускается на `push` и `pull_request` в ветку `main`, а также вручную
(`workflow_dispatch`).

| Задание | Что делает |
|---|---|
| `build-and-test` | restore → build → test на матрице `ubuntu-latest` + `windows-latest`, сбор `.trx` и покрытия кода |
| `publish` | сборка `dotnet publish` и выгрузка артефакта (только для ветки `main`) |
