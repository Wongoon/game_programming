using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public Color[] cubeColors;
    public GameObject cubePrefab;
    public Transform generatePos;
    public float span = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("GenerateCubes");
    }
    private IEnumerator GenerateCubes(){ // 코루틴 정의
        while(true){
            GameObject c = Instantiate(cubePrefab, generatePos); // 생성해 c에 저장
            MeshRenderer[] mrs = c.GetComponentsInChildren<MeshRenderer>(); // cubePrefab c의 children(각각의 큐브)의 MeshRenderer (재질 등 관리), 9개 있으므로 리스트에 저ㅏㅈㅇ
            for(int i = 0; i < mrs.Length; i++){ // 각각의 MeshRenderer에 접근
                int index = Random.Range(0, cubeColors.Length); // 랜덤하게 색깔의 인덱스 결정
                mrs[i].material.color = cubeColors[index]; // 그 인덱스에 해당한 색깔을 MeshRenderer material의 color로 설정
            }
            yield return new WaitForSeconds(span); // 코루틴 문법
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
