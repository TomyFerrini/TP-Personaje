class PersonajeDeFuerza : Personaje
{
    public PersonajeDeFuerza(string nombre, int agilidad, int magia)
    {
        Nombre = nombre;
        Fuerza = 100;
        Agilidad = agilidad;
        Magia = magia;
    }

    public override int CalcularDanio()
    {
        return  (Fuerza * 2) + Agilidad + Magia;
    }
        
}

