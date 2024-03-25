using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera DeathCamera;

    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void ShowOverheadView()
    {
        firstPersonCamera.enabled = false;
        DeathCamera.gameObject.SetActive(true);
    }

    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowFirstPersonView()
    {
        firstPersonCamera.enabled = true;
        DeathCamera.gameObject.SetActive(false);
    }

    private void Start()
    {
        ShowFirstPersonView();
    }

    private void OnDestroy()
    {
        ShowOverheadView();
    }
}
