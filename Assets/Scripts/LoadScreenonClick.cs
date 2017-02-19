using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScreenonClick : MonoBehaviour
{

    public class LoadSceneOnClick : MonoBehaviour
    {
        //Load scene according to order in scene index
        public void LoadByIndex(int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
