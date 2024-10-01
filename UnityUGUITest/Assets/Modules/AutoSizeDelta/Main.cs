using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AutoSizeDelta
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private Item[] _items;


        private void Start()
        {
            StartCoroutine(nameof(Test));
        }

        private IEnumerator Test()
        {
            while (true)
            {
                for (int i = 0; i < 4; i++)
                {
                    var item = _items[i];
                
                    item.Active();
                    yield return new WaitForSeconds(1f);
                    item.Inactive();
                }
            }
        }
    }   
}
