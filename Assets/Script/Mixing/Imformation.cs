using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Imformation : MonoBehaviour
{
    private Text Information;
    public GameObject Recipt;
    public GameObject recipt;
    void Update()
    {
        Information = recipt.GetComponent<Text>();
    }

    public void Return()
    {
        Recipt.gameObject.SetActive(true);
        recipt.gameObject.SetActive(false);
    }
    public  void Seogyang()
    {
        Recipt. gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "석양" + "\n" + "\n" + "아이렌3 아우룸1 코코넛주스1 크랜베리 시럽" + "\n" + "build";
    }
    public void RoyalMorning()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "로얄 모닝" + "\n" + "\n" + "브르기키2 로열1 토마토주스3 소금" + "\n" + "build";
    }
    public void KattCock()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "캬트 콕" + "\n" + "\n" + "캬트2 소다4 얼음" + "\n" + "build";
    }
    public void AurumCock()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "아우룸 콕" + "\n" + "\n" + "아우룸2 소다4 얼음" + "\n" + "build";
    }
    public void RoyalCock()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "로열 콕" + "\n" + "\n" + "로열2 소다4 얼음" + "\n" + "build";
    }
    public void AirenCock()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "아이렌 콕" + "\n" + "\n" + "아이렌2 소다4 얼음" + "\n" + "build";
    }
    public void BrgikyCock()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "브르기키 콕" + "\n" + "\n" + "브르기키2 소다4 얼음" + "\n" + "build";
    }
    public void K2C()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "K2C" + "\n" + "\n" + "로열5 브르기키4" + "\n" + "build";
    }
    public void Souren()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "샤워렌" + "\n" + "\n" + "아이렌2 로열4 오렌지 시럽 얼음" + "\n" + "build";
    }
    public void BrgikyFloat()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "브르기키 플룻" + "\n" + "\n" + "캬트1 브르기키3 소다1 설탕 얼음" + "\n" + "build";
    }
    public void BeeRoyal()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "비 로열" + "\n" + "\n" + "브리기키2 아우룸1 로열2 설탕 얼음" + "\n" + "build";
    }
    public void FruitBoobs()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "후르츠 밤" + "\n" + "\n" + "아이렌3 로열1 소다3 얼음" + "\n" + "blending";
    }
    public void ThePool()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "더 풀" + "\n" + "\n" + "브리기키2 아이렌1 아우룸5 라임주스1 꿀 얼음" + "\n" + "blending" + "\n" + "소금" + "\n" + "build";
    }
    public void Black()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "흑" + "\n" + "\n" + "캬트2 아우룸5 꿀 얼음" + "\n" + "blending" + "\n" + "소금" + "\n" + "build";
    }
    public void Sapphire()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "사파이어 블라스트" + "\n" + "\n" + "캬트3 브르기키1 로얄2 소다2 크랜베리 시럽 얼음" + "\n" + "blending";
    }
    public void Ruby()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "루비 블라스트" + "\n" + "\n" + "캬트3 브르기키1 아이렌2 소다2 크랜베리 시럽 얼음" + "\n" + "blending";
    }
    public void Cantabile()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "칸타빌레" + "\n" + "\n" + "아이렌2 아우룸1 로열1 체리주스 얼음" + "\n" + "blending";
    }
    public void DeepKatt()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "딥 캬트" + "\n" + "\n" + "캬트7 얼음" + "\n" + "blending";
    }
    public void AlcohoRaid()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "알콜레이드" + "\n" + "\n" + "캬트3 아이렌1 로열1 라임주스1 오렌지 시럽" + "\n" + "Shake" + "\n" + "소금" + "\n" + "build";
    }
    public void NoDog()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "노 도그" + "\n" + "\n" + "캬트1 아이렌4 로열1 초콜릿 시럽" + "\n" + "Shake" + "\n" + "설탕" + "\n" + "build";
    }
    public void Freya()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "프레이야" + "\n" + "\n" + "캬트2 브르기키1 아이렌1 아우룸1 로열1 사과주스2 꿀" + "\n" + "Shake" + "\n" + "설탕" + "\n" + "build";
    }
    public void ScorchingSun()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "비 로열" + "\n" + "\n" + "캬트3 브르기키2 소다1" + "\n" + "Shake" + "\n" + "소금" + "\n" + "build";
    }
    public void HeatWave()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "비 로열" + "\n" + "\n" + "캬트3 브르기키4 소다1" + "\n" + "Shake" + "\n" + "소금" + "\n" + "build";
    }
    public void EmeraldBeach()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "비 로열" + "\n" + "\n" + "아이렌3 로열3 라임주스1 코코넛주스1 멜론시럽" + "\n" + "Shake";
    }
    public void Lost()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "비 로열" + "\n" + "\n" + "브르기키3 아이렌1 아우룸4 얼음" + "\n" + "Shake";
    }
    public void Harmony()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "비 로열" + "\n" + "\n" + "캬트3 아이렌2 아우룸1 체리주스" + "\n" + "Shake";
    }
    public void HerbBuble()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "비 로열" + "\n" + "\n" + "캬트1 아이렌1 아우룸5" + "\n" + "Shake";
    }
    public void Witch()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "위치" + "\n" + "\n" + "아이렌3 아우룸1 로열2 사과주스1" + "\n" + "Stirring";
    }
    public void Imoogi()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "이무기" + "\n" + "\n" + "캬트1 아이렌3 아우룸2 꿀 설탕" + "\n" + "Stirring";
    }
    public void Peace()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "피스" + "\n" + "\n" + "캬트1 아우룸1 로열1 아이렌1 브르기키1" + "\n" + "Stirring";
    }
    public void Killer()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "킬러" + "\n" + "\n" + "캬트2 아이렌1 로열1 코코넛주스1" + "\n" + "Stirring";
    }
    public void RuMilk()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "루 밀크" + "\n" + "\n" + "캬트4 아이렌3 소다1" + "\n" + "Stirring";
    }
    public void RoyalJelly()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "로열 젤리" + "\n" + "\n" + "아이렌2 라임주스1 꿀 설탕" + "\n" + "Stirring";
    }
    public void RoyalOrange()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "로열 오렌지" + "\n" + "\n" + "캬트1 아이렌2 로열4 오렌지 시럽 설탕" + "\n" + "Stirring";
    }
    public void KiKi()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "키키" + "\n" + "\n" + "브르기키1 로열4 초콜릿시럽" + "\n" + "Stirring";
    }
}
