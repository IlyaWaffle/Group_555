## Основыне команды git

+ git init - создание репазитория 

+ git add - добавление файлов
  + . - добавлние всех файлов 

  + readme.md - добавление файла с названием readme.md

+ git help - встроенная помощь git со всеми доступными

+ git - командами. Выход из режима просмотра - клавиша q.

+ git help <command> - помощь по полезным командам, например:git help status

+ git clone <link to you repo> - обратиться к удаленному репозиторию на локальном диске (в просмотре директории будет создана папка по названию проекта).

+ git status - список файлов с текущими изменениями

+ git diff - просмотр всех текущих изменений

+ git diff my - file.htmlпросмотр изменений отдельных файлов

+ git commit - am "my comment about changes" 

+ git push - отгрузка комммитов на удаленный реп.

+ git log 5 - просмотр последних 5 коммитов

+ git log -1 -p - просмотр изменений последней коммиты

+ git log -5 --name-status - просмотр последних 5 коммитов с перечнеменных файлов
+ 11111111111111111111

https://cdn-media-1.freecodecamp.org/images/VQhi-KgyeBh6jegrDc2zaLOGxsBWq0Bw5dNq
Само изображение ![картинка не добавлена](221.png)
https://git-scm.com/docs

!!!!!
 
 Для того, чтобы просмотреть список настроенных удалённых репозиториев, вы можете запустить команду git remote. Она выведет названия доступных удалённых репозиториев. Если вы клонировали репозиторий, то увидите как минимум origin — имя по умолчанию, которое Git даёт серверу, с которого производилось клонирование: 
 git clone https://github.com/schacon/ticgit

+ Cloning into 'ticgit'...
+ remote: Reusing existing pack: 1857, done.
+ remote: Total 1857 (delta 0), reused 0 (delta 0)
+ Receiving objects: 100% (1857/1857), 374.35 KiB | 268.00 KiB/s, done.
+ Resolving deltas: 100% (772/772), done.
+ Checking connectivity... done.
+ $ cd ticgit
+ $ git remote
+ origin