from collections import deque
n, l, r = map(int, input().split())
graph = []
city = []
result = 0
count = 1
for _ in range(n):
    graph.append(list(map(int, input().split())))
dx = [-1, 0, 1, 0]
dy = [0, -1, 0, 1]
q = deque()
q.append((0, 0))
while q:
    x, y = q.popleft()
    city.append((x, y))
    for i in range(4):
        nx = x + dx[i]
        ny = y + dy[i]
        if nx < 0 or ny < 0 or nx >= n or ny >= n:
            continue
        value = abs(graph[x][y] - graph[nx][ny])
        if value >= l and value <= r:
            q.append((nx, ny))
            result += graph[nx][ny]
            city.append((nx, ny))
    for i, j in city:
        graph[i][j] = result // len(city)
    count += 1
print(count)

