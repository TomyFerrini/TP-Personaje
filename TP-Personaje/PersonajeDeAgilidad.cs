class PersonajeDeAgilidad : Personaje
{
    public PersonajeDeAgilidad(string nombre, int fuerza, int agilidad, int magia)
    {
        Nombre = nombre;
        Fuerza = fuerza;
        Agilidad = agilidad;
        Magia = magia;
    }

    public override int CalcularDanio()
    {
        return Fuerza / 2 + Agilidad + Magia / 2;
    }
}

