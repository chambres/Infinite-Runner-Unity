#!/usr/bin/env sh
echo Commit message:

read varname

git add .
git commit -m "$varname"
git push origin main