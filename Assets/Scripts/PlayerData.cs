using UnityEngine;

public static class PlayerData 
{
    public static string nombreUsuario;
    public static int vitalidad;
    public static int fuerza;
    public static int destreza;
    public static int inteligencia;
    public static float experiencia;
    public static Vector3 lastPosition;

    public static void Save()
    {
        PlayerPrefs.SetString("nombreUsuario", nombreUsuario);
        PlayerPrefs.SetInt("VitalidadUsuario", vitalidad);
        PlayerPrefs.SetFloat("ExperienciaUsuario", experiencia);
    }

    public static void Load()
    {
        nombreUsuario = PlayerPrefs.GetString("NombreUsuario", "Sin Nombre");
        vitalidad = PlayerPrefs.GetInt("VitalidadPersonaje", 1);
        experiencia = PlayerPrefs.GetFloat("ExperienciaUsuario", 0.5f);
    }
}

