***This is first commit***
commit from github!

# **Основы работы с удаленным репозиторием**

Для создания копии удаленного репозитория используется команда **git clone**.

Для начала работы с центральным репозиторием, следует создать копию оригинального проекта со всей его историей локально.

1. __Клонирует репозиторий, используя протокол *http:*__: git clone http://user@somehost:port/~user/repository/project.git

2. **Клонирует репозиторий с той же машины в директорию myrepo**: git clone /home/username/project myrepo

3. **Клонирует репозиторий, используя безопасный протокол ssh**: git clone ssh://user@somehost:port/~user/repository

4. **У git имеется и собственный протокол**: git clone git://user@somehost:port/~user/repository/project.git/

5. **Импортирует svn репозиторий, используя протокол http**: git svn clone -s http://repo/location, *где -s – понимать стандартные папки SVN (trunk, branches, tags)*

Для синхронизации текущей ветки с репозиторием используются команды *git fetch* и *git pull*.

**git fetch** — забирает изменения удаленной ветки из репозитория по умолчания, основной ветки; той, которая была использована при клонировании репозитория. Изменения обновят удаленную ветку (remote tracking branch), после чего надо будет провести слияние с локальной ветку командой git merge.

1. **Получает изменений из определенного репозитория**: git fetch /home/username/project.

2. **Возможно также использовать синонимы для адресов, создаваемые командой git remote**: git remote add username-project /home/username/project

3. **После оценки изменений, например, командой git diff, надо создать коммит слияния с основной**: git merge username-project/master

Команда *git pull* сразу забирает изменения и проводит слияние с активной веткой.

1. **git pull**: Забирает изменения и метки из определенного репозитория:

2. **git pull username-project --tags**: Как правило, используется сразу команда git pull.

После проведения работы в экспериментальной ветке, слияния с основной, необходимо обновить удаленный репозиторий (удаленную ветку). Для этого используется команда *git push*.

1. **Отправляет свои изменения в удаленную ветку, созданную при клонировании по умолчанию**: git push

2. **Отправляет изменения из ветки master в ветку experimental удаленного репозитория**: git push ssh://yourserver.com/~you/proj.git master:experimental

3. **В удаленном репозитории origin удаляет ветку experimental**: git push origin :experimental

4. **Отправляет в удаленную ветку master репозитория origin (синоним репозитория по умолчанию) ветки локальной ветки master**: git push origin master:master

5. **Отправляет метки в удаленную ветку master репозитория origin**: git push origin master --tags

6. **Изменяет указатель для удаленной ветке master репозитория origin (master будет такой же как и develop)**: git push origin origin/develop:master

7. **Добавляет ветку test в удаленный репозиторий origin, указывающую на коммит ветки develop**: git push origin origin/develop:refs/heads/test