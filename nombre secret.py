from random import *
r = randrange(1,30)
a=1
print(r) 
#boucle permetant au joueur de faire les 10 essais
while(a<11):
    b=int(input("saissisez un nombre a :  "))
    if(b==r):
        print("Vous avez trouver le nombre gangant qui est ", b)
        break
    
    else:
        (b != r)
        print("Vous n'avez pas reussi à trouver le nombre secret, réessayé")
    a=a+1

    
        
              
