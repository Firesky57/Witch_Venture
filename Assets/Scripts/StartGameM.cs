using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameM : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)||(Input.touchCount>0))
        {
            StartGame();
        }
    }

    private void StartGame()
    {
        SpawnManager.Instance.StartScript();
    }
}
