using UnityEditor;
using UnityEngine;

[CreateAssetMenu (menuName = "UCN/Profesores/ProfesorOBJ")]
public class ProfesorObject : ScriptableObject {
    public string nombre;
    public string cargo;
    public string grado;
    public Texture2D foto;
    public ProfesorObject () { }

   
}