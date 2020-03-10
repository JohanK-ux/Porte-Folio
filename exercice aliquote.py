def ListeDiviseur(a):
    variable=[]
    for i in range (1,a):
        if a%i==0 : 
            variable.append(i)
    return variable

def SommeListe(liste):
    s=0
    i=1
    while i<len(liste) :
        s=s+liste[i]
        i=i+1
    return s
def suitealiquote(n):
    suite = [n]
    while n !=1 :
        l = ListeDiviseur(n)
        suite.append(SommeListe(l))
        n= suite[-1]
    return suite

    
a = int(input("Entez un nombre : "))
b = ListeDiviseur(a)
c = SommeListe(b)
d = suitealiquote(a)


print(d)
