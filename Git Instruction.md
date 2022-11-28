[downloads git]: https://git-scm.com/downloads 
[Visual Studio Code]: https://code.visualstudio.com/download
# Инструкция по работе с `Git` на Windows 10.
![image_01](https://sun9-73.userapi.com/impg/0DlD53ss4vWu3dSQ8oKnFO972fMLw5HNUnItDw/9Q1-JcXT7AE.jpg?size=1920x512&quality=95&sign=10dfea53029649238015f444944af86f&type=album) 
### `Git` -  распределённая система управления версиями. Проект был создан Линусом Торвальдсом для управления разработкой ядра Linux, первая версия выпущена 7 апреля 2005 года. На сегодняшний день его поддерживает Джунио Хамано.

![image_02](https://sun9-11.userapi.com/impg/XOcog8JbHkaH9tbjHTi3sfzPLpxN5b6T5EhGwA/O0r_hzxJg7w.jpg?size=350x450&quality=95&sign=1a1a49b2230e40c0af50565d25865c09&type=album)

## `Простым языком,`
## `git - это хранилище истории разработки.`

-----
# Вид работы git системы.
![image_03](https://sun9-87.userapi.com/impg/-hEv7hgB5XzERL1yXklHaxYyd7fkQXHkgGIJIA/6tGPhNk6Y-8.jpg?size=827x857&quality=95&sign=e873a517b7dcfcc17f43659bd8a97f91&type=album)


#  Установить программу на ваш пк.

* Скачать программу можно тут [downloads git].

* Пройти установку.

##  Запускаем программу `Git Bash` или открываем её сразу в папке проекта.
![image_13](https://sun9-36.userapi.com/impg/0vy6Rab0UmOV4uDBaxKrQVJGElUdWp9FUgPgqA/paFSuoQDok4.jpg?size=337x395&quality=95&sign=b1b46d1df946df67ce0aceaaea18d380&type=album)
![image_12](https://sun9-83.userapi.com/impg/U5ezaXr4jLnHqBHSW5fQxrC6DxseFQZjNgcAFw/kIl_Lzi6WQ0.jpg?size=495x564&quality=95&sign=62e3ab580ee4f04f3ea6f90715a7cdfe&type=album)


* В качестве примера буду использовать [Visual Studio Code].
* Буду использовать Terminal в Visual Studio Code, это тоже самое что и Git Bash.
* Все тоже самое можно проделать в Git Bash.
* `Важно:` Обратить внимание где мы находится  при открытии терминала. Переходим в папеку с нашим проектом. 
        
        
        Команда cd .. позволяет перемещаться по папкам системы.
        Мой проект находится в папке с таким адресом.
        C:\Школа GB\git_instraction
        У Вас должен быть свой.
        Лучше это сделать на отдельном диске, D:\ или F:\ если у Вас есть такие.
        
## Я буду показывать на примере этих команд:

* `init` (initiated, Инициированный)
* `add` (Добавить)
* `status` (Статус)  
* `commit` (Совершить)


![image_04](https://sun9-16.userapi.com/impg/ioswCtQP8A8XaVYISdKIs6-JnbmzW5dTSSPolA/q8yHDawWl8s.jpg?size=832x291&quality=95&sign=e0c4b1e8a46c3a5f8cba8108071cbd15&type=album)
* ## После этого делаем инициализацию проекта.          

    * Прописываем в терминале  Visual Studio Code:
                
            git init

*  ## Установка имени и электронной почты.
    * Если вы никогда ранее не использовали `git`, необходимо осуществить установку, чтобы `git` узнал ваше `имя` и `электронную почту`.
        

        git config --global user.name "Your Name"
        git config --global user.email "your_email@whatever.com" 

    * Далее мы проверяем статус программы:
            
            git status

    * Далее разрабатываем код и добавляем его в git:

            git add Git Instruction.md 
            or 
            git add .       



#  Перед работой с git кратко озникомимся с его командами. 
## Запустить рабочую область (см. также: git help tutorial).
                clone - Клонировать репозиторий в новый каталог
                 init - Создайте пустой репозиторий Git или повторно инициализируйте существующий                     
                        
## Работать над текущим изменением (см. также: git help каждый день).
                add - Добавить содержимое файла в индекс.
                mv - Переместить или переименовать файл, каталог или символическую ссылку.
                restore - Восстановить файлы рабочего дерева.
                rm - Удалить файлы из рабочего дерева и из индекса.
##  Изучить историю и состояние (см. также: версии git help).
                bisect - Использовать бинарный поиск, чтобы найти фиксацию, которая привела к ошибке.
                diff - Показать изменения между фиксациями, фиксацией и рабочим деревом и т. д.
                grep - Вывести строки, соответствующие шаблону.
                log - Показать журналы коммитов.
                show - Показать различные типы объектов.
                status - Показать статус рабочего дерева.

## Ветка Список, создание или удаление ветвей.
> Растите, отмечайте и корректируйте свою общую историю.

                commit - Записать изменения в репозиторий.
                merge - Объединить две или более истории развития вместе.
                rebase Reapply - совершает коммит поверх другого базового наконечника.
                reset - Сбросить текущий HEAD в указанное состояние.
                switch - Переключить ветки.
                tag - Создать, перечислить, удалить или проверить объект тега, подписанный с помощью 
                GPG.                


## Cотрудничать (см. также: рабочие процессы git help).
                fetch - Загрузка объектов и ссылок из другого репозитория.
                pull - Интегрировать с другим репозиторием или локальной веткой.
                push - Обновление удаленных ссылок вместе со связанными объектами.




#  Рассмотрим `git status` в моем случае.

![image_05](https://sun9-73.userapi.com/impg/dUxgkBp9ePQUEiikkUMJILJ7o70ZVMUBYvMlkw/Y8Mh8tjStPQ.jpg?size=1129x340&quality=95&sign=3308cda14b8b87139c7ed9c0fb33229f&type=album)

   * Я нахожусь в ветке мастер.
   * Еще нет коммитов.
   * Неотслеживаемые файлы:
                                
         (используйте "git add <file>...", чтобы указать, что будет зафиксировано)
         
         Git Инструкция.md
         Git_logo_1.0.png
         Инструкции по работе с Git-на-Windows-10.-main/
         README.md
         git-instruction.drawio.png

         git сам подсказывает, что делать.
   * Ничего не добавлено для фиксации, но присутствуют неотслеживаемые файлы (используйте «git add» для отслеживания). 
* Далее делаем:
                
        git add .        
* Мы видем:
![](https://sun9-62.userapi.com/impg/OcDPXH3lMrPZMdc3uJNBsXYEES9elxSzbmv8Gg/gs5kbKYfLSM.jpg?size=1111x314&quality=95&sign=527294babbeaef1a50a88b8de4c896fb&type=album)
   * Я нахожусь в ветке мастер.
   * Еще нет коммитов..
   * Изменения, которые необходимо зафиксировать.
* Далее мы создаем commit.
        
        git commit -m "first commit"
![image_06](https://sun9-85.userapi.com/impg/V7pZvXlkCGR4AzvsL50MQ-XjnTQKohdaSD3cgQ/JgbZIG8oqJY.jpg?size=787x262&quality=95&sign=107eab35ce714ff941e7f1527ed20d37&type=album)
* Первый commit создан, поздравляю.
 * git status скажет нам
 
        On branch master
        nothing to commit, working tree clean
    * Программа выполнена успешно, больше нечего коммитеть, наше дерево чисто. 

#  Очистка терминала 
 * Чтобы очитить терминал, нам нужно прописать 
                        
                clear

----
----

# Git использует двух ступентичаю систему сохранения изменения.
![image_09](https://sun9-62.userapi.com/impg/Tu_5IZynmV_YngrHio4EsXUdkncESwtqz1eFPg/zONC4vSO9UE.jpg?size=764x427&quality=95&sign=14e83912561efda90e297db51e2f359e&type=album)

* ## Что произошло после команды git init .
![](https://sun9-88.userapi.com/impg/qKJkly_p-bb1O9AhRig-_-7P4H4BioyIdLphxg/zrjz0ikWsB8.jpg?size=634x214&quality=95&sign=99c5070443e35da31022cc18778fa113&type=album) 
* Мы видем, что программа создала папку .git (*пустой git репозиторий*) это скрытая системная папка, в которой происходит версионирование. 
* ## Что произошло после команды git add Git Instruction.md .
  * git add . Работает примерно также.


![image_07](https://sun9-7.userapi.com/impg/4IZuZ_XgJzkaqckTSSc8PC8A8j4iZRwij2gaOw/CcRxPqLPT6g.jpg?size=764x655&quality=95&sign=74230f0dc01c859a3a75aca2a28681e2&type=album) 

* ## Что произошло после команды git commit -m 'First commit' .
  * Наш фаил попадает в репозиторий гит где он и хранится.

![image_08](https://sun9-77.userapi.com/impg/BLm-3Iaj4evSYBAXDq2B37Tj6V0WVsiQ61wRNw/HbRuNMWDNEg.jpg?size=776x507&quality=95&sign=47166e4f81a6c018c305f9647d3c927e&type=album)


* ## Примерно так выглядит история версий в git. 


![image_10](https://sun9-60.userapi.com/impg/nux0zXRQGntVyN-a7n5L2ZLfD703ed47LNA7Fg/Les_MisAjog.jpg?size=781x1111&quality=95&sign=eeee4bf521a845edb7b34cde7126da92&type=album)


# Делаем ответвление 

## Чтобы понять картинку выше приведу пример.


![image_11](https://sun9-79.userapi.com/impg/obJ5tmjabALmMPks9DV2xtUWbIeQLrKoUtdZAA/QDZQhZUR3T8.jpg?size=401x261&quality=95&sign=f9952bdaaf2c6a1987f94f1c8694dfce&type=album)
* Чтобы создать ветку пишем следующую команду 
                

        git branch Название Вашей ветки

        git branch Название вашей ветки


## Далее делаем работу во второй ветке
![image_12](https://sun9-84.userapi.com/impg/HcGkom51CDTSeNN7n4xvxgFwgzJ5cU8P4gyCYQ/JSDgfnX5IyE.jpg?size=491x521&quality=95&sign=eb288421ecc16354e919ce43a99b05fb&type=album)

* Незабываем сохранять файл и следуем следующим командам 

        git add .

        git commit -m 'Ваш комит'

        git checkout master 
                        
        Посмотреть где мы:

        git branch

## Соединяем ветки
![image_13](https://sun9-20.userapi.com/impg/AcVOh3C4FC7sW3MISHNizvgvz6Ll85EeKQ7m0A/ge5kZeHI1cM.jpg?size=512x701&quality=95&sign=610a83b348e83a53cb83abc15095d857&type=album)

* Чтобы соединить наши ветки используем слюдеющий код 

         git checkout master

         git merge Название Вашей 2 ветки
                        



# Работа с удаленным репозиторием **git**, с помощью **GitHub**.
![image_14](https://sun9-36.userapi.com/impg/l7kOlZiCR5Zp1zOLQHoyp7fW6wsinPje5QcgvA/UYAKEwfEf0k.jpg?size=395x571&quality=95&sign=303cd47f78a06a42213760010878955e&type=album)
## Начало работы с GitHub.

* Регистрируемся в **GitHub**.
* Создаем там репозиторий куда будем отправлять наш фаил.

![inage_15](https://sun9-81.userapi.com/impg/uDhVkgfy5dRw6PM_iUKkSrck4fJ9tSedCzPkNw/gJYDPX9ufEw.jpg?size=753x874&quality=95&sign=fc58e0cf7b06559d5db060240375f33a&type=album) 


* Даем имя репозиторию.
* Выбираем формат `ПАБЛИК`.
* По началу нам больше ничего не нужно.
* Нажимаем кнопку создать репозиторий.
* Далее мы видет такое окно.


![image16](https://sun9-73.userapi.com/impg/hPwv9bsx6hSbDdV_C7_t56m_zrrVJhFnMSJ7vA/nNA8sYwaLfk.jpg?size=928x750&quality=95&sign=7ce967aa192d555051244665e5e301c9&type=album)
* Следуем иструкции.
* После проверяем, что мы выгрузили в наш репозиторий.

Instructions-for-working-with-Git-on-Windows-10.


https://github.com/IlyaWaffle/Group_555.git