using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Imterface : MonoBehaviour
{
    private Button btnCena1, btnCena2, btnSair, btnVoltar;

    // Start is called before the first frame update
    void Start()
    {
        UIDocument doc = GetComponent<UIDocument>();
        VisualElement root = doc.rootVisualElement;
        btnCena1 = root.Q<Button>("btnCena1");
        btnCena2 = root.Q<Button>("btnCena2");
        btnSair = root.Q<Button>("btnSair");
        btnVoltar = root.Q<Button>("btnVoltar");

        btnCena1.clicked += BtnCena1_clicked;
        btnCena2.clicked += BtnCena2_clicked;
        btnSair.clicked += BtnSair_clicked;
        btnVoltar.clicked += BtnVoltar_clicked;
    }

    private void BtnSair_clicked()
    {
        Application.Quit();
    }

    private void BtnVoltar_clicked()
    {
        SceneManager.UnloadSceneAsync("Intro");
        SceneManager.LoadScene("Intro");
        SceneManager.UnloadSceneAsync("Cena1");
        SceneManager.UnloadSceneAsync("Cena2");
    }

    private void BtnCena2_clicked()
    {
        SceneManager.LoadScene("Cena2",LoadSceneMode.Additive);
        btnCena2.style.display = DisplayStyle.None;
        btnSair.style.display = DisplayStyle.None;
        btnVoltar.style.display = DisplayStyle.Flex;
        SceneManager.UnloadSceneAsync("Cena1");
        btnCena1.style.display = DisplayStyle.Flex;
    }

    private void BtnCena1_clicked()
    {
        SceneManager.LoadScene("Cena1",LoadSceneMode.Additive);
        btnCena1.style.display = DisplayStyle.None;
        btnSair.style.display = DisplayStyle.None;
        btnVoltar.style.display = DisplayStyle.Flex;
        SceneManager.UnloadSceneAsync("Cena2");
        btnCena2 .style.display = DisplayStyle.Flex;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
