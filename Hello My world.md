# First File on Versions Control

## Text Formatting

*Itallic.* To format text as Itallic - frame it with the Stars (*).*This is a text sample, please do not copy.*

**Bold.** To format text as Bold - frame it with the Double Stars (**).**This is a text sample, please do not copy.**

There is also an Underescore (_) for Itallic and a Double Underscore (__) framing for Bold formatting in case of need to use both formats. ***This is a text sample,* please do not copy.**

<sup>Subscript<sub> To make text subscript use sub short command surrounded by (<>)

## Lists

Unordered lists:

* line 1
* line 2
* line 3

Ordered lists:

1. First element
2. Second element
3. Third one

## Include images

To add an image it should be added to the folder in JPEG format and then use the following indicators:
![Coding is Future](coding.jpg)

*Note: there are no space breaks and (possibly) the name should consist of one word line.*

## Quotations

To show that the text is a quote, use (>) symbol. For example:
>Your time is limited, so don't waste it living someone else's life ... Stay Hungry. Stay Foolish. (Steve Jobs, October 6, 2011).

## Links

If I have some free time, I will watch this video [Way to IT](https://gb.ru/path-to-it/it_trends).

In order to make a link, use the "["]"(")") brackets or a shortcut comman/ctrl+K after selecting a text.

## Group work - how to make a task list and mention a group member to assign a task

## Task list

**Make a list of assignments** by using hyphen (-), space and [] frame.

This is to demonstrate the list:

* [ ] Install GIT and VS Code
* [ ] make sure you linked git to VS code
* [ ] foolow up instructions

When a task is done, use (x) to indicate this:

* [x] Install GIT and VS Code
* [x] make sure you linked git to VS code
* [x] follow up instructions

**To mention a group member**, you should use (@) symbol - this will bring their attention to the issue.
For example: @gracioza makes the steps written in above list.

## Emoji

Add emoji to text by typing :EMOJICODE:

Typing <:> will bring up a list of emoji. For example:

This is cool :+1:  
You are a star :star:
This emoji means nothing only to create a conflict :rainbow:

## Working with remote Repository

**Git push** command:

The git push command takes two arguments:

- A remote name

- A branch name

For example: git push REMOTE-NAME BRANCH-NAME

**Renaming braches**

To rename a branch, use the same (git push) command, but also add one more argument: the name of the new branch. For example:

git push REMOTE-NAME LOCAL-BRANCH-NAME:REMOTE-BRANCH-NAME

**Deleting a remote branch**

The syntax to delete a branch is a bit resembles the same steps you'd take to rename a branch:

git push REMOTE-NAME : BRANCH-NAME
*Note that there is a space before the colon.*

**Remotes and forks**

When you clone a repository you own, you provide it with a remote URL that tells Git where to fetch and push updates. 

If you want to collaborate with the original repository, you should add a new remote URL, which is called upstream, to your local Git clone:

git remote add upstream THEIR_REMOTE_URL

After you are done with making updates ad chenges, you can iinitiate a (PULL) command.

**PULL requests**

Pull requests show others about changes you have pushed to a branch in a repository on GitHub. Once a pull request is opened, you can discuss and review the potential changes with colleagues and add follow-up commits before your changes are merged into the base branch.

**CLONE command**

To duplicate a repository without forking it, use a (CLONE) command, then mirror-push to the new repository.

1. Open Git Bash
2. Create a bare clone of the repository:

Example: (git clone --bare (https://github.com/gracioza/HomeTask-3.git)