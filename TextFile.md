***This is first commit***
commit from github!

## Github

Для работы с сервисом нужно для начала выполнить команды:
* git config --global user.email 'my@mail.ru' - задаем почту из аккаунта github
* git config --global user.name 'MyName' - имя пользователя

далее загружаем репозиторий из сервиса:
+ git clone 'link_github'

после внесения изменений отправляем репозиторий командой:
+ git push

Чтобы связать новый удаленный репозиторий с локальным используем:
+ git remote add origin link_github

отправляем изменения командой:
+ git push -u origin branch_name