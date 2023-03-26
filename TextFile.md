***This is first commit***
commit from github!
--------------------------------------------
**VSCode**

*Открыть папку в файл-менеджере (верхнияя пиктограмма в левом меню)*

*Меню Вид -> терминал*

git --version

git config --global user.email "vax@site.com"

git config --global user.name "Anton Khoroshaev"

git init

git status (в.ч. выведет название текущей ветки)

git add file_name

git commit -m "Message"

git log

git checkout commit_hash (можно полностью, но достаточно только первые 4 символа)

git checkout master

git diff - отображает разницу между последней сохранённой версией и текущей (в окне редактирования)

## Работа с ветвями

*clear - очистка в окне терминала*

git branch branch_name

git checkout branch_name

git merge branch_name (находясь при этом в головной ветви)

git branch -d branch_name (удалить ветвь).

*Если использовать -d то удалит только при отсутствии ошибок и сомнений
если -D то удалит в любом случае без вопросов.*

Файл .gitignore содержит перечень файлов, которые git будет игнорировать

git log --graph

*Сайт-тренажёр <https://learngitbranching.js.org>*

## Работа с удалёнными репозиториями и совместная работа

<https://Github.com>

git clone адрес

git pull

git push

Fork

git clone адрес

branch new_branch

*... изменения ...*

commit

push

pull request