using UnityEngine;

public class Spawner : MonoBehaviour {
    public int width;
    public int height;

    public GameObject cell;
    public GameObject[,] cells;

    private void Start() {
        cells = new GameObject[width, height];

        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                cells[i, j] = Instantiate(cell, new Vector3(i, j, 0), Quaternion.identity);
                cells[i, j].gameObject.name = i + " : " + j;
            }
        }

    }
}
