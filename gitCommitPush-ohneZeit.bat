@echo off
SET COMMIT=%USERNAME%
git --allow-unrelated-histories
git add .
git commit -am "%COMMIT%"
git pull
git push
pause