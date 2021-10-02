using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   public static GameManager Instance;
   public GameObject shoppanel;
   public GameObject mainapriansbutton;
   public GameObject mainweaponbutton;
   public GameObject weapguns;
   public GameObject weapmelle;
   public GameObject weapsniper;
   public GameObject weapgrande;
   public GameObject aprinscap;
   public GameObject aprinsgoogles;
   public GameObject aprinscloths;
   public GameObject aprinsshoes;
   public GameObject apriansallbutton;
   public GameObject Weapanallbutton;
   public GameObject aprinsmainpanel;
   public GameObject weapnmainpanel;
   public GameObject weapgunspanels;
   public GameObject weapmellepanels;
   public GameObject weapsniperpanels;
   public GameObject weapgrandepanels;
   public GameObject aprinscappanels;
   public GameObject aprinsgooglespanels;
   public GameObject aprinsclothspanels;
   public GameObject aprinsshoespanels;
   public GameObject shopbutton;
   public GameObject chestPopup;
   public TextMeshProUGUI[] Quantity;
   public GameObject inventory;
   public GameObject inventoryButton;
   public GameObject cap;
   public GameObject goglesh;
   public GameObject shoesh;
   public GameObject clopths;
   public Color[] color;
   public GameObject Sellpanel;
   public GameObject BuyPanel;
   private void Awake()
   {
      if (Instance == null)
      {
         Instance = this;
      }
      else
      {
         Destroy(this);
      }
   }

   public void Start()
   {
      for (int i = 0; i < color.Length; i++)
      {
         if (PlayerPrefs.GetInt("Cap"+i,0)==i)
         {
            cap.gameObject.GetComponent<Image>().color = color[i]; 
         }
            
      }
      for (int i = 0; i < color.Length; i++)
      {
         if (PlayerPrefs.GetInt("Goglesh"+i,0)==i)
         {
            goglesh.gameObject.GetComponent<Image>().color = color[i]; 
         }
            
      }
      for (int i = 0; i < color.Length; i++)
      {
         if (PlayerPrefs.GetInt("Shoesh"+i,0)==i)
         {
            shoesh.gameObject.GetComponent<Image>().color = color[i]; 
         }
            
      }
      for (int i = 0; i < color.Length; i++)
      {
         if (PlayerPrefs.GetInt("Clothsh"+i,0)==i)
         {
            clopths.gameObject.GetComponent<Image>().color = color[i]; 
         }
            
      }
   }

   public void ShopOpen()
   {
      shoppanel.SetActive(true);
      shopbutton.SetActive(false);
      inventoryButton.SetActive(false);
      chestPopup.SetActive(false);
      
   }
   
   public void ShopClose()
   {
      shoppanel.SetActive(false);
      shopbutton.SetActive(true);
      inventoryButton.SetActive(true);
   }

   public void AppriancePanel()
   {
      mainapriansbutton.GetComponent<Image>().color=Color.green;
      mainweaponbutton.GetComponent<Image>().color=Color.white;
      aprinsmainpanel.gameObject.SetActive(true);
      weapnmainpanel.gameObject.SetActive(false);
      apriansallbutton.gameObject.SetActive(true);
      Weapanallbutton.gameObject.SetActive(false);
   }

   public void WeapnaPanel()
   {
      mainapriansbutton.GetComponent<Image>().color=Color.white;
      mainweaponbutton.GetComponent<Image>().color=Color.green;
      aprinsmainpanel.gameObject.SetActive(false);
      weapnmainpanel.gameObject.SetActive(true);
      apriansallbutton.gameObject.SetActive(false);
      Weapanallbutton.gameObject.SetActive(true);
   }

   public void CapPanel()
   {
      aprinscap.GetComponent<Image>().color = Color.green;
      aprinscloths.GetComponent<Image>().color=Color.white;
      aprinsgoogles.GetComponent<Image>().color=Color.white;
      aprinsshoes.GetComponent<Image>().color=Color.white;
      aprinscappanels.gameObject.SetActive(true);
      aprinsclothspanels.gameObject.SetActive(false);
      aprinsgooglespanels.gameObject.SetActive(false);
      aprinsshoespanels.gameObject.SetActive(false);
      
   }
   public void GoolesPanel()
   {
      aprinscap.GetComponent<Image>().color = Color.white;
      aprinscloths.GetComponent<Image>().color=Color.white;
      aprinsgoogles.GetComponent<Image>().color=Color.green;
      aprinsshoes.GetComponent<Image>().color=Color.white;
      aprinscappanels.gameObject.SetActive(false);
      aprinsclothspanels.gameObject.SetActive(false);
      aprinsgooglespanels.gameObject.SetActive(true);
      aprinsshoespanels.gameObject.SetActive(false);
      
   }
   
   public void ClothsPanel()
   {
      aprinscap.GetComponent<Image>().color = Color.white;
      aprinscloths.GetComponent<Image>().color=Color.green;
      aprinsgoogles.GetComponent<Image>().color=Color.white;
      aprinsshoes.GetComponent<Image>().color=Color.white;
      aprinscappanels.gameObject.SetActive(false);
      aprinsclothspanels.gameObject.SetActive(true);
      aprinsgooglespanels.gameObject.SetActive(false);
      aprinsshoespanels.gameObject.SetActive(false);
      
   }
   
   public void ShoesPanel()
   {
      aprinscap.GetComponent<Image>().color = Color.white;
      aprinscloths.GetComponent<Image>().color=Color.white;
      aprinsgoogles.GetComponent<Image>().color=Color.white;
      aprinsshoes.GetComponent<Image>().color=Color.green;
      aprinscappanels.gameObject.SetActive(false);
      aprinsclothspanels.gameObject.SetActive(false);
      aprinsgooglespanels.gameObject.SetActive(false);
      aprinsshoespanels.gameObject.SetActive(true);
      
   }
   
   public void GunPanel()
   {
      weapguns.GetComponent<Image>().color = Color.green;
      weapgrande.GetComponent<Image>().color=Color.white;
      weapmelle.GetComponent<Image>().color=Color.white;
      weapsniper.GetComponent<Image>().color=Color.white;
      weapgrandepanels.gameObject.SetActive(false);
      weapgunspanels.gameObject.SetActive(true);
      weapmellepanels.gameObject.SetActive(false);
      weapsniperpanels.gameObject.SetActive(false);
      
   }
   
   public void GrandePanel()
   {
      weapguns.GetComponent<Image>().color = Color.white;
      weapgrande.GetComponent<Image>().color=Color.green;
      weapmelle.GetComponent<Image>().color=Color.white;
      weapsniper.GetComponent<Image>().color=Color.white;
      weapgrandepanels.gameObject.SetActive(true);
      weapgunspanels.gameObject.SetActive(false);
      weapmellepanels.gameObject.SetActive(false);
      weapsniperpanels.gameObject.SetActive(false);
      
   }
   public void MellesPanel()
   {
      weapguns.GetComponent<Image>().color = Color.white;
      weapgrande.GetComponent<Image>().color=Color.white;
      weapmelle.GetComponent<Image>().color=Color.green;
      weapsniper.GetComponent<Image>().color=Color.white;
      weapgrandepanels.gameObject.SetActive(false);
      weapgunspanels.gameObject.SetActive(false);
      weapmellepanels.gameObject.SetActive(true);
      weapsniperpanels.gameObject.SetActive(false);
      
   }
   
   public void SniparPanel()
   {
      weapguns.GetComponent<Image>().color = Color.white;
      weapgrande.GetComponent<Image>().color=Color.white;
      weapmelle.GetComponent<Image>().color=Color.white;
      weapsniper.GetComponent<Image>().color=Color.green;
      weapgrandepanels.gameObject.SetActive(false);
      weapgunspanels.gameObject.SetActive(false);
      weapmellepanels.gameObject.SetActive(false);
      weapsniperpanels.gameObject.SetActive(true);
      
   }

   public void BuyPanelClose()
   {
      BuyPanel.gameObject.SetActive(false);
      PlayerPrefs.DeleteKey("Plush");
   }

   public void SellpanelClose()
   {
      Sellpanel.gameObject.SetActive(false);
      PlayerPrefs.DeleteKey("Plush");
   }
   public void CloseChestPopup()
   {
      chestPopup.SetActive(false);
      
   }


   public void OpenInventory()
   {
      for (int i = 0; i < Quantity.Length; i++)
      {
         Quantity[i].text = PlayerPrefs.GetInt("item" + i).ToString();
         
      }
      inventory.gameObject.SetActive(true);
   }

   public void CloseInventory()
   {
      inventory.gameObject.SetActive(false);
   }

}
