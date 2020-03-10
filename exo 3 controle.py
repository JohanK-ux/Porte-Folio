#entrer une chaine de caractere puis entere un caractere
#calculer combien de fois le caracteres choisi est ds la chaine
#afficher le resultat

#la variable s contient la chaine de caracteres choise par utlis.
s=input("Entrer une chaine de caracteres : ")
#la variable c contient le caractere choisi par l'utilisateur
c=input("entrer un caractere: ")
#la variable n va permettre de compter. Elle est initialisée à 0.
n=0
#la boucle for fait varier la variable i de 0 jusqua la longueur
# de la chaine -1
for i in range (len(s)) :
# si le ieme caractere de la chaine est egal au caractere choisi
       if (s[i]==c) :
# on ajoute un dans la varible qui fait le compte
           n=n+1
       #affichage du resultat
print ("Dans la chaine ",s," il y a ",n," fois le caractere ",c) 
       
