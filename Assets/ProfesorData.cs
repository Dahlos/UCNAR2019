using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfesorData : MonoBehaviour {
    public Text nombre;
    public Text cargo;
    public Text grado;
    public Image photo;
    public ProfesorObject profesor;

    /// <summary>
    /// Called when the script is loaded or a value is changed in the
    /// inspector (Called in the editor only).
    /// </summary>
    void OnValidate () {
        if (nombre.text != null)
            nombre.text = profesor.nombre;
        if (grado.text != null)
            grado.text = profesor.grado;
        if (cargo.text != null)
            cargo.text = profesor.cargo;
        // if (photo != null)
        //     photo = profesor.photo;
    }

    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }
}