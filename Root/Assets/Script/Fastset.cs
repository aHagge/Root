using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace TMPro.Examples
{
    public class Fastset : MonoBehaviour
    {

        public bool woodtext, stonetext;
        // Use this for initialization
        void Start()
        {
            if (woodtext)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = ("+" + Tree.randomwood).ToString();
            }
            if (stonetext)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = ("+" + Rock.randomstone).ToString();
            }

        }
    }
}