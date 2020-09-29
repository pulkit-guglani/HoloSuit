using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    bool isRotating;
    [SerializeField] Renderer Base_renderer;
    // Start is called before the first frame update

    // Update is called once per frame
   public void RotateLeft()
    {
        if (isRotating == true)
            return;

        isRotating = true;
        transform.LeanRotateY(-45+ transform.rotation.eulerAngles.y, 1).setEaseInOutCubic();
        StartCoroutine(AfterRotation());

    }
    public void RotateRight()
    {
        if (isRotating == true)
            return;

        isRotating = true;
        transform.LeanRotateY(45+transform.rotation.eulerAngles.y, 1).setEaseInOutCubic();
        StartCoroutine(AfterRotation());
    }

    IEnumerator AfterRotation()
    {
        Base_renderer.material.color = new Color(0.8f, 0.8f, 0.8f);

        yield return new WaitForSeconds(1);
        isRotating = false;
        Base_renderer.material.color = new Color(0, 0.6f, 1f);


    }
}
