using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevelHandler : MonoBehaviour
{
    public GameObject SpawnerOutside;
    private float SpawnerOutsideX;
    private float SpawnerOutsideY;
    // public GameObject LeaverOutside;
    public GameObject SpawnerEingangsbereichVonOutside;
    public GameObject SpawnerEingangsbereichVonKueche;
    public GameObject SpawnerEingangsbereichVonWohnzimmer;
    public GameObject SpawnerEingangsbereichVonKeller;
    private float SpawnerEingangsbereichVonOutsideX;
    private float SpawnerEingangsbereichVonOutsideY;
    private float SpawnerEingangsbereichVonKuecheX;
    private float SpawnerEingangsbereichVonKuecheY;
    private float SpawnerEingangsbereichVonWohnzimmerX;
    private float SpawnerEingangsbereichVonWohnzimmerY;
    private float SpawnerEingangsbereichVonKellerX;
    private float SpawnerEingangsbereichVonKellerY;
    // public GameObject LeaverEingangsbereichZuWohnzimmer;
    // public GameObject LeaverEingangsbereichZuKueche;
    // public GameObject LeaverEingangsbereichZuWaschkueche;
    public GameObject SpawnerKuecheVonEingangshalle;
    public GameObject SpawnerKuecheVonAbstellraum;
    private float SpawnerKuecheVonEingangshalleX;
    private float SpawnerKuecheVonEingangshalleY;
    private float SpawnerKuecheVonAbstellraumX;
    private float SpawnerKuecheVonAbstellraumY;
    // public GameObject LeaverKuecheZuEingangshalle;
    // public GameObject LeaverKuecheZuAbstellraum;
    public GameObject SpawnerWohnzimmerVonEingangshalle;
    public GameObject SpawnerWohnzimmerVonEsszimmer;
    private float SpawnerWohnzimmerVonEingangshalleX;
    private float SpawnerWohnzimmerVonEingangshalleY;
    private float SpawnerWohnzimmerVonEsszimmerX;
    private float SpawnerWohnzimmerVonEsszimmerY;
    // public GameObject LeaverWohnzimmerZuEsszimmer;
    // public GameObject LeaverWohnzimmerZuEingangshalle;
    public GameObject SpawnerObergeschoss;
    private float SpawnerObergeschossX;
    private float SpawnerObergeschossY;
    // public GameObject LeaverObergeschoss;
    public GameObject SpawnerAbstellkammerVonKueche;
    public GameObject SpawnerAbstellkammerVonKeller;
    private float SpawnerAbstellkammerVonKuecheX;
    private float SpawnerAbstellkammerVonKuecheY;
    private float SpawnerAbstellkammerVonKellerX;
    private float SpawnerAbstellkammerVonKellerY;
    // public GameObject LeaverAbstellkammerZuKeller;
    // public GameObject LeaverAbstellkammerZuKueche;
    public GameObject SpawnerEsszimmerVonWohnzimmer;
    private float SpawnerEsszimmerVonWohnzimmerX;
    private float SpawnerEsszimmerVonWohnzimmerY;
    // public GameObject LeaverEsszimmerZuWohnzimmer;
    public GameObject SpawnerGarageVonWaschkueche;
    private float SpawnerGarageVonWaschkuecheX;
    private float SpawnerGarageVonWaschkuecheY;
    // public GameObject LeaverGarageZuWaschkueche;
    public GameObject SpawnerWaschkuecheVonGarage;
    public GameObject SpawnerWaschkuecheVonEingangshalle;
    private float SpawnerWaschkuecheVonGarageX;
    private float SpawnerWaschkuecheVonGarageY;
    private float SpawnerWaschkuecheVonEingangshalleX;
    private float SpawnerWaschkuecheVonEingangshalleY;
    // public GameObject LeaverWaschkuecheZuGarage;
    // public GameObject LeaverWaschkuecheZuEingangshalle;
    public GameObject SpielerChar;

    void Start()
    {
        spawnerAbfragen();
    }

    void spawnerAbfragen()
    {
        SpawnerOutsideX = SpawnerOutside.transform.position.x;
        SpawnerOutsideY = SpawnerOutside.transform.position.y;
        /*
        SpawnerEingangsbereichX = SpawnerEingangsbereich.transform.position.x;
        SpawnerEingangsbereichY = SpawnerEingangsbereich.transform.position.y;
        SpawnerKuecheX = SpawnerKueche.transform.position.x;
        SpawnerKuecheY = SpawnerKueche.transform.position.y;
        SpawnerWohnzimmerX = SpawnerWohnzimmer.transform.position.x;
        SpawnerWohnzimmerY = SpawnerWohnzimmer.transform.position.y;
        SpawnerObergeschossX = SpawnerObergeschoss.transform.position.x;
        SpawnerObergeschossY = SpawnerObergeschoss.transform.position.y;
        SpawnerAbstellkammerX = SpawnerAbstellkammer.transform.position.x;
        SpawnerAbstellkammerY = SpawnerAbstellkammer.transform.position.y;
        SpawnerEsszimmerX = SpawnerEsszimmer.transform.position.x;
        SpawnerEsszimmerY = SpawnerEsszimmer.transform.position.y;
        SpawnerGarageX = SpawnerGarage.transform.position.x;
        SpawnerGarageY = SpawnerGarage.transform.position.y;
        SpawnerWaschkücheX = SpawnerWaschküche.transform.position.x;
        SpawnerWaschkücheY = SpawnerWaschküche.transform.position.y; */
        SpawnerEingangsbereichVonOutsideX = SpawnerEingangsbereichVonOutside.transform.position.x;
        SpawnerEingangsbereichVonOutsideY = SpawnerEingangsbereichVonOutside.transform.position.y;
        SpawnerEingangsbereichVonKuecheX = SpawnerEingangsbereichVonKueche.transform.position.x;
        SpawnerEingangsbereichVonKuecheY = SpawnerEingangsbereichVonKueche.transform.position.y;
        SpawnerEingangsbereichVonWohnzimmerX = SpawnerEingangsbereichVonWohnzimmer.transform.position.x;
        SpawnerEingangsbereichVonWohnzimmerY = SpawnerEingangsbereichVonWohnzimmer.transform.position.x;
        SpawnerEingangsbereichVonKellerX = SpawnerEingangsbereichVonKeller.transform.position.x;
        SpawnerEingangsbereichVonKellerY = SpawnerEingangsbereichVonKeller.transform.position.y;
        SpawnerKuecheVonEingangshalleX = SpawnerKuecheVonEingangshalle.transform.position.x;
        SpawnerKuecheVonEingangshalleY = SpawnerKuecheVonEingangshalle.transform.position.y;
        SpawnerKuecheVonAbstellraumX = SpawnerKuecheVonAbstellraum.transform.position.x;
        SpawnerKuecheVonAbstellraumY = SpawnerKuecheVonAbstellraum.transform.position.y;
        SpawnerWohnzimmerVonEingangshalleX = SpawnerWohnzimmerVonEingangshalle.transform.position.x;
        SpawnerWohnzimmerVonEingangshalleY = SpawnerWohnzimmerVonEingangshalle.transform.position.y;
        SpawnerWohnzimmerVonEsszimmerX = SpawnerWohnzimmerVonEsszimmer.transform.position.x;
        SpawnerWohnzimmerVonEsszimmerY = SpawnerWohnzimmerVonEsszimmer.transform.position.y;
        SpawnerAbstellkammerVonKuecheX = SpawnerAbstellkammerVonKueche.transform.position.x;
        SpawnerAbstellkammerVonKuecheY = SpawnerAbstellkammerVonKueche.transform.position.y;
        SpawnerAbstellkammerVonKellerX = SpawnerAbstellkammerVonKeller.transform.position.x;
        SpawnerAbstellkammerVonKellerY = SpawnerAbstellkammerVonKeller.transform.position.y;
        SpawnerEsszimmerVonWohnzimmerX = SpawnerEsszimmerVonWohnzimmer.transform.position.x;
        SpawnerEsszimmerVonWohnzimmerY = SpawnerEsszimmerVonWohnzimmer.transform.position.y;
        SpawnerGarageVonWaschkuecheX = SpawnerGarageVonWaschkueche.transform.position.x;
        SpawnerGarageVonWaschkuecheY = SpawnerGarageVonWaschkueche.transform.position.y;
        SpawnerWaschkuecheVonGarageX = SpawnerWaschkuecheVonGarage.transform.position.x;
        SpawnerWaschkuecheVonGarageY = SpawnerWaschkuecheVonGarage.transform.position.y;
        SpawnerWaschkuecheVonEingangshalleX = SpawnerWaschkuecheVonEingangshalle.transform.position.x;
        SpawnerWaschkuecheVonEingangshalleY = SpawnerWaschkuecheVonEingangshalle.transform.position.y;
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        spawnerAbfragen();
        
        if (coll.gameObject == SpawnerOutside)
        {
            SpielerChar.transform.position = new Vector2(SpawnerOutsideX, SpawnerOutsideY);
        }
        if (coll.gameObject == SpawnerEingangsbereichVonOutside)
        {
            SpielerChar.transform.position = new Vector2(SpawnerEingangsbereichVonOutsideX, SpawnerEingangsbereichVonOutsideY);
        }
        if (coll.gameObject == SpawnerEingangsbereichVonKueche)
        {
            SpielerChar.transform.position = new Vector2(SpawnerEingangsbereichVonKuecheX, SpawnerEingangsbereichVonKuecheY);
        }
        if (coll.gameObject == SpawnerEingangsbereichVonKeller)
        {
            SpielerChar.transform.position = new Vector2(SpawnerEingangsbereichVonKellerX, SpawnerEingangsbereichVonKellerY);
        }
        if (coll.gameObject == SpawnerKuecheVonEingangshalle)
        {
            SpielerChar.transform.position = new Vector2(SpawnerKuecheVonEingangshalleX, SpawnerKuecheVonEingangshalleY);
        }
        if (coll.gameObject == SpawnerKuecheVonAbstellraum)
        {
            SpielerChar.transform.position = new Vector2(SpawnerKuecheVonAbstellraumX, SpawnerKuecheVonAbstellraumY);
        }
        if (coll.gameObject == SpawnerWohnzimmerVonEingangshalle)
        {
            SpielerChar.transform.position = new Vector2(SpawnerWohnzimmerVonEingangshalleX, SpawnerWohnzimmerVonEingangshalleY);
        }
        if (coll.gameObject == SpawnerWohnzimmerVonEsszimmer)
        {
            SpielerChar.transform.position = new Vector2(SpawnerWohnzimmerVonEsszimmerX, SpawnerWohnzimmerVonEsszimmerY);
        }
        if (coll.gameObject == SpawnerAbstellkammerVonKueche)
        {
            SpielerChar.transform.position = new Vector2(SpawnerAbstellkammerVonKuecheX, SpawnerAbstellkammerVonKuecheY);
        }
        if (coll.gameObject == SpawnerAbstellkammerVonKeller)
        {
            SpielerChar.transform.position = new Vector2(SpawnerAbstellkammerVonKellerX, SpawnerAbstellkammerVonKellerY);
        }
        if (coll.gameObject == SpawnerEsszimmerVonWohnzimmer)
        {
            SpielerChar.transform.position = new Vector2(SpawnerEsszimmerVonWohnzimmerX, SpawnerEsszimmerVonWohnzimmerY);
        }
        if (coll.gameObject == SpawnerGarageVonWaschkueche)
        {
            SpielerChar.transform.position = new Vector2(SpawnerGarageVonWaschkuecheX, SpawnerGarageVonWaschkuecheY);
        }
        if (coll.gameObject == SpawnerWaschkuecheVonGarage)
        {
            SpielerChar.transform.position = new Vector2(SpawnerWaschkuecheVonGarageX, SpawnerWaschkuecheVonGarageY);
        }
        if (coll.gameObject == SpawnerWaschkuecheVonEingangshalle)
        {
            SpielerChar.transform.position = new Vector2(SpawnerWaschkuecheVonEingangshalleX, SpawnerWaschkuecheVonEingangshalleY);
        }
    }
}
