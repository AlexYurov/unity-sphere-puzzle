using UnityEngine;
using System.Collections;

public class CubesController : MonoBehaviour
{
    public GameObject _sphereOriginal;
    public GameObject _camera;
    // Use this for initialization
    void Start()
    {
        var mesh = this.gameObject.GetComponent<MeshRenderer>();
        mesh.enabled = false;
        //TODO: Fill with 1-cubes
        var cubeSize = 5;
        var originalPosition = _sphereOriginal.transform.position;
        for (int i = 0; i < cubeSize; i++)
            for (int j = 0; j < cubeSize; j++)
                for (int k = 0; k < cubeSize; k++)
                {
                    var newSphere = Instantiate(_sphereOriginal);
                    newSphere.transform.position = new Vector3(
                        originalPosition.x + i,
                        originalPosition.y + j,
                        originalPosition.z + k);
                }
        var cameraPosition = _camera.transform.position;
        _camera.transform.position = new Vector3(cameraPosition.x, cameraPosition.y + cubeSize + _sphereOriginal.transform.localScale.y, cameraPosition.z);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
