using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeleteTarget : MonoBehaviour
{
    public static DeleteTarget instance;

    private float time = 1;


    // Start is called before the first frame update
    private void Awake()
    {
      
        StartCoroutine(Destroy());
        
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(time);
        Object.Destroy(gameObject);
    }
}
