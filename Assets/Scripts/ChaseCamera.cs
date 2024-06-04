using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// このコンポーネントはカメラを追加し、
/// ターゲットと自分の位置を同期し続ける機能を実装する
/// </summary>
public class ChaseCamera : MonoBehaviour
{
    public Transform TargetPillBugTransform;

    public Vector3 Target0ffset;
    
    
    // Start is called before the first frame update
     private void Start()
    {

        if (TargetPillBugTransform == null)
        {
            TargetPillBugTransform =
            GameObject.FindObjectOfType<PlayerMoveController>().transform;
        }
    }

    // Update is called once per frame
     private void LateUpdate()
    {
        this.transform.position =
            TargetPillBugTransform.position + Target0ffset;
    }
}
