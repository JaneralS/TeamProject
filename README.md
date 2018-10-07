# TeamProject
Git command for download and upload

#step 1
run command to your local machine git clone https://github.com/YizhenS/TeamProject


#step 2
Create a dev branch
git checkout -b MY-DEV-BRANCH


#step 3
MAKE SURE YOU ARE ALWAYS DEVELOPING TO YOUR DEV BRANCH AND NEVER PUSH TO YOUR DEV BRANCH!
to get to your branch, use:
git checkout MY-DEV-BRANCH

#step 4
Do your job make the website look pretty

#step 5
if you want to commit to your branch but not push to the master (ie. your done for the day but not completely done with your component)
*make sure youre on your branch*
git add -A       <- adds all files to your staging area
git commit -m "write a brief summary of what you are commiting here"  <- commits your changes
DONE

#step 6

If you want to push to master (ie. your component is done and works)
    ***MAKE SURE YOU ARE ON YOUR DEV BRANCH!!!***
    a) git add -A  <-add all of the files to the staging area
    b) git commit -m "short message here"  <-commiting your code
    c)git checkout master  <-checking out the master branch
    d)git pull  <- pulling down any other work someone has done and pushed to the project
    e)git checkout MY-DEV-BRANCH <- changing back to your branch
    f)git rebase master  <- adds any changes you recently pulled down to the master to your dev branch
    g)git checkout master  <- switch back to the master branch
    h)git merge MY-DEV-BRANCH <- merges your changes to the master branch
    i)git push  <-pushes the master branch to gitlab with all of your changes
    j) ***THE MOST IMPORTANT ONE*** git checkout MY-DEV-BRANCH  <- make sure you go back to your branch and work from there
    
    Note: steps c, d, e, and f are *technically* optional if you are POSITIVE that the master is already up to date.

