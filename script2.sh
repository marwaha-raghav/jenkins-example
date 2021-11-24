#!/bin/bash
WD=$(pwd)
REPO_PATH=$WD/test1
#create file with list of branches
for repo in $REPO_PATH
do
    #UPDATE
    echo "working on ${REPO_PATH}"
    git -C $repo pull
    # copy branches in a file
    touch "${WD}/fil.txt"
    git -C $repo branch -a > "${WD}/fil.txt"
    # extract branch names.
    SIZE=$(cat ${WD}/fil.txt | grep "remotes" | grep -v "HEAD"|grep -v "main")
    for branch in $SIZE
    do
        COMMAND=$(echo "${branch}" | sed 's/.*origin\///')
        git -C $repo checkout $COMMAND
        echo "branch checked out"
    done
done
