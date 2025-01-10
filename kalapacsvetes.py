# 2. Feladat
class Sportolo:
    def __init__(self, helyezes, eredmeny, nev, orszagkod, helyszin, datum):
        self.helyezes = int(helyezes)
        self.eredmeny = float(eredmeny)
        self.nev = nev
        self.orszagkod = orszagkod
        self.helyszin = helyszin
        self.datum = datum