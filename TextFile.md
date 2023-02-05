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