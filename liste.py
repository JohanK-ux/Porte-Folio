def recherche_dichotomique( element, liste_triee ):
    a = 0
    b = len(liste_triee)-1
    m = (a+b)//2
    while a < b :
        if liste_triee[m] == element :
            return m
        elif liste_triee[m] > element :
            b = m-1
        else :
            a = m+1
        m = (a+b)//2
    return a
    
A = [5,16,48,120,144,256]
ind = recherche_dichotomique (A,5)
print (ind) 
def rechercher (liste, j):
    for i in range (len(liste)):
        if j == liste[i]:
            return i
