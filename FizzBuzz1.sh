#! /usr/bin/bash

#Write a number that's between 1 and 20. 

read -p "Enter a number " number

if [[ $number -le 0 || $number -gt 20 ]] 
then 
	echo Please enter a number between 1 and 20.

#If number is divisible by 3, use Fizz. If number is divisible by 5, us Buzz. If number is divisible by 3 and 5, use FizzBuzz.

else 
	if test $((number % 5)) -eq 0 && test $((number % 3)) -eq 0
		then 
		echo FizzBuzz
	elif test $((number % 5)) -eq 0
		then 
		echo Fizz
	elif test $((number % 3)) -eq 0
		then 
		echo Buzz 
	else 
	echo Access Denied! XD
	fi  
fi