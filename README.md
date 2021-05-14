# jayjayjay

## _EWHA CANVAS_


## 유튜브 채널 및 시현영상 링크 
(링크 주소)


##  TODO list

#### [전시회 기획 관련 작업]
#####
[x]전시회 주제 고안
[x]전시회 주제와 맞는 작가들 선별
[x]작가들의 작품 중 전시할 작품 선별
[x]작품 전시 구역 선정 
[x]전시 구역 위도,경도 정확히 기록
[x]작품 전시작 설명 작성
[x]게이미피케이션 요소 고안

#### [application 생성 작업]
##### ui/ux 관련 작업
#####
[x]전시회 맵 생성
[x]오프닝 씬 생성
[x]전시회 구역을 나타내는 아이콘 생성
[x]전시 안내 팝업 창 생성
[x]다른 씬으로 이동하는 버튼 생성
[x]게이미피케이션 요소 생성
[x] 작품 전시작 설명 이미지 생성

##### 개발 작업
#####
[x]유니티 안드로이드 환경에서 개발
[x]AR 마커인식 및 AR 오브젝트 생성 
[x]GPS 인식 및 GPS기반 AR오브젝트 생성 
[x]Marker AR + Markerless AR 병합 
[x]AR SDK 및 안드로이드 스튜디오 연동
[x]Toggle 기능 구현
[x]Player prefs으로 사용자 정보 저장
[x]AR 물체 터치와 관련된 interaction 작업 
[x]scene과 AR Camera간 전환 작업 



## 프로젝트 branch 정리

#### 1.작품 사진 및 설명 모음 branch

#### 2.마커인식 및 위치인식 branch

#### 3.게임시스템 관련 SCRIPT branch


## 프로젝트의 목적
####
캠퍼스 내에 체험형 야외 AR 미술관을 구현한다. 
 
 : 시범적으로 이화여대 학생들을 대상으로, 학생들의 일상적인 공간인 학교 캠퍼스에 야외 미술관 설치한다. 전시는 모바일 AR 앱 형태로 제공하여 스마트폰만 소지하면 캠퍼스 공간 내에서 미술관 관람이 가능하도록 한다. 갤러리라는 물리적 공간의 제약을 없애고 학생들의 일상적인 공간 속에서 공간적 성격과 부합하는 미적체험을 제공한다는 점에서 새로운 가치를 가진다. 또한 어플리케이션에 게임적 요소를 도입하여 게임을 통해 전시회를 관람하도록 하여 흥미와 집중도를 높였다. 이와같은 게이미피케이션 요소를 통해 사용자는 전시 작품 설명을 더 주의깊게 보고 배워갈 수 있다. AR기술을 활용한 인터렉션 요소와 공간 스토리텔링과 부합하는 게임 스토리텔링 전시를 통해 효과적인 관람을 유도할 계획이다.

## 시나리오
####
1.어플리케이션에 접속, 게임 시작
2.메뉴에서 원하는 구역 선택
3.구역에 입장하기 전 지정된 작가 설명 읽기 
4.화면에 표시되는 AR 작품을 관람할 위치로 이동하기
5.AR 작품이 나타나면 터치하여 작품 설명과 함께 작품 감상하기
6.AR 작품에 숨겨진 글자들을 찾아서  마커인식을 할 위치 찾아내기
7.마커인식으로 여성 작가들의 조언과 아이템 획득하기!
8.모든 구역에서 조언과 물품을 전부 획득했다면 map에  새롭게 열린 보너스 scene 구역으로 이동
9.보너스 scene에서 나타나는 새로운 작품들 즐기기


## 프로젝트 아키텍처
![image](https://user-images.githubusercontent.com/71870316/118229493-0b89bd80-b4c7-11eb-8f97-4d2440b62226.png)

## 관련 연구/서비스/시스템 조사 결과 및 한계점 
####
1. 해외 사례 : 정부 차원의 사회적 정책 시행(갤러리 운영 활성화, 관람료 할인 등)
 장점) 정책적으로 아티스트를 후원하고 사람들이 일상에서 쉽게 예술작품을 접할 수 있는 문화적 토양을 제공할 수 있다.
 단점) 해외국가와 우리나라간의 문화적 환경의 차이가 존재하여 현실적으로 불가능한 부분이 많고, 재정적 부담이 존재한다.
 
 2. 일상공간에 부분적 AR체험 제공(지하철역, 공원등에 AR스팟 제공)
 장점) 미적체험의 접근성을 낮추고 미술관/전시회 등의 공간적 한계를 어느정도 극복하였다.
 단점) AR을 체험하게 하는 유도 요인이 부족하여 낮은 참여율을 보인다. 또한 지하철역 등은 이동성이 높은 공간이어서 미적체험에 적합하지 않는 것을 보아 공간의 특성에 대한 고려가 부족하다.
 
 3. VR 미술관
 장점) 공간적 한계를 거의 극복하였다.
 단점) VR기기 소유가 일반적이지 않아 접근성이 떨어진다. (미술관 안에서 제공하는 VR체험 같은 경우, VR기기가 제공되지만, 미술관에 가야 한다는 접근성의 문제는 해결되지 않는다.)

end
