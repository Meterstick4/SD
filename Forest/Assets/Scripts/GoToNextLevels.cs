using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLevels : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("OK");
            GameObject player = GameObject.FindGameObjectWithTag("Player");
          
            player.GetComponent<WorldSwitcher>().nextToStages();
            player.GetComponent<WorldSwitcher>().setLocat();
            Destroy(GameObject.FindGameObjectWithTag("Audio"));
            SceneManager.LoadScene(2);
        }

    }
}
