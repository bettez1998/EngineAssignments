using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene(1);
    }
}
