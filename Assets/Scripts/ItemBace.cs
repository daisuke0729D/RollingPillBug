using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// ゲーム内に登場するItemのベースクラス
/// 基礎クラスとも呼ばれます
/// </summary>


public class ItemBace : MonoBehaviour
{   /// <summary>
    /// アイテムを取得するときの実行内容を
    /// ItemBaseを継承したコンポーネントに委ねる
    /// </summary>


    protected UnityAction catchItemAction;





    /// <summary>
    /// OnTriggerEnter2Dは侵入判定を取得します
    /// Rigidbody2Dが追加されたGameObjectがこのコンポーネントを持つGameObjectに
    /// 侵入してきた場合、cacthItemActionが実行されます
  　/// </summary>
    /// <param name="collision"></param>
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (catchItemAction != null) 
        {
            catchItemAction.Invoke();
        }
    }
}


    

