'''Create a dice roller game.'''

''' 
    - Generates a number between 1 and 6
    - Returns the result
'''

#easy way of doing it
import random 

def dice_roll_1():
    print("Dice Roll 1: ", random.randrange(1,6))

def dice_roll_2(min_dice = 1, max_dice = 6):
    print("Dice roll 2: ", random.randint(min_dice, max_dice))

def dice_roll_3():
    print("""
        Welcome to my python random dice program!
        To start press enter!
        Whenever you are done, type quit.
        """)
    
    while True:
        user_prompt = input("> ")
        if user_prompt.lower() == "quit":
            return False
        
        else:
            print("Rolling dice...\nYour number is: ")
            dice_roll_1()
            dice_roll_2()

dice_roll_3()
    
        
    
