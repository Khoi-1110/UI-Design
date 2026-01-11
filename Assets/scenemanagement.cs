using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    public string scenename;
    void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene(scenename);

    }

}
