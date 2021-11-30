using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 2.0f;
    [SerializeField] ParticleSystem crashEffect;

    // private void Start() {
    //     Mesh mesh = GetComponent<MeshFilter>().mesh;
    //     mesh.RecalculateBounds();
    // }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground") {
            crashEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
