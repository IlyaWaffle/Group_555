# Основные команды Git

Переход в папку проекта

    cd <путь_к_вашему_проекту>

Инициализация/создание репозитория

    git init

Добавим все файлы проекта

    git add .
    git add --all

Добавить конкретный файл

    git add <имя_файла>

Создать commit

    git commit -m "<комментарий>"

Вывести список всех имеющихся веток на экран

    git branch

Создать новую ветку

    git branch branch_name

Перейти на другую ветку

    git checkout branch_name

Слить ветки

    git merge branch_name

Добавить в текущую ветку информацию из ветки lists

    git merge lists

Удалить уже слитую ветку

    git branch -d branch_name

Увидеть лог коммитов с визуализацией

    git log -- graph

Справка по всем командам

    git help

Клонировать репозиторий из GitHub

    git clone

Отправить репозиторий на GitHub

    git push

Cкачать все из текущего репозитория

    git pull
