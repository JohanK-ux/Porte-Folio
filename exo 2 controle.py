# ds exo 2
#entrer un nombre entier
# calculer la somme des entiers de 1 jusqu'au nombre saisi
#afficher le resultat

# la variable n contient le nombre choisi par l'utilisateur
n= int(input("entrer un nombre entier:  "))
#la variable s va permettre le calcul de la somme.
#elle est initialisé par 0
s = 0
#La boucle for fait varier la variable i de 1 jusqua n
for i in range (1,n+1):
    s=s+i
#afficher le resultat
print ("La somme des entiers de 1 à ",n," est egale à : ",s)
    
