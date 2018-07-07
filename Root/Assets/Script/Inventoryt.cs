using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro.Examples
{
    public class Inventoryt : MonoBehaviour
    {
        public int totalwood;
        public int totalstone;
        public int totaltreeplant;
        private TextMeshProUGUI howmanyofthatitemhotbar1, howmanyofthatitemhotbar2, howmanyofthatitemhotbar3, howmanyofthatitemhotbar4, howmanyofthatitemhotbar5, howmanyofthatitemhotbar6, howmanyofthatitemhotbar7, howmanyofthatitemhotbar8, howmanyofthatitemhotbar9, howmanyofthatitemhotbar10;
        public Transform[] Hotbarslots;
        public bool itemin1, itemin2, itemin3, itemin4, itemin5, itemin6, itemin7, itemin8, itemin9, itemin10;
        public GameObject imgprefab;
        public bool exwood, exstone,explant;
        private string iteminslot1, iteminslot2, iteminslot3, iteminslot4, iteminslot5, iteminslot6, iteminslot7, iteminslot8, iteminslot9, iteminslot10;
        public Sprite stoneimg;
        public Sprite plantsprite;
        public KeyCode equipslot1, equipslot2, equipslot3, equipslot4, equipslot5, equipslot6, equipslot7, equipslot8, equipslot9, equipslot10;
        public static int equipedslot;
        public Treeplanting treescript;
        // 0 = wood

        void Start()
        {
        }






        void Update()
        {
            if(Input.GetKeyDown(equipslot1))
            {
                equipedslot = 1;
                Hotbarslots[0].GetComponent<RectTransform>().sizeDelta = new Vector2(45, 45);
                Hotbarslots[1].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[2].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[3].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[4].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[5].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[6].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[7].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[8].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[9].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);

            }
            if (Input.GetKeyDown(equipslot2))
            {
                equipedslot = 2;
                Hotbarslots[0].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[1].GetComponent<RectTransform>().sizeDelta = new Vector2(45, 45);
                Hotbarslots[2].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[3].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[4].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[5].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[6].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[7].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[8].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[9].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
            }
            if (Input.GetKeyDown(equipslot3))
            {
                equipedslot = 3;
                Hotbarslots[0].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[1].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[2].GetComponent<RectTransform>().sizeDelta = new Vector2(45, 45);
                Hotbarslots[3].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[4].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[5].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[6].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[7].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[8].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[9].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
            }
            if (Input.GetKeyDown(equipslot4))
            {
                equipedslot = 4;
                Hotbarslots[0].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[1].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[2].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[3].GetComponent<RectTransform>().sizeDelta = new Vector2(45, 45);
                Hotbarslots[4].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[5].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[6].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[7].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[8].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[9].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
            }
            if (Input.GetKeyDown(equipslot5))
            {
                equipedslot = 5;
                Hotbarslots[0].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[1].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[2].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[3].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[4].GetComponent<RectTransform>().sizeDelta = new Vector2(45, 45);
                Hotbarslots[5].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[6].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[7].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[8].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[9].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
            }
            if (Input.GetKeyDown(equipslot6))
            {
                equipedslot = 6;
                Hotbarslots[0].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[1].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[2].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[3].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[4].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[5].GetComponent<RectTransform>().sizeDelta = new Vector2(45, 45);
                Hotbarslots[6].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[7].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[8].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[9].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
            }
            if (Input.GetKeyDown(equipslot7))
            {
                equipedslot = 7;
                Hotbarslots[0].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[1].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[2].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[3].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[4].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[5].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[6].GetComponent<RectTransform>().sizeDelta = new Vector2(45, 45);
                Hotbarslots[7].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[8].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[9].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
            }
            if (Input.GetKeyDown(equipslot8))
            {
                equipedslot = 8;
                Hotbarslots[0].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[1].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[2].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[3].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[4].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[5].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[6].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[7].GetComponent<RectTransform>().sizeDelta = new Vector2(45, 45);
                Hotbarslots[8].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[9].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
            }
            if (Input.GetKeyDown(equipslot9))
            {
                equipedslot = 9;
                Hotbarslots[0].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[1].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[2].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[3].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[4].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[5].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[6].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[7].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[8].GetComponent<RectTransform>().sizeDelta = new Vector2(45, 45);
                Hotbarslots[9].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
            }
            if (Input.GetKeyDown(equipslot10))
            {
                equipedslot = 10;
                Hotbarslots[0].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[1].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[2].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[3].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[4].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[5].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[6].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[7].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[8].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
                Hotbarslots[9].GetComponent<RectTransform>().sizeDelta = new Vector2(45, 45);
            }





            //wood
            if (itemin1 == true && iteminslot1 == ("wood"))
            {
                if(totalwood > 0)
                {
                    Hotbarslots[0].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalwood.ToString();
                }
            }
            if (itemin2 == true && iteminslot2 == ("wood"))
            {
                if (totalwood > 0)
                {
                    Hotbarslots[1].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalwood.ToString();
                }
            }
            if (itemin3 == true && iteminslot3 == ("wood"))
            {
                if (totalwood > 0)
                {
                    Hotbarslots[2].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalwood.ToString();
                }
            }
            if (itemin4 == true && iteminslot4 == ("wood"))
            {
                if (totalwood > 0)
                {
                    Hotbarslots[3].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalwood.ToString();
                }
            }
            if (itemin5 == true && iteminslot5 == ("wood"))
            {
                if (totalwood > 0)
                {
                    Hotbarslots[4].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalwood.ToString();
                }
            }
            if (itemin6 == true && iteminslot6 == ("wood"))
            {
                if (totalwood > 0)
                {
                    Hotbarslots[5].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalwood.ToString();
                }
            }
            if (itemin7 == true && iteminslot7 == ("wood"))
            {
                if (totalwood > 0)
                {
                    Hotbarslots[6].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalwood.ToString();
                }
            }
            if (itemin8 == true && iteminslot8 == ("wood"))
            {
                if (totalwood > 0)
                {
                    Hotbarslots[7].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalwood.ToString();
                }
            }
            if (itemin9 == true && iteminslot9 == ("wood"))
            {
                if (totalwood > 0)
                {
                    Hotbarslots[8].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalwood.ToString();
                }
            }
            if (itemin10 == true && iteminslot10 == ("wood"))
            {
                if (totalwood > 0)
                {
                    Hotbarslots[9].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalwood.ToString();
                }
            }
            totalwood = Tree.wood;
            if(exwood == false)
            {
                if (totalwood > 0)
                {
                    if (itemin1 == false)
                    {
                        iteminslot1 = "wood";
                        exwood = true;
                        itemin1 = true;
                        Instantiate(imgprefab, Hotbarslots[0].position, Quaternion.identity, Hotbarslots[0]);                       
                    }
                    else
                    {
                        if (itemin2 == false)
                        {
                            iteminslot2 = "wood";
                            exwood = true;
                            itemin2 = true;
                            Instantiate(imgprefab, Hotbarslots[1].position, Quaternion.identity, Hotbarslots[1]);
                        }
                        else
                        {
                            if (itemin3 == false)
                            {
                                iteminslot3 = "wood";
                                exwood = true;
                                itemin3 = true;
                                Instantiate(imgprefab, Hotbarslots[2].position, Quaternion.identity, Hotbarslots[2]);
                            }
                            else
                            {
                                if (itemin4 == false)
                                {
                                    iteminslot4 = "wood";
                                    exwood = true;
                                    itemin4 = true;
                                    Instantiate(imgprefab, Hotbarslots[3].position, Quaternion.identity, Hotbarslots[3]);
                                }
                                else
                                {
                                    if (itemin5 == false)
                                    {
                                        iteminslot5 = "wood";
                                        exwood = true;
                                        itemin5 = true;
                                        Instantiate(imgprefab, Hotbarslots[4].position, Quaternion.identity, Hotbarslots[4]);
                                    }
                                    else
                                    {
                                        if (itemin6 == false)
                                        {
                                            iteminslot6 = "wood";
                                            exwood = true;
                                            itemin6 = true;
                                            Instantiate(imgprefab, Hotbarslots[5].position, Quaternion.identity, Hotbarslots[5]);
                                        }
                                        else
                                        {
                                            if (itemin7 == false)
                                            {
                                                iteminslot7 = "wood";
                                                exwood = true;
                                                itemin7 = true;
                                                Instantiate(imgprefab, Hotbarslots[6].position, Quaternion.identity, Hotbarslots[6]);
                                            }
                                            else
                                            {
                                                if (itemin8 == false)
                                                {
                                                    iteminslot8 = "wood";
                                                    exwood = true;
                                                    itemin8 = true;
                                                    Instantiate(imgprefab, Hotbarslots[7].position, Quaternion.identity, Hotbarslots[7]);
                                                }
                                                else
                                                {
                                                    if (itemin9 == false)
                                                    {
                                                        iteminslot9 = "wood";
                                                        exwood = true;
                                                        itemin9 = true;
                                                        Instantiate(imgprefab, Hotbarslots[8].position, Quaternion.identity, Hotbarslots[8]);
                                                    }
                                                    else
                                                    {
                                                        if (itemin10 == false)
                                                        {
                                                            iteminslot10 = "wood";
                                                            exwood = true;
                                                            itemin10 = true;
                                                            Instantiate(imgprefab, Hotbarslots[9].position, Quaternion.identity, Hotbarslots[9]);
                                                        }                                                       
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }











            //stone
            if (itemin1 == true && iteminslot1 == ("stone"))
            {
                if (totalstone > 0)
                {
                    Hotbarslots[0].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalstone.ToString();
                }
                if(totalstone == 0)
                {
                    Destroy(Hotbarslots[0].GetChild(0));
                }
            }
            if (itemin2 == true && iteminslot2 == ("stone"))
            {
                if (totalstone > 0)
                {
                    Hotbarslots[1].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalstone.ToString();
                    if (totalstone == 0)
                    {
                        Destroy(Hotbarslots[1].GetChild(0));
                    }
                }
            }
            if (itemin3 == true && iteminslot3 == ("stone"))
            {
                if (totalstone > 0)
                {
                    Hotbarslots[2].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalstone.ToString();
                    if (totalstone == 0)
                    {
                        Destroy(Hotbarslots[2].GetChild(0));
                    }
                }
            }
            if (itemin4 == true && iteminslot4 == ("stone"))
            {
                if (totalstone > 0)
                {
                    Hotbarslots[3].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalstone.ToString();
                    if (totalstone == 0)
                    {
                        Destroy(Hotbarslots[3].GetChild(0));
                    }
                }
            }
            if (itemin5 == true && iteminslot5 == ("stone"))
            {
                if (totalstone > 0)
                {
                    Hotbarslots[4].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalstone.ToString();
                    if (totalstone == 0)
                    {
                        Destroy(Hotbarslots[4].GetChild(0));
                    }
                }
            }
            if (itemin6 == true && iteminslot6 == ("stone"))
            {
                if (totalstone > 0)
                {
                    Hotbarslots[5].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalstone.ToString();
                    if (totalstone == 0)
                    {
                        Destroy(Hotbarslots[5].GetChild(0));
                    }
                }
            }
            if (itemin7 == true && iteminslot7 == ("stone"))
            {
                if (totalstone > 0)
                {
                    Hotbarslots[6].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalstone.ToString();
                    if (totalstone == 0)
                    {
                        Destroy(Hotbarslots[6].GetChild(0));
                    }
                }
            }
            if (itemin8 == true && iteminslot8 == ("stone"))
            {
                if (totalstone > 0)
                {
                    Hotbarslots[7].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalstone.ToString();
                    if (totalstone == 0)
                    {
                        Destroy(Hotbarslots[7].GetChild(0));
                    }
                }
            }
            if (itemin9 == true && iteminslot9 == ("stone"))
            {
                if (totalstone > 0)
                {
                    Hotbarslots[8].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalstone.ToString();
                    if (totalstone == 0)
                    {
                        Destroy(Hotbarslots[8].GetChild(0));
                    }
                }
            }
            if (itemin10 == true && iteminslot10 == ("stone"))
            {
                if (totalstone > 0)
                {
                    Hotbarslots[9].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totalstone.ToString();
                    if (totalstone == 0)
                    {
                        Destroy(Hotbarslots[9].GetChild(0));
                    }
                }
            }
            totalstone = Rock.stone;
            if (exstone == false)
            {
                if (totalstone > 0)
                {
                    if (itemin1 == false)
                    {
                        iteminslot1 = "stone";
                        exstone = true;
                        itemin1 = true;
                        Instantiate(imgprefab, Hotbarslots[0].position, Quaternion.identity, Hotbarslots[0]);
                        Hotbarslots[0].GetChild(0).GetComponent<Image>().sprite = stoneimg;
                    }
                    else
                    {
                        if (itemin2 == false)
                        {
                            iteminslot2 = "stone";
                            exstone = true;
                            itemin2 = true;
                            Instantiate(imgprefab, Hotbarslots[1].position, Quaternion.identity, Hotbarslots[1]);
                            Hotbarslots[1].GetChild(0).GetComponent<Image>().sprite = stoneimg;
                        }
                        else
                        {
                            if (itemin3 == false)
                            {
                                iteminslot3 = "stone";
                                exstone = true;
                                itemin3 = true;
                                Instantiate(imgprefab, Hotbarslots[2].position, Quaternion.identity, Hotbarslots[2]);
                                Hotbarslots[2].GetChild(0).GetComponent<Image>().sprite = stoneimg;
                            }
                            else
                            {
                                if (itemin4 == false)
                                {
                                    iteminslot4 = "stone";
                                    exstone = true;
                                    itemin4 = true;
                                    Instantiate(imgprefab, Hotbarslots[3].position, Quaternion.identity, Hotbarslots[3]);
                                    Hotbarslots[3].GetChild(0).GetComponent<Image>().sprite = stoneimg;
                                }
                                else
                                {
                                    if (itemin5 == false)
                                    {
                                        iteminslot5 = "stone";
                                        exstone = true;
                                        itemin5 = true;
                                        Instantiate(imgprefab, Hotbarslots[4].position, Quaternion.identity, Hotbarslots[4]);
                                        Hotbarslots[4].GetChild(0).GetComponent<Image>().sprite = stoneimg;
                                    }
                                    else
                                    {
                                        if (itemin6 == false)
                                        {
                                            iteminslot6 = "stone";
                                            exstone = true;
                                            itemin6 = true;
                                            Instantiate(imgprefab, Hotbarslots[5].position, Quaternion.identity, Hotbarslots[5]);
                                            Hotbarslots[5].GetChild(0).GetComponent<Image>().sprite = stoneimg;
                                        }
                                        else
                                        {
                                            if (itemin7 == false)
                                            {
                                                iteminslot7 = "stone";
                                                exstone = true;
                                                itemin7 = true;
                                                Instantiate(imgprefab, Hotbarslots[1].position, Quaternion.identity, Hotbarslots[6]);
                                                Hotbarslots[6].GetChild(0).GetComponent<Image>().sprite = stoneimg;
                                            }
                                            else
                                            {
                                                if (itemin8 == false)
                                                {
                                                    iteminslot8 = "stone";
                                                    exstone = true;
                                                    itemin7 = true;
                                                    Instantiate(imgprefab, Hotbarslots[7].position, Quaternion.identity, Hotbarslots[8]);
                                                    Hotbarslots[7].GetChild(0).GetComponent<Image>().sprite = stoneimg;
                                                }
                                                else
                                                {
                                                    if (itemin9 == false)
                                                    {
                                                        iteminslot9 = "stone";
                                                        exstone = true;
                                                        itemin2 = true;
                                                        Instantiate(imgprefab, Hotbarslots[8].position, Quaternion.identity, Hotbarslots[8]);
                                                        Hotbarslots[8].GetChild(0).GetComponent<Image>().sprite = stoneimg;
                                                    }
                                                    else
                                                    {
                                                        if (itemin10 == false)
                                                        {
                                                            iteminslot10 = "stone";
                                                            exstone = true;
                                                            itemin10 = true;
                                                            Instantiate(imgprefab, Hotbarslots[9].position, Quaternion.identity, Hotbarslots[9]);
                                                            Hotbarslots[9].GetChild(0).GetComponent<Image>().sprite = stoneimg;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //tree plant
            if (equipedslot == 2 && itemin2 == true && iteminslot2 == "treeplant")
            {
                if(totaltreeplant > 0 && Input.GetMouseButtonDown(1))
                {
                    treescript.Planttree();
                }
                if (totaltreeplant == 0)
                {
                    itemin2 = false;
                    iteminslot2 = "";
                    explant = false;
                    Destroy(Hotbarslots[1].GetChild(0).gameObject);
                }
            }
            if (equipedslot == 1 && itemin1 == true && iteminslot1 == "treeplant")
            {
                if (totaltreeplant > 0 && Input.GetMouseButtonDown(1))
                {
                    treescript.Planttree();
                }
                if (totaltreeplant == 0)
                {
                    itemin1 = false;
                    iteminslot1 = "";
                    explant = false;
                    Destroy(Hotbarslots[0].GetChild(0).gameObject);
                }

            }
            if (equipedslot == 3 && itemin3 == true && iteminslot3 == "treeplant")
            {
                if (totaltreeplant > 0 && Input.GetMouseButtonDown(1))
                {
                    treescript.Planttree();
                }
                if (totaltreeplant == 0)
                {
                    itemin3 = false;
                    iteminslot3 = "";
                    explant = false;
                    Destroy(Hotbarslots[2].GetChild(0).gameObject);
                }
            }
            if (equipedslot == 4 && itemin4 == true && iteminslot4 == "treeplant")
            {
                if (totaltreeplant > 0 && Input.GetMouseButtonDown(1))
                {
                    treescript.Planttree();
                }
                if (totaltreeplant == 0)
                {
                    itemin4 = false;
                    iteminslot4 = "";
                    explant = false;
                    Destroy(Hotbarslots[3].GetChild(0).gameObject);
                }
            }
            if (equipedslot == 5 && itemin5 == true && iteminslot5 == "treeplant")
            {
                if (totaltreeplant > 0 && Input.GetMouseButtonDown(1))
                {
                    treescript.Planttree();
                }
                if (totaltreeplant == 0)
                {
                    itemin5 = false;
                    iteminslot5 = "";
                    explant = false;
                    Destroy(Hotbarslots[4].GetChild(0).gameObject);
                }
            }
            if (equipedslot == 6 && itemin6 == true && iteminslot6 == "treeplant")
            {
                if (totaltreeplant > 0 && Input.GetMouseButtonDown(1))
                {
                    treescript.Planttree();
                }
                if (totaltreeplant == 0)
                {
                    itemin6 = false;
                    iteminslot6 = "";
                    explant = false;
                    Destroy(Hotbarslots[5].GetChild(0).gameObject);
                }
            }
            if (equipedslot == 7 && itemin7 == true && iteminslot7 == "treeplant")
            {
                if (totaltreeplant > 0 && Input.GetMouseButtonDown(1))
                {
                    treescript.Planttree();
                }
                if (totaltreeplant == 0)
                {
                    itemin7 = false;
                    iteminslot7 = "";
                    explant = false;
                    Destroy(Hotbarslots[6].GetChild(0).gameObject);
                }
            }
            if (equipedslot == 8 && itemin8 == true && iteminslot8 == "treeplant")
            {
                if (totaltreeplant > 0 && Input.GetMouseButtonDown(1))
                {
                    treescript.Planttree();
                }
                if (totaltreeplant == 0)
                {
                    itemin8 = false;
                    iteminslot8 = "";
                    explant = false;
                    Destroy(Hotbarslots[7].GetChild(0).gameObject);
                }
            }
            if (equipedslot == 9 && itemin9 == true && iteminslot9 == "treeplant")
            {
                if (totaltreeplant > 0 && Input.GetMouseButtonDown(1))
                {
                    treescript.Planttree();
                }
                if (totaltreeplant == 0)
                {
                    itemin9 = false;
                    iteminslot9 = "";
                    explant = false;
                    Destroy(Hotbarslots[8].GetChild(0).gameObject);
                }
            }
            if (equipedslot == 10 && itemin10 == true && iteminslot10 == "treeplant")
            {
                if (totaltreeplant > 0 && Input.GetMouseButtonDown(1))
                {
                    treescript.Planttree();
                }
                if (totaltreeplant == 0)
                {
                    itemin10 = false;
                    iteminslot10 = "";
                    explant = false;
                    Destroy(Hotbarslots[9].GetChild(0).gameObject);
                }
            }


            if (itemin1 == true && iteminslot1 == ("treeplant"))
            {
                if (totaltreeplant >= 0)
                {
                    Hotbarslots[0].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totaltreeplant.ToString();                   
                }
            }
            if (itemin2 == true && iteminslot2 == ("treeplant"))
            {
                if (totaltreeplant >= 0)
                {
                    Hotbarslots[1].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totaltreeplant.ToString();
                }
            }
            if (itemin3 == true && iteminslot3 == ("treeplant"))
            {
                if (totaltreeplant >= 0)
                {
                    Hotbarslots[2].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totaltreeplant.ToString();
                    
                }
            }
            if (itemin4 == true && iteminslot4 == ("treeplant"))
            {
                if (totaltreeplant >= 0)
                {
                    Hotbarslots[3].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totaltreeplant.ToString();
                    
                }
            }
            if (itemin5 == true && iteminslot5 == ("treeplant"))
            {
                if (totaltreeplant >= 0)
                {
                    Hotbarslots[4].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totaltreeplant.ToString();
                    
                }
            }
            if (itemin6 == true && iteminslot6 == ("treeplant"))
            {
                if (totaltreeplant >= 0)
                {
                    Hotbarslots[5].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totaltreeplant.ToString();
                    
                }
            }
            if (itemin7 == true && iteminslot7 == ("treeplant"))
            {
                if (totaltreeplant >= 0)
                {
                    Hotbarslots[6].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totaltreeplant.ToString();
                    
                }
            }
            if (itemin8 == true && iteminslot8 == ("treeplant"))
            {
                if (totaltreeplant >= 0)
                {
                    Hotbarslots[7].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totaltreeplant.ToString();                  
                }
            }
            if (itemin9 == true && iteminslot9 == ("treeplant"))
            {
                if (totaltreeplant >= 0)
                {
                    Hotbarslots[8].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totaltreeplant.ToString();                  
                }
            }
            if (itemin10 == true && iteminslot10 == ("treeplant"))
            {
                if (totaltreeplant >= 0)
                {
                    Hotbarslots[9].GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = totaltreeplant.ToString();                 
                }
            }
            totaltreeplant = Tree.treeplants;
            if (explant == false)
            {
                if (totaltreeplant > 0)
                {                    
                    if (itemin1 == false)
                    {
                        iteminslot1 = "treeplant";
                        explant = true;
                        itemin1 = true;
                        Instantiate(imgprefab, Hotbarslots[0].position, Quaternion.identity, Hotbarslots[0]);
                        Hotbarslots[0].GetChild(0).GetComponent<Image>().sprite = plantsprite;
                    }
                    else
                    {
                        if (itemin2 == false)
                        {
                            iteminslot2 = "treeplant";
                            explant = true;
                            itemin2 = true;
                            Instantiate(imgprefab, Hotbarslots[1].position, Quaternion.identity, Hotbarslots[1]);
                            Hotbarslots[1].GetChild(0).GetComponent<Image>().sprite = plantsprite;
                        }
                        else
                        {
                            if (itemin3 == false)
                            {
                                iteminslot3 = "treeplant";
                                explant = true;
                                itemin3 = true;
                                Instantiate(imgprefab, Hotbarslots[2].position, Quaternion.identity, Hotbarslots[2]);
                                Hotbarslots[2].GetChild(0).GetComponent<Image>().sprite = plantsprite;
                            }
                            else
                            {
                                if (itemin4 == false)
                                {
                                    iteminslot4 = "treeplant";
                                    explant = true;
                                    itemin4 = true;
                                    Instantiate(imgprefab, Hotbarslots[3].position, Quaternion.identity, Hotbarslots[3]);
                                    Hotbarslots[3].GetChild(0).GetComponent<Image>().sprite = plantsprite;
                                }
                                else
                                {
                                    if (itemin5 == false)
                                    {
                                        iteminslot5 = "treeplant";
                                        explant = true;
                                        itemin5 = true;
                                        Instantiate(imgprefab, Hotbarslots[4].position, Quaternion.identity, Hotbarslots[4]);
                                        Hotbarslots[4].GetChild(0).GetComponent<Image>().sprite = plantsprite;
                                    }
                                    else
                                    {
                                        if (itemin6 == false)
                                        {
                                            iteminslot6 = "treeplant";
                                            explant = true;
                                            itemin6 = true;
                                            Instantiate(imgprefab, Hotbarslots[5].position, Quaternion.identity, Hotbarslots[5]);
                                            Hotbarslots[5].GetChild(0).GetComponent<Image>().sprite = plantsprite;
                                        }
                                        else
                                        {
                                            if (itemin7 == false)
                                            {
                                                iteminslot7 = "treeplant";
                                                explant = true;
                                                itemin7 = true;
                                                Instantiate(imgprefab, Hotbarslots[1].position, Quaternion.identity, Hotbarslots[6]);
                                                Hotbarslots[6].GetChild(0).GetComponent<Image>().sprite = plantsprite;
                                            }
                                            else
                                            {
                                                if (itemin8 == false)
                                                {
                                                    iteminslot8 = "treeplant";
                                                    explant = true;
                                                    itemin7 = true;
                                                    Instantiate(imgprefab, Hotbarslots[7].position, Quaternion.identity, Hotbarslots[8]);
                                                    Hotbarslots[7].GetChild(0).GetComponent<Image>().sprite = plantsprite;
                                                }
                                                else
                                                {
                                                    if (itemin9 == false)
                                                    {
                                                        iteminslot9 = "treeplant";
                                                        explant = true;
                                                        itemin2 = true;
                                                        Instantiate(imgprefab, Hotbarslots[8].position, Quaternion.identity, Hotbarslots[8]);
                                                        Hotbarslots[8].GetChild(0).GetComponent<Image>().sprite = plantsprite;
                                                    }
                                                    else
                                                    {
                                                        if (itemin10 == false)
                                                        {
                                                            iteminslot10 = "treeplant";
                                                            explant = true;
                                                            itemin10 = true;
                                                            Instantiate(imgprefab, Hotbarslots[9].position, Quaternion.identity, Hotbarslots[9]);
                                                            Hotbarslots[9].GetChild(0).GetComponent<Image>().sprite = plantsprite;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

        

}
