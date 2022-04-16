The relational operator in shell scripting defines the relations between operands. The return value of these are either true or false depending on the operator and operands. There are 6 types of valid relational operators in shell scripting −
	•	== operator is the operator that equates the values of two operators. It returns true if the values are equal and returns false otherwise.
	•	!= operator is the operator that equates the values of two operators and check for their inequality. It returns true if the values are not equal and returns false otherwise.
	•	< operator is the less than operator comparing the values of two operators. If first operend’s value is smaller than seconds one then operator returns true otherwise returns false.
	•	<= operator is less than or equal to operator that compares the values of two operators. If first operend’s value is smaller than or equal to seconds one then operator returns true otherwise returns false.
	•	>operator is the greater than operator comparing the values of two operators. If first operend’s value is larger than seconds one then operator returns true otherwise returns false.
	•	>= operator is greater than or equal to operator that compares the values of two operators. If first operend’s value is larger than or equal to seconds one then operator returns true otherwise returns false.

												Example: Example
							a = 32
							b = 67
									if(( $a==$b ))
									then
									   echo a is equal to b.
									else
									   echo a is not equal to b.
									fi
									if(( $a!=$b ))
									then
									   echo a is not equal to b.
									else
									   echo a is equal to b.
									fi
									if(( $a<$b ))
									then
									   echo a is less than b.
									else
									   echo a is not less than b.
									fi

														Output
a is not equal to b.
a is not equal to b.
a is less than b.
a is less than or equal to b.
a is not greater than b.
a is not greater than or equal to b.
Boolean operator
Boolean operator also known as logical operators are used to perform logical operations in shell scripting. There are 3 types of valid logical operators in shell scripting −
	•	Logical AND (&&) calculates the logic AND of the value that boolean. It returns true if both operands are true, otherwise false.
	•	Logical OR (||) calculates logical OR operation of boolean operands. It returns false if both operands are false otherwise true.
	•	Logical Not Equal to (!) calculates the negation of the single operator passed. If the value of operand is true it returns false otherwise true.
Example
a = true
b = false
if(($a == "true" & $b == "true" ))
then
   echo Both are true.
else
   echo Both are not true.
fi
