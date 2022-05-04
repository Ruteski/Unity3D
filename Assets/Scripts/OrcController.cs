using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcController : MonoBehaviour
{
    public List<Orc> OrcList = new List<Orc>();

    Dictionary<string, Orc> orcDic = new Dictionary<string, Orc>();

    // Start is called before the first frame update
    void Start()
    {
        //UsingList();
        UsingDict();


    }

    public void UsingList() {
        OrcList.Add(new Orc("durotan", 10));
        OrcList.Add(new Orc("draka", 20));
        OrcList.Add(new Orc("agrallan", 30));

        foreach (Orc orc in OrcList) {
            Debug.Log(orc.nome);
        }
    }

    public void UsingDict() {
        Orc orc1 = new Orc("duct", 50);
        Orc orc2 = new Orc("vardo", 120);
        Orc orc3 = new Orc("nirdo", 750);

        orcDic.Add("guerreiro", orc1);
        orcDic.Add("cozinheiro", orc2);
        orcDic.Add("mago", orc3);

        Orc orc4 = orcDic["mago"];
        Orc orc5 = null;

        if (orcDic.TryGetValue("mago", out orc4)) {
            Debug.Log("existe");
        } else {
            Debug.Log("nao existe");
        }
    }

}
