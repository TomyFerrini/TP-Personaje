class PersonajeDeMagia : Personaje
{
    public PersonajeDeMagia(string nombre, int fuerza, int agilidad, int magia)
    {
        Nombre = nombre;
        Fuerza = fuerza;
        Agilidad = agilidad;
        Magia = magia;
    }

    public PersonajeDeMagia(string nombre, int fuerza, int agilidad)
    {
        Nombre = nombre;
        Fuerza = fuerza;
        Agilidad = agilidad;
        Magia = 60;
    }
    public override int CalcularDanio()
    {
        return Fuerza + Agilidad + Magia * 4;
    }
    public override void Atacar()
    {
        Console.WriteLine(Nombre + " hizo " + CalcularDanio() + " de daño gracias a su magia.");
    }
}    

