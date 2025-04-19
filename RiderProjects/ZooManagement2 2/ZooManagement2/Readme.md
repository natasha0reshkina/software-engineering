# ZooManagement

## Реализованный функционал

- Добавить и удалить животное

  - Контроллер AnimalsController: методы Create Delete
  - Репозиторий InMemoryAnimalRepository: методы Add Remove GetById

- Добавить и удалить вольер

  - Контроллер EnclosuresController: методы Create Delete
  - Репозиторий InMemoryEnclosureRepository: методы Add Remove GetById

- Переместить животное между вольерами

  - сервис AnimalTransferService: метод Transfer
  - в классе Animal: метод MoveTo
  - событие AnimalMovedEvent

- Просмотреть расписание кормления

  - контроллер FeedingSchedulesController: метод GetAll
  - репозиторий InMemoryFeedingScheduleRepository: метод ListAll

- Добавить кормление в расписание

  - контроллер FeedingSchedulesController: метод Schedule
  - сервис FeedingOrganizationService: метод ScheduleFeeding

- Отметить выполнение кормления

  - контроллер FeedingSchedulesController: метод Complete
  - сервис FeedingOrganizationService: метод CompleteFeeding
  - событие FeedingTimeEvent

- Просмотреть статистику зоопарка

  - сервис ZooStatisticsService: метод GetStatistics

## Примененные концепции

### Domain Driven Design

- Value Objects:

  - AnimalId
  - EnclosureId
  - Gender
  - AnimalStatus
  - FoodType
  - EnclosureType

- Entities:

  - Animal (Feed Treat MoveTo)
  - Enclosure (AddAnimal RemoveAnimal Clean)
  - FeedingSchedule (Reschedule MarkDone)

- Domain Events:

  - AnimalMovedEvent
  - FeedingTimeEvent

### Clean Architecture

- Слои:

  - Domain
  - Application
  - Infrastructure
  - Presentation

- Интерфейсы для внешних зависимостей:

  - IAnimalRepository
  - IEnclosureRepository
  - IFeedingScheduleRepository
  - IEventPublisher
  - IAnimalTransferService
  - IFeedingOrganizationService
  - IZooStatisticsService

- Бизнес логика изолирована в Domain и Application слоях

