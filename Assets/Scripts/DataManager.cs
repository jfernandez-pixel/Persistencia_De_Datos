using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{
    public string nombreUsuario;
    public int vitalidad;
    public int fuerza;
    public int destreza;
    public int inteligencia;
    public float experiencia;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        //LoadData();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1);
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            SaveData();
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            LoadData();
        }
    }

    /*void SaveData()
    {
        PlayerPrefs.SetString("NombreUsuaio", nombreUsuario);
        PlayerPrefs.SetInt("VitalidadPersonaje", vitalidad);
        PlayerPrefs.SetFloat("ExperienciaUsuario", experiencia);
    }

    void LoadData()
    {
        nombreUsuario = PlayerPrefs.GetString("NombreUsuaio", "Sin Nombre");
        vitalidad = PlayerPrefs.GetInt("VitalidadPersonaje", 1);
        experiencia = PlayerPrefs.GetFloat("ExperienciaUsuario", 0.5f);
    }*/

    void SaveData()
    {
        PlayerData.nombreUsuario = nombreUsuario;
        PlayerData.destreza = destreza;

        PlayerData.Save();
    }

    void LoadData()
    {
        PlayerData.Load();
        
        nombreUsuario = PlayerData.nombreUsuario;
        destreza = PlayerData.destreza;
    }
}
