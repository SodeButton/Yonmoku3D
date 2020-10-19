using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour {
	static public float Gammma = 0.9f;
	static public float alpha = 0.3f;
	static public float epsilon = 0.2f;

	static public List<int[,]> QValue = new List<int[,]>();

	public struct NetWork {
		bool isPutting;
	}

	static public NetWork[,,] network;

	static public List<List<Stone>> NetWorks = new List<List<Stone>>();
	static public List<List<Stone>> LastNetWorks = new List<List<Stone>>();
}
