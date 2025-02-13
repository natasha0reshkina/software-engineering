<h1 align="center">Mini HW KPO</h1>
<h1>README - Московский зоопарк</h1>
    
  <h2>Описание проекта</h2>
  <p>Данное консольное приложение предназначено для ведения учета животных Московского зоопарка. Оно позволяет:</p>
  <ul>
      <li>Добавлять новых животных после проверки их здоровья.</li>
      <li>Выводить список животных, состоящих на балансе зоопарка.</li>
      <li>Рассчитывать суточное потребление пищи всеми животными.</li>
      <li>Формировать список животных для контактного зоопарка.</li>
      <li>Выводить список вещей, стоящих на балансе зоопарка.</li>
  </ul>
  
  <h2>Архитектура и принципы SOLID</h2>
  <ul>
      <li><strong>Single Responsibility Principle (SRP):</strong> Каждому классу соответствует одна зона ответственности.</li>
      <li><strong>Open/Closed Principle (OCP):</strong> Классы расширяются через наследование (Animal, Herbo, Predator).</li>
      <li><strong>Liskov Substitution Principle (LSP):</strong> Подклассы заменяют базовый класс без изменения поведения.</li>
      <li><strong>Interface Segregation Principle (ISP):</strong> Разделение интерфейсов <code>IAlive</code> и <code>IInventory</code>.</li>
      <li><strong>Dependency Inversion Principle (DIP):</strong> Зависимости реализуются через абстракции.</li>
  </ul>
  
  <h2>Инструкция по запуску</h2>
  <ol>
      <li>Установите .NET SDK (не ниже версии 6.0).</li>
      <li>Клонируйте репозиторий с помощью команды:<br>
          <code>git clone https://github.com/yourrepo/minidz.git</code></li>
      <li>Перейдите в директорию проекта:<br>
          <code>cd minidz</code></li>
      <li>Соберите проект:<br>
          <code>dotnet build</code></li>
      <li>Запустите приложение:<br>
          <code>dotnet run</code></li>
  </ol>
  
  <h2>Тестирование</h2>
  <p>Для запуска тестов выполните команду:</p>
  <pre><code>dotnet test</code></pre>
