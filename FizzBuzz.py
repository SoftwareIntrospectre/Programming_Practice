'''Write a program that prints the numbers from 1 to 100
But for multiples of three print 'Fizz' instead of the number
and for multiples of five print 'Buzz'. For numbers which are 
multiples of both three and five print 'FizzBuzz'.'''

def FizzBuzz():

    for number in range(1, 101):

        if number % 3 == 0 and number % 5 == 0:
            print ('FizzBuzz')

        # only want to grab divisible by 3 after first case
        elif number % 3 == 0: 
            print('Fizz')

         # only want to grab divisible by 5 after first case
        elif number % 5 == 0:
            print ('Buzz')

        else:
            print(number)

FizzBuzz()
