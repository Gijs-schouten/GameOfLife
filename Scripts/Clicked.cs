using UnityEngine;

public class Clicked : MonoBehaviour {
    private bool _isClicked = false;
    private SpriteRenderer _rend;

    private void Start() {
        _rend = GetComponent<SpriteRenderer>();
    }

    public void ChangeColour() {
        if (!_isClicked) {
            _rend.color = Color.black;
            _isClicked = true;
        } else {
            _rend.color = Color.white;
            _isClicked = false;
        }
    }
}
