using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAITargetMouse : MonoBehaviour {

    [SerializeField] private Transform targetTransform;

    private bool isFollowing = false;
    Vector3 mousePos = Input.mousePosition;

    private void Update() {
        if (isFollowing) {
            targetTransform.position = mousePos;
        }

        if (Input.GetMouseButtonDown(0)) {
            isFollowing = !isFollowing;
        }
    }

}
