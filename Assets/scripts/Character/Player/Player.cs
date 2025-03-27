using UnityEngine;

public class Player : CharacterBase
{
    public CardLayoutManager layoutManager;//���Ʋ��ֹ�����
    public PlayerCardManager cardManager;
    public CardLibrarySO library;//��ų�ʼ���ƿ�

    private void Awake()
    {
        cardManager = new PlayerCardManager(library);
        SetPlayer("player1",100);
    }

    public void SetPlayer(string playerName, int maxHP)
    {
        this.characterName = playerName;
        this.maxHP = maxHP;
    }
}
