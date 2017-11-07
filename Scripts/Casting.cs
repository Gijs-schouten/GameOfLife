using UnityEngine;

public class Casting : MonoBehaviour {

    private void Start() {
        
    }
 
    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f)) {
                hit.collider.GetComponent<Clicked>().ChangeColour();
            }
        }
    }
}
