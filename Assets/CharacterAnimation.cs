using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterAnimation : MonoBehaviour
{

    public InputActionAsset liamsAS;
    public Animator liamsANI;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(liamsAS.FindAction("Move").IsPressed())
        {
            liamsANI.SetBool("isRun", true);
        }
        else
        {
            liamsANI.SetBool("isRun", false);
        }
    }
}
