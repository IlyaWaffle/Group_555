# Instruction. GIT.

***Git** is a distributed version control system that tracks changes in any set of computer files, usually used for coordinating work among programmers collaboratively developing source code during software development.*

## Main commands:

* **git init** - create an empty Git repository or reinitialize an existing one
* **git add** - add file contents to the index
* **git commit** - record changes to the repository
* **git log** - show commit logs
* **git checkout** - switch branches or restore working tree files
* **git diff** - show changes between commits, commit and working tree, etc

## Работа с ветками:
1. git branch <название новой ветки> - создание новой ветки
2. git checkout <имя ветки> - переключение между ветками
3. git merge <имя ветки> – слияние любой ветки с текущей
4. git branch -d <имя ветки> - удаление ветки
 
## Конфликты изменений:
При работе в двух ветках одновременно может возникнуть ситуация, когда в одной и другой ветке мы по-разному изменили блок текста. Если затем мы попробуем слить эти ветки, Git сообщит о конфликте и предложит выбрать, какие же изменения записать.

Работа с удаленными репозиториями:
* git clone <ссылка> - копировать внешний репозиторий на свой ПК можно командой
* git pull - команда позволяет скачать все из текущего репозитория и автоматически сделать merge с нашей версией
* git push – позволяет отправить свою версию репозитория во внешний репозиторий поможет команда git push. При первом использовании нужна авторизация.
* pull request -  команда для предложения изменений =  запрос на вливание изменений в репозиторий

## Совместная работа:
Настройка совместной работы: 
1. Создать аккаунт на GitHub.com 
2. Создать локальный репозиторий 
3. “Подружить” ваш локальный и удалённый репозитории. GitHub при создании нового репозитория подскажет, как это можно сделать 
4. Отправить (push) ваш локальный репозиторий в удалённый (на GitHub), при этом, возможно,  вам нужно будет авторизоваться на удалённом репозитории 
5. Провести изменения “с другого компьютера” 
6. Выкачать (pull) актуальное состояние из удалённого репозитория

Как сделать pull request :
* Делаем   (ответвление) репозитория fork 
* Делаем git clone   версии репозитория СВОЕЙ 
* Создаем новую ветку и в НЕЕ вносим свои изменения 
* Фиксируем изменения (делаем коммиты) 
* Отправляем свою версию в свой GitHub 
* На сайте GitHub нажимаем кнопку pull requeSst

SUCCESS! APPLAUSE!

![git logo](https://git-scm.com/images/logo@2x.png "GIT")

