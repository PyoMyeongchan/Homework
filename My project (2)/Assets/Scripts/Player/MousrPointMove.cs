using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 destPos;
    Vector3 dir;
    Quaternion lookTarget;

    bool move = false;

    private void Start()
    {

    }

    private void Update()
    {
        // 왼쪽 마우스 버튼을 눌렀을 때
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            // 메인 카메라를 통해 마우스 클릭한 곳의 ray 정보를 가져옴
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // ray와 닿은 물체가 있는지 검사
            if (Physics.Raycast(ray, out hit, 100f))
            {
                print(hit.transform.name);

                // hit.point 는 마우스 클릭한 곳의 월드 좌표.
                // 이 예제에서 캐릭터의 y 값(높이) 은 변하지 않기 때문에 
                // 아래와 같이 목표위치를 재설정합니다.
                destPos = new Vector3(hit.point.x, transform.position.y, hit.point.z);

                // 현재 위치와 목표 위치의 방향 벡터
                dir = destPos - transform.position;

                // 바라 보아야 할 곳의 Quaternion
                lookTarget = Quaternion.LookRotation(dir);
                move = true;
            }
        }

        Move();
    }

    void Move()
    {
        if (move)
        {
            // 이동할 방향으로 Time.deltaTime * 2f 의 속도로 움직임.
            transform.position += dir.normalized * Time.deltaTime * 2f;
            // 현재 방향에서 움직여야할 방향으로 부드럽게 회전
            transform.rotation = Quaternion.Lerp(transform.rotation, lookTarget, 0.25f);

            // 캐릭터의 위치와 목표 위치의 거리가 0.05f 보다 큰 동안만 이동
            move = (transform.position - destPos).magnitude > 0.05f;
        }
    }
}
