using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SHOP2 : MonoBehaviour
{


	public float TotalMula; 
	public float MPS;



	int BlåFiskIncome = 0; 
	int GrønFiskIncome = 0; 
	int SortFiskIncome = 0; 
	int GuldfiskIncome = 0;

	bool BlåFiskAna;
	bool GrønFiskAna; 
	bool SortFiskAna; 
	bool GuldfiskAna; 
	bool Græs1Ana; 
	bool Græs2Ana; 
	bool StenAna; 
	bool FlagAna; 

	public GameObject MainScreen; 
	public GameObject BlåFisk;
	public GameObject GrønFisk; 
	public GameObject SortFisk; 
	public GameObject Guldfisk; 
	public GameObject Græs1;
	public GameObject Græs2;
	public GameObject Sten; 
	public GameObject Flag;

    int IsGoldFishSold;
    int MoneyAmount;
	int IsGreenFishSold; 
	int IsBlackFishSold;
	int IsBlueFishSold; 
	int IsGræsSold; 
	int IsGræs2Sold; 
	int IsStenSold;
	int IsFlagSold; 

    public Button BuyGoldFishButton;
	public Button BuyGreenFishButton;
	public Button BuyBlackFishButton; 
	public Button BuyBlueFishButton; 
	public Button BuyGræsButton;
	public Button BuyGræs2Button;
	public Button BuyStenButton;
	public Button BuyFlagButton; 


    public Text MoneyAmountText;
    public Text GoldFishPrice;
	public Text GreenFishPrice; 
	public Text BlackFishPrice; 
	public Text BlueFishPrice; 
	float TotalTime = 1f; 
	float TotalTime2 = 1f; 
	float TotalTime3 = 1f;
	float TotalTime4 = 1f; 

    void Start()
    {
		//IsGreenFishSold = 1; 
        MoneyAmount = PlayerPrefs.GetInt("MoneyAmount");
		 print(Screen.currentResolution);
		MoneyAmount = 2500; 
	}

	

    void Update()
	{ 
		
		if ( GrønFiskIncome >= 1) 
		{
			TotalTime -= Time.deltaTime; 
			if (TotalTime <= 0)
			{
				TotalTime = 1; 
				MoneyAmount += 1; 
				Debug.Log("Income Activated");
			} 
		}
		
		
		if ( SortFiskIncome >= 1) 
		{
			TotalTime2 -= Time.deltaTime; 
			if (TotalTime2 <= 0)
			{
				TotalTime2 = 1; 
				MoneyAmount += 5; 
				Debug.Log("Income 2 Activated");
			} 
		}

		if ( GuldfiskIncome >= 1) 
		{
			TotalTime3 -= Time.deltaTime; 
			if (TotalTime3 <= 0)
			{
				TotalTime3 = 1; 
				MoneyAmount += 7; 
				Debug.Log("Income  3 Activated");
			} 
		}

		if ( BlåFiskIncome >= 1) 
		{
			TotalTime4 -= Time.deltaTime; 
			if (TotalTime4 <= 0)
			{
				TotalTime4 = 1; 
				MoneyAmount += 20; 
				Debug.Log("Income  4 Activated");
			} 
		}




		
			if (GrønFiskAna == true)
			{
				GameObject GrønFiskSpawn = Instantiate(GrønFisk, MainScreen.transform);
				//Instantiate (GrønFisk, new Vector3(0,0,-14.04f), Quaternion.identity) as GameObject;
				GrønFiskSpawn.transform.position = new Vector3(-6,2.7f,-14.04f);
				GrønFiskAna = false; 
				GrønFiskIncome = 1; 
				Debug.Log("Income is active"); 
			}

		
			if (SortFiskAna == true)
			{
			GameObject SortFiskSpawn = Instantiate(SortFisk,MainScreen.transform);
			SortFiskSpawn.transform.position = new Vector3(-3,1,-14.04f); 
			SortFiskAna = false; 
			SortFiskIncome = 1; 
			Debug.Log("BLack Income = true");
			}

					if(GuldfiskAna == true)
					{
					GameObject GuldfiskSpawn = Instantiate(Guldfisk,MainScreen.transform);
					GuldfiskSpawn.transform.position = new Vector3(1,2,-14.04f);
					GuldfiskAna = false; 
					GuldfiskIncome = 1; 
					Debug.Log("Guldfisk Income = true");
					}

		if(BlåFiskAna == true)
		{
		GameObject BlåFiskSpawn = Instantiate(BlåFisk,MainScreen.transform);
		BlåFiskSpawn.transform.position = new Vector3(4,-3,-14.04f); 
		BlåFiskAna = false; 
		GuldfiskIncome = 1;
		Debug.Log("BlåFisk Income = true");

		}




		if(Græs1Ana == true)
		{
		GameObject Græs1Spawn = Instantiate(Græs1,MainScreen.transform);
		Græs1Spawn.transform.position = new Vector3(3,-3,-14.04f); 
		Græs1Ana = false; 
		
		
		}
		if(Græs2Ana == true)
		{
		GameObject Græs2Spawn = Instantiate(Græs2,MainScreen.transform);
		Græs2Spawn.transform.position = new Vector3(3,-3,-14.04f); 
		Græs2Ana = false; 
		}

		if(StenAna == true)
		{
		GameObject StenSpawn = Instantiate(Sten,MainScreen.transform);
		StenSpawn.transform.position = new Vector3(3,-3,-14.04f); 
		StenAna = false; 
		}
		if(Græs1Ana == true)
		{
		GameObject FlagSpawn = Instantiate(Flag,MainScreen.transform);
		FlagSpawn.transform.position = new Vector3(3,-3,-14.04f); 
		FlagAna = false; 		
		}



		

		//Guldfisk Shop her 350 kroner
        MoneyAmountText.text = ("Money : " + MoneyAmount.ToString() + "$");
        if (MoneyAmount >= 450 && IsGoldFishSold == 0)
        {
            BuyGoldFishButton.interactable = true;
        }
        else
        {
            
			 BuyGoldFishButton.interactable = false;
        }




		//Grøn fisk her
		 MoneyAmountText.text = ( MoneyAmount.ToString());
      
	  
	  if (MoneyAmount >= 5 && IsGreenFishSold == 0)
        {
            BuyGreenFishButton.interactable = true;
        }
        else
        {
            
			 BuyGreenFishButton.interactable = false;
        }

	 
       
	   //Sort fisk her
	   if (MoneyAmount >= 40 && IsBlackFishSold == 0)
        {
            BuyBlackFishButton.interactable = true;
        }
        else
        {
            
			 BuyBlackFishButton.interactable = false;
        }

		//Blå Fisk her
		 
        if (MoneyAmount >= 999 && IsBlueFishSold == 0)
        {
            BuyBlueFishButton.interactable = true;
        }
        else
        {
            
			 BuyBlueFishButton.interactable = false;
        }

		
		if (IsGreenFishSold == 1)
		{
		BuyGreenFishButton.interactable = false; 

		}
		
	
	



	 //Græs1 fisk her
	   if (MoneyAmount >= 200 && IsGræsSold == 0)
        {
            BuyGræsButton.interactable = true;
        }
        else
        {
            
			 BuyGræsButton.interactable = false;
        }

		 //Græs2 her
	   if (MoneyAmount >= 250 && IsGræs2Sold == 0)
        {
            BuyGræs2Button.interactable = true;
        }
        else
        {
            
			 BuyGræs2Button.interactable = false;
        }
		 //Sten her
	   if (MoneyAmount >= 666 && IsStenSold == 0)
        {
            BuyStenButton.interactable = true;
        }
        else
        {
            
			 BuyStenButton.interactable = false;
        }
		 //Flag her
	   if (MoneyAmount >= 999 && IsFlagSold == 0)
        {
            BuyFlagButton.interactable = true;
        }
        else
        {
            
			 BuyFlagButton.interactable = false;
        }







	}

	 public void BuyGræsButtonOnClick()
    {

        
		Græs1Ana = true; 
		Debug.Log("GRæs1");
		 MoneyAmount -= 200;
		 IsGræsSold = 1; 
		 Græs1Ana = true; 
	}

	 public void BuyGræs2ButtonOnClick()
    {

        Græs2Ana = true;  
		Debug.Log("Græs2");
		
		MoneyAmount -= 250;
		IsGræs2Sold = 1;  
		Græs2Ana = true; 
	}

	 public void BuyStenButtonOnClick()
    {

        StenAna = true; 
		Debug.Log("Sten");
		MoneyAmount -= 666; 
		IsStenSold = 1;
		StenAna = true; 

	}

	 public void BuyFlagButtonOnClick()
    {

        FlagAna = true; 
		Debug.Log("Flag");
		MoneyAmount -= 999;
		IsFlagSold = 1; 
		FlagAna = true; 
	}


    //salg af den grønne fisk 
     public void BuyGreenFishButtonOnClick()
    {

        MoneyAmount -= 5;
        PlayerPrefs.SetInt("IsGreenFishSold", 1);
		IsGreenFishSold = 1; 
        GreenFishPrice.text = "Sold";
		GrønFiskAna = true; 
		GrønFiskIncome = 1; 
	}
		
	//den sorte fisk
	public void BuyBlackFishButtonOnClick()
    {

        MoneyAmount -= 40;
        PlayerPrefs.SetInt("IsBlackFishSold", 1);
        BlackFishPrice.text = "Sold";
		IsBlackFishSold  = 1; 
		SortFiskAna = true; 
		SortFiskIncome = 1; 
	}
	//Den blåe fisk
	 public void BuyBlueFishButtonOnClick()
    {

        MoneyAmount -= 999;
        PlayerPrefs.SetInt("IsBlueFishSold", 1);
        BlueFishPrice.text = "Sold";
		IsBlueFishSold = 1; 
		BlåFiskAna = true; 
		BlåFiskIncome = 1; 
	}


	//salg af Guldfisk
	 public void BuyGoldFishButtonOnClick()
    {

        MoneyAmount -= 350;
        PlayerPrefs.SetInt("IsGoldFishSold", 1);
        GoldFishPrice.text = "Sold";
		IsGoldFishSold = 1; 
		GuldfiskAna = true; 
		GuldfiskIncome = 1; 

		}
}
