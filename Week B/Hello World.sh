#single line comment
: '
multi
lint
comment
'

#Shebang / hash bang -> mentions which shell to be used and location in OS
#! /usr/bin/bash 

#prints/records Hello World when file is run use the "echo" command
echo "Hello World"

#System Defined Variables = $CAPITAL
#Can be written with or without quotes after the echo command
echo My home directory is $HOME
echo "MY CURRENT shell IS $BASH"
echo "My shell version is $BASH_VERSION"
echo "My current directory is  $PWD"

# User defined variables, use A-Z, a-z, 0-9 or _
_USD=10
echo "The value is $_USD"

_USD=20
echo "The changed value is $_USD"

readonly pi=3.14
#readonly pi # this will lock the value and it cannot be changed or unset
##unset pi # unset is use to remove a value but with readonly variables it cannot be unset
#pi=22.7
echo "the value of pi is $pi"