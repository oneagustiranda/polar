using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(MeshCollider))]
public class BuildingSelector : MonoBehaviour
{
    public string sceneName;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}
