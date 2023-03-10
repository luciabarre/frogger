using UnityEngine;

public class Home : MonoBehaviour
{
    public GameObject frog;

    private void OnEnable(){
        frog.SetActive(true);
    }

    private void OnDisable(){
        frog.SetActive(false);
    }

     private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player"){
            enabled = true;
            Frogger frogger = other.GetComponent<Frogger>();
            frogger.gameObject.SetActive(false);
            frogger.Invoke (nameof(frogger.Respwan), 1f);
            
        }
    }
}
