## Remote Git instuction

_git clone link_ - use this command if you want to copy remote resository to your computer;

_git pull_- use it if you want to copy smth from your remote repository into your local repository;
**Remember** _pull command_ links everything like _command merge_

_git push_-  use it if you want to transfer your changes or addings from local into remote repository;

## if you want to move your local repository to github follow next instuctions:
1. create empty repository in github
2. open your repository with vsc
3. copy the link of your created before remote repository
4. use command _git remote add origin link(of your remote repository)_(origin -it's only name)
5. after that if you want to move some changes from your local repository into remote use _git push -u origin master_
6. next you can use _git push_ instead of _git push -u origin master_

## if you want to create or delete branches
* create new branch
* checkout a new branch
* _git push -u origin **name  of new branch**_
* _git push -d origin **name of branch**_