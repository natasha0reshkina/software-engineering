<h1 align="center">Mini HW KPO</h1>
<title>Учет животных Московского зоопарка</title>
</head>
<body>
<h1>Консольное приложение для учета животных Московского зоопарка</h1>
<h2>Описание проекта</h2>
<p>Приложение предназначено для учета животных в Московском зоопарке, их приема на баланс, 
учета потребляемой пищи и формирования списка животных, которые могут быть помещены в контактный зоопарк.</p>

<h2>Основной функционал</h2>
<ul>
    <li>Добавление новых животных в зоопарк.</li>
    <li>Проверка здоровья животных перед приемом.</li>
    <li>Расчет общего потребления еды.</li>
    <li>Вывод списка животных для контактного зоопарка.</li>
    <li>Учет вещей в зоопарке.</li>
</ul>

<h2>Структура кода</h2>
<h3>Применение принципов SOLID</h3>
<ul>
    <li><b>S (Single Responsibility)</b>: Классы разделены по функциональности (животные, вещи, сервисы).</li>
    <li><b>O (Open/Closed)</b>: Добавление новых видов животных без изменения существующего кода.</li>
    <li><b>L (Liskov Substitution)</b>: Потомки заменяют базовые классы без изменения логики.</li>
    <li><b>I (Interface Segregation)</b>: Интерфейсы IAlive и IInventory отделены.</li>
    <li><b>D (Dependency Inversion)</b>: Использование DI-контейнера (внедрение зависимостей).</li>
</ul>

<h3>Пример создания животного</h3>
<pre>
    Rabbit rabbit = new Rabbit(1, 7);
    Console.WriteLine(rabbit.ToString());
</pre>

<h3>Пример добавления животного в зоопарк</h3>
<pre>
    Zoo zoo = new Zoo();
    zoo.AddAnimal(new Tiger(3));
    zoo.PrintAnimals();
</pre>

<h3>Пример проверки здоровья животного</h3>
<pre>
    bool isHealthy = VetClinic.CheckHealth();
    Console.WriteLine(isHealthy ? "Животное здорово" : "Животное не здорово");
</pre>

<h2>Инструкция по запуску</h2>
<h3>Требования</h3>
<ul>
    <li>.NET 6.0 или выше</li>
    <li>Visual Studio / JetBrains Rider / Консоль</li>
</ul>

<h3>Шаги для запуска</h3>
<ol>
    <li>Клонировать репозиторий: <code>git clone https://github.com/your-repo/zoo-management.git</code></li>
    <li>Перейти в папку проекта: <code>cd zoo-management</code></li>
    <li>Собрать проект: <code>dotnet build</code></li>
    <li>Запустить приложение: <code>dotnet run</code></li>
</ol>

<h2>Запуск тестов</h2>
<pre>
    dotnet test
</pre>

<h2>Дополнительные баллы</h2>
<p>Код покрыт unit-тестами (более 60%).</p>

