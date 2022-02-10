n = int(input())
a = int(input())
graph = [[0] * n for _ in range(n)]
direction = []
for _ in range(a):
    x, y = input().split()
    graph[x-1][y-1] = 1  # 사과 있으면 1, 없으면 0
d = int(input())
for _ in range(d):
    x, c = input().split()
    direction.append((int(x), c))

dx = [-1, 0, 1, 0]  # 북 서 남 동
dy = [0, -1, 0, 1]
time = 0
x, y = 0, 0  # 뱀의 머리 좌표
d = 3  # 뱀의 방향, 처음은 동쪽
q = [(x, y)]  # 뱀이 차지하고 있는 위치 정보(꼬리가 앞쪽)
graph[x][y] = 2
index = 0
def turn_right():
    global d
    d -= 1
    if d == -1:
        d = 3
def turn_left():
    global d
    d += 1
    if d == 4:
        d = 0

while(True):
    nx = x + dx[d]
    ny = y + dy[d]
    if 0 <= nx and nx < n and 0 <= ny and ny < n and graph[nx][ny] != 2:
        # 맵 안에 있고 뱀의 몸통이 없는 위치라면 (몸통 부딪히면 x)
        if graph[nx][ny] == 0:
            graph[nx][ny] = 2
            q.append((nx, ny))
            tx, ty = q.pop(0)
            graph[tx][ty] = 0
        # 만약 사과가 있다면 이동 후 꼬리 그대로 두기
        if graph[nx][ny] == 1:
            graph[nx][ny] = 2
            q.append((nx, ny))
    else: # 벽이나 몸통에 부딪힌 경우
        time += 1
        break
    x, y = nx, ny
    time += 1
    if index < 1 and time == direction[index][0]:
        if direction[index][1] == 'D':
            turn_right()
        if direction[index][1] == 'L':
            turn_left()
        index += 1
print(time)

