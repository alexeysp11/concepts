@echo off

set "mainDir=data"
set "file=test.db"

if not exist %mainDir% (
    mkdir %mainDir%
)

if not exist %mainDir%\db (
    mkdir %mainDir%\db
)

if not exist %mainDir%\db\%file% (
    copy NUL %mainDir%\db\%file%
)

echo Operations completed.