using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.UI;

public class RecipeUI : MonoBehaviour
{
    public GameObject RecipePanel;
    bool activeRecipe = false;
    public Button closeRecipe;

    private void Start()
    {
        RecipePanel.SetActive(activeRecipe);
        closeRecipe.onClick.AddListener(RecipeBookClose);
    }

    public void ActiveRecipeBook(bool isOpen)
    {
        activeRecipe = isOpen;
        RecipePanel.SetActive(activeRecipe);
    }
    public void RecipeBookOpen()
    {
        ActiveRecipeBook(true);
    }

    public void RecipeBookClose()
    {
        ActiveRecipeBook(false);
    }



}
