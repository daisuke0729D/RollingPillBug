using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGoal : MonoBehaviour
{
    /// <summary>
    /// コンポーネントが追加されたGameObjectのCollider2DのIsTriggerにチェック
    /// が入っており当たってくるGameObjectにRigidbodyとCollider2Dがあった場合、
    /// 実行される侵入処理
    /// </summary>
    /// <parem name="collision"></parem>
    
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Goal!!");
    }
}
