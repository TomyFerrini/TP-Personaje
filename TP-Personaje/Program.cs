PersonajeDeAgilidad PdeAgilidad = new PersonajeDeAgilidad("Spiderman", 7, 92, 11);
PersonajeDeFuerza PdeFuerza = new PersonajeDeFuerza("Hulk", 70, 10);
PersonajeDeMagia PdeMagia = new PersonajeDeMagia("Merlin", 14, 50, 100);
Enemigo pEnemigo = new Enemigo(100, 8);

IList<Personaje> personajes = new List<Personaje>();
personajes.Add(PdeAgilidad);
personajes.Add(PdeFuerza);
personajes.Add(PdeMagia);

Turno.Atacarse(personajes);
Turno.MoverFichas(PdeFuerza);
Turno.MoverFichas(pEnemigo);