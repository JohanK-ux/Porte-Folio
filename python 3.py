dommage = int(input("saisie le montant de dommages"))
franchise = (10*dommage)/100
if franchise < 15 :
    franchise = 15
if franchise >50 :
        franchise = 50
        rembourse = degats - franchise ; 
        print("montant remboursé par l'assurance :", rembourse)
else : 
    print(" montant de la franchise:", franchise)
    print("la franchise ne correspond pas aux criteres")
