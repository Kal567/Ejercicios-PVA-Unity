using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabDictionary : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject E;
    public GameObject F;
    public GameObject G;
    public GameObject H;
    public GameObject I;
    public GameObject J;
    public GameObject K;
    public GameObject L;
    public GameObject M;
    public GameObject N;
    public GameObject O;
    public GameObject P;
    public GameObject Q;
    public GameObject R;
    public GameObject S;
    public GameObject T;
    public static Dictionary<string, GameObject> prefabs = new Dictionary<string, GameObject>();

    private void Start() {
        prefabs.Add("A", A);
        prefabs.Add("B", B);
        prefabs.Add("C", C);
        prefabs.Add("D", D);
        prefabs.Add("E", E);
        prefabs.Add("F", F);
        prefabs.Add("G", G);
        prefabs.Add("H", H);
        prefabs.Add("I", I);
        prefabs.Add("J", J);
        prefabs.Add("K", K);
        prefabs.Add("L", L);
        prefabs.Add("M", M);
        prefabs.Add("N", N);
        prefabs.Add("O", O);
        prefabs.Add("P", P);
        prefabs.Add("Q", Q);
        prefabs.Add("R", R);
        prefabs.Add("S", S);
        prefabs.Add("T", T);
    }
}
