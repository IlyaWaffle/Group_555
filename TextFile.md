***This is first commit***
commit from github!
## Content

* [Basic commands](#basic-commands)

* [Work with history](#work-with-history)

* [Working with branches](#working with branches)

* [Working with remote repositories](#working-with-remote-repositories)


- **git init** - Creates a local repository in the current folder.

- **git add** - Adds the specified files to the repository/to the next commit.

- **git add .** - Add all files in the current folder.

- **git add <File name>** - Add a specific file.

- **git commit** - Commits all changes made to a new "commit".

- **git commit -a** - Include in commit all files ever previously included in the repository.

- **git commit -m "<Description>"** - Add a description to the commit.

- **git diff** - Displays all changes made since the previous commit.

- **git diff <commit1> <commit2>** - Displays changes relative to two commits.

- **git status** - Displays the current status of the repository.



## Working with history

- **git log** - View the commit history of the current branch.

- **git log --oneline** - One line = one commit.

- **git log --graph** - Displays the history of changes in a graphical form.

- **git reflog** - View the entire history of repository actions.

- **git checkout <commit hashcode>** - View the status of the project at the time of the selected commit. (Sets the Head pointer to the selected commit.)


## Working with branches

- **git branch** - View a list of all available branches. The current branch is highlighted with a *.

- **git branch <Name>** - Create a new branch based on the current one.

- **git branch -d <Name>** - Delete the selected branch. (All commits that were in this branch are not deleted from the repository and they can always be found using git reflog)

- **git checkout <Name>** - Make the selected branch active.

- **git checkout -b <Name>** - Create a new branch and immediately make it active.

- **git merge <Name>** - Merge the selected branch with the currently active branch.

- **git diff <branch1> <branch2>** - Displays changes relative to two branches.



## Working with remote repositories




- **git clone <Link not repository>** - Download the selected repository to the current working folder.




- **git remote add <Name> <Link to the remote repository>** - Connect the selected remote repository.




- **git fetch** - Downloads from a remote repository all changes that are missing from the local repository and makes them to the local repository.




- **git pull** - Downloads from the remote repository all changes that are missing from the local repository and makes them to the local repository and to the user's workspace.




- **git push** - Uploads to the remote origin repository all changes made in the local repository.




- **git push <Remote repository name> <Unloaded branch>** - Uploads the specified branch to the remote repository.


fish-cone

