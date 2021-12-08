# [Does my number look big in this?](https://www.codewars.com/kata/5287e858c6b5a9678200083c)

Число Армстронга (также самовлюблённое число, совершенный цифровой инвариант; англ. pluperfect digital invariant, PPDI)  — натуральное число, которое в данной системе счисления равно сумме своих цифр, возведённых в степень, равную количеству его цифр.

Например число 153 (3 цифры) самовлюбленное:

`1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153`

А число 1652 (4 цифры) не самовлюбленное:

`1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938`

## Задача:

Необходимо написать функцию, которая принимает число и возвращает true если число самовлюбленное и false если нет.



# [Does my number look big in this?](https://www.codewars.com/kata/5287e858c6b5a9678200083c)

A [Narcissistic Number](https://en.wikipedia.org/wiki/Narcissistic_number) is a positive number which is the sum of its own digits, each raised to the power of the number of digits in a given base. In this Kata, we will restrict ourselves to decimal (base 10).

For example, take 153 (3 digits), which is narcisstic:

`1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153`

and 1652 (4 digits), which isn't:

`1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938`

## The Challenge:

Your code must return true or false (not 'true' and 'false') depending upon whether the given number is a Narcissistic number in base 10.