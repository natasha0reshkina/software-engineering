# ZooManagement

## Реализованный функционал

- **Добавить и удалить животное**  
  - Контроллер `AnimalsController`: методы `Create`, `Delete`  
  - Репозиторий `InMemoryAnimalRepository`: методы `Add`, `Remove`, `GetById`

- **Добавить и удалить вольер**  
  - Контроллер `EnclosuresController`: методы `Create`, `Delete`  
  - Репозиторий `InMemoryEnclosureRepository`: методы `Add`, `Remove`, `GetById`

- **Переместить животное между вольерами**  
  - Сервис `AnimalTransferService`: метод `Transfer`  
  - Класс `Animal`: метод `MoveTo`  
  - Событие `AnimalMovedEvent`

- **Просмотреть расписание кормления**  
  - Контроллер `FeedingSchedulesController`: метод `GetAll`  
  - Репозиторий `InMemoryFeedingScheduleRepository`: метод `ListAll`

- **Добавить кормление в расписание**  
  - Контроллер `FeedingSchedulesController`: метод `Schedule`  
  - Сервис `FeedingOrganizationService`: метод `ScheduleFeeding`

- **Отметить выполнение кормления**  
  - Контроллер `FeedingSchedulesController`: метод `Complete`  
  - Сервис `FeedingOrganizationService`: метод `CompleteFeeding`  
  - Событие `FeedingTimeEvent`

- **Просмотреть статистику зоопарка**  
  - Сервис `ZooStatisticsService`: метод `GetStatistics`

## Применённые концепции

### Domain Driven Design

- **Value Objects**  
  - `AnimalId`  
  - `EnclosureId`  
  - `Gender`  
  - `AnimalStatus`  
  - `FoodType`  
  - `EnclosureType`

- **Entities**  
  - `Animal` (методы `Feed`, `Treat`, `MoveTo`)  
  - `Enclosure` (методы `AddAnimal`, `RemoveAnimal`, `Clean`)  
  - `FeedingSchedule` (методы `Reschedule`, `MarkDone`)

- **Domain Events**  
  - `AnimalMovedEvent`  
  - `FeedingTimeEvent`

### Clean Architecture

- **Слои**  
  - `Domain`  
  - `Application`  
  - `Infrastructure`  
  - `Presentation`

- **Интерфейсы для внешних зависимостей**  
  - `IAnimalRepository`  
  - `IEnclosureRepository`  
  - `IFeedingScheduleRepository`  
  - `IEventPublisher`  
  - `IAnimalTransferService`  
  - `IFeedingOrganizationService`  
  - `IZooStatisticsService`

Бизнес-логика изолирована в слоях `Domain` и `Application`.  
