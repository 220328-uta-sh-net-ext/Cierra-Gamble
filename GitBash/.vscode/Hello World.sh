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