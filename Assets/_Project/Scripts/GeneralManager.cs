using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralManager : MonoBehaviour
{
    public enum PassthroughScene { Reconstructed, UserDefined };
    public PassthroughScene passthroughScene = PassthroughScene.Reconstructed;

    public void ChangeScene(int sceneIndex) 
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
