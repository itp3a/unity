@echo off
SET COMMIT=%USERNAME%
git add .
git commit -am "%COMMIT%"
git pull --allow-unrelated-histories
git push
pause